using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace G13_Railway_Management_System
{
    public partial class PassengerProfile : UserControl
    {
        string connectionString;
        string pID;
        public PassengerProfile(string connectionString, string pID)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.pID = pID;

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT U.firstName, U.lastName, U.email, U.password, U.phoneNumber, U.address, U.CNIC, U.profilePicture FROM USERS U INNER JOIN PASSENGER P ON P.userID = U.userID WHERE passengerID = :passengerID";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("passengerID", OracleDbType.Varchar2).Value = pID;
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBoxPassengerFirstname.Text = reader["firstName"].ToString();
                                textBoxPassengerLastname.Text = reader["lastName"].ToString();
                                textBoxPassengerEmail.Text = reader["email"].ToString();
                                textBoxPassengerPassword.Text = reader["password"].ToString();
                                textBoxPassengerPhonenumber.Text = reader["phoneNumber"].ToString();
                                textBoxPassengerAddress.Text = reader["address"].ToString();
                                textBoxPassengercnic.Text = reader["cnic"].ToString();

                                if (!Convert.IsDBNull(reader["profilePicture"]))
                                {
                                    pictureBoxProfilePicture.Image = blobToImage((byte[])reader["profilePicture"]);
                                }
                            }
                            else
                            {
                                MessageBox.Show("USER NOT FOUND ");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
        }

        private void buttonPassengerSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPassengerEmail.Text) && string.IsNullOrEmpty(textBoxPassengerPassword.Text))
            {
                MessageBox.Show("Please enter email and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBoxPassengerEmail.Text))
            {
                MessageBox.Show("Please enter email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBoxPassengerPassword.Text))
            {
                MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBoxPassengercnic.Text))
            {
                MessageBox.Show("Please enter cnic!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PasswordScore passwordStrengthScore = PasswordAdvisor.CheckStrength(textBoxPassengerPassword.Text);
            bool strongPassword = false;

            switch (passwordStrengthScore)
            {
                case PasswordScore.VeryWeak:
                    MessageBox.Show("Please enter a medium/strong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPassengerPassword.Clear();
                    return;
                //break;
                case PasswordScore.Weak:
                    MessageBox.Show("Please enter a medium/strong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPassengerPassword.Clear();
                    return;
                //break;
                case PasswordScore.Medium:
                    strongPassword = true;
                    break;
                case PasswordScore.Strong:
                    strongPassword = true;
                    break;
                case PasswordScore.VeryStrong:
                    strongPassword = true;
                    break;
            }

            if (IsValid(textBoxPassengerEmail.Text) == false)
            {
                textBoxPassengerEmail.Clear();
                textBoxPassengerPassword.Clear();
                MessageBox.Show("Please enter a valid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fname = textBoxPassengerFirstname.Text,
                lname = textBoxPassengerLastname.Text,
                email = textBoxPassengerEmail.Text.ToLower(),
                phoneNo = textBoxPassengerPhonenumber.Text,
                cnic = textBoxPassengercnic.Text,
                address = textBoxPassengerAddress.Text,
                password = textBoxPassengerPassword.Text;

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string queryUpdate = "UPDATE USERS SET FIRSTNAME = :firstName, LASTNAME = :lastName, PASSWORD = :password, EMAIL = :email,PHONENUMBER = :phoneNumber,CNIC = :cnic, ADDRESS = :address, PROFILEPICTURE = :profilePicture WHERE userID = (SELECT userID FROM PASSENGER WHERE PASSENGERID = :PASSENGERID)";
                    using (OracleCommand command = new OracleCommand(queryUpdate, connection))
                    {
                        command.Parameters.Add("firstName", OracleDbType.Varchar2).Value = fname;
                        command.Parameters.Add("lastName", OracleDbType.Varchar2).Value = lname;
                        command.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
                        command.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
                        command.Parameters.Add("phoneNumber", OracleDbType.Int32).Value = phoneNo;
                        command.Parameters.Add("cnic", OracleDbType.Int32).Value = cnic;
                        command.Parameters.Add("address", OracleDbType.Varchar2).Value = address;
                        command.Parameters.Add("profilePicture", OracleDbType.Blob).Value = getPhoto();
                        command.Parameters.Add("passengerID", OracleDbType.Varchar2).Value = pID;
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error ");
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProfilePicture.Image = new Bitmap(openFileDialog.FileName);
            }
        }
        private byte[] getPhoto()
        {
            //MemoryStream memoryStream = new MemoryStream();
            //pictureBoxProfilePicture.Image.Save(memoryStream, pictureBoxProfilePicture.Image.RawFormat);
            //return memoryStream.GetBuffer();
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(pictureBoxProfilePicture.Image, typeof(byte[]));
        }

        private Image blobToImage(byte[] byteImage)
        {
            return new Bitmap(new MemoryStream(byteImage));
        }

        private void textBoxPassengerPassword_TextChanged(object sender, EventArgs e)
        {
            string password = textBoxPassengerPassword.Text;
            PasswordScore passwordStrengthScore = PasswordAdvisor.CheckStrength(password);
            switch (passwordStrengthScore)
            {
                case PasswordScore.VeryWeak:
                    passwordStrengthLabel.Text = "Very Weak";
                    break;
                case PasswordScore.Weak:
                    passwordStrengthLabel.Text = "Weak";
                    // Show an error message to the user
                    break;
                case PasswordScore.Medium:
                    passwordStrengthLabel.Text = "Medium";
                    break;
                case PasswordScore.Strong:
                    passwordStrengthLabel.Text = "Strong";
                    break;
                case PasswordScore.VeryStrong:
                    passwordStrengthLabel.Text = "Very Strong";
                    // Password deemed strong enough, allow user to be added to database etc
                    break;
            }

            if (password.Length >= 8)
            {
                passwordCheckedListBox.SetItemChecked(0, true);
            }
            else
            {
                passwordCheckedListBox.SetItemChecked(0, false);
            }

            if (Regex.IsMatch(password, @"[A-Z]"))
            {
                passwordCheckedListBox.SetItemChecked(1, true);
            }
            else
            {
                passwordCheckedListBox.SetItemChecked(1, false);
            }

            if (Regex.IsMatch(password, @"[a-z]"))
            {
                passwordCheckedListBox.SetItemChecked(2, true);
            }
            else
            {
                passwordCheckedListBox.SetItemChecked(2, false);
            }

            if (Regex.IsMatch(password, @"\d"))
            {
                passwordCheckedListBox.SetItemChecked(3, true);
            }
            else
            {
                passwordCheckedListBox.SetItemChecked(3, false);
            }

            if (Regex.IsMatch(password, @"[^\w]"))
            {
                passwordCheckedListBox.SetItemChecked(4, true);
            }
            else
            {
                passwordCheckedListBox.SetItemChecked(4, false);
            }
        }
        private static bool IsValid(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
        }
    }
}

