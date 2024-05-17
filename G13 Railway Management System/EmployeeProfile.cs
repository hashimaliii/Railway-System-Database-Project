using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace G13_Railway_Management_System
{
    public partial class EmployeeProfile : UserControl
    {
        string connectionString, eID;
        public EmployeeProfile(string connectionString, string eID)
        {
            this.connectionString = connectionString;
            this.eID = eID;
            InitializeComponent();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT U.firstName, U.lastName, U.email, U.password, U.phoneNumber, U.address, U.CNIC, U.profilePicture FROM USERS U INNER JOIN EMPLOYEE E ON E.userID = U.userID WHERE employeeID = :employeeID";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("employeeID", OracleDbType.Varchar2).Value = eID;
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBoxEmployeeFirstname.Text = reader["firstName"].ToString();
                                textBoxEmployeeLastname.Text = reader["lastName"].ToString();
                                textBoxEmployeeEmail.Text = reader["email"].ToString();
                                textBoxEmployeePassword.Text = reader["password"].ToString();
                                textBoxEmployeePhonenumber.Text = reader["phoneNumber"].ToString();
                                textBoxEmployeeAddress.Text = reader["address"].ToString();
                                textBoxEmployeecnic.Text = reader["cnic"].ToString();

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

        private void buttonChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProfilePicture.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void buttonEmployeeSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmployeeEmail.Text) && string.IsNullOrEmpty(textBoxEmployeePassword.Text))
            {
                MessageBox.Show("Please enter email and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBoxEmployeeEmail.Text))
            {
                MessageBox.Show("Please enter email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBoxEmployeePassword.Text))
            {
                MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBoxEmployeecnic.Text))
            {
                MessageBox.Show("Please enter cnic!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PasswordScore passwordStrengthScore = PasswordAdvisor.CheckStrength(textBoxEmployeePassword.Text);
            bool strongPassword = false;

            switch (passwordStrengthScore)
            {
                case PasswordScore.VeryWeak:
                    MessageBox.Show("Please enter a medium/strong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxEmployeePassword.Clear();
                    return;
                //break;
                case PasswordScore.Weak:
                    MessageBox.Show("Please enter a medium/strong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxEmployeePassword.Clear();
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

            if (IsValid(textBoxEmployeeEmail.Text) == false)
            {
                textBoxEmployeeEmail.Clear();
                textBoxEmployeePassword.Clear();
                MessageBox.Show("Please enter a valid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fname = textBoxEmployeeFirstname.Text,
                lname = textBoxEmployeeLastname.Text,
                email = textBoxEmployeeEmail.Text.ToLower(),
                phoneNo = textBoxEmployeePhonenumber.Text,
                cnic = textBoxEmployeecnic.Text,
                address = textBoxEmployeeAddress.Text, 
                password = textBoxEmployeePassword.Text;

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string queryUpdate = "UPDATE USERS SET FIRSTNAME = :firstName, LASTNAME = :lastName, PASSWORD = :password, EMAIL = :email,PHONENUMBER = :phoneNumber,CNIC = :cnic, ADDRESS = :address, PROFILEPICTURE = :profilePicture WHERE userID = (SELECT userID FROM EMPLOYEE WHERE employeeID = :employeeID)";
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
                        command.Parameters.Add("employeeID", OracleDbType.Varchar2).Value = eID;
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
        }

        private Image blobToImage(byte[] byteImage)
        {
            return new Bitmap(new MemoryStream(byteImage));
        }

        private void textBoxEmployeePassword_TextChanged(object sender, EventArgs e)
        {
            string password = textBoxEmployeePassword.Text;
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

        private byte[] getPhoto()
        {
            //MemoryStream memoryStream = new MemoryStream();
            //pictureBoxProfilePicture.Image.Save(memoryStream, pictureBoxProfilePicture.Image.RawFormat);
            //return memoryStream.GetBuffer();
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(pictureBoxProfilePicture.Image, typeof(byte[]));
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
