using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace G13_Railway_Management_System
{
    public partial class OTP : Form
    {
        string fromEmail = "g13railway@gmail.com", password = "tdpr nobb lovl viqw";
        string random = string.Empty;
        Signup signupForm = null;
        Login loginForm = null;
        string connectionString = string.Empty;
        string Firstname, Lastname, Email, SignupPassword, Phonenumber, cnic, Address;
        byte[] profilePicture = null;
        public OTP(Signup signupForm, Login loginForm, string connectionString, string Firstname, string Lastname, string Email, string SignupPassword, string Phonenumber, string cnic, string Address, byte[] profilePicture)
        {
            InitializeComponent();
            this.signupForm = signupForm;
            this.loginForm = loginForm;
            this.connectionString = connectionString;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Email = Email;
            this.SignupPassword = SignupPassword;
            this.Phonenumber = Phonenumber;
            this.cnic = cnic;
            this.Address = Address;
            this.profilePicture = profilePicture;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Random rand = new Random();
            random = (rand.Next(999999).ToString());
        }

        private void buttonChangeEmail_Click(object sender, EventArgs e)
        {
            this.Hide();
            signupForm.Show();
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if (random == textBoxOTP.Text)
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        //MessageBox.Show("Connected to Oracle database.");

                        string query = "BEGIN INSERT INTO USERS (FIRSTNAME, LASTNAME, EMAIL, PASSWORD,  PHONENUMBER, CNIC, ADDRESS, PROFILEPICTURE) VALUES (:firstName, :lastName, :email, :password, :phoneNumber, :cnic, :address, :profilePicture); INSERT INTO PASSENGER (USERID) VALUES ((SELECT MAX (USERID) FROM USERS)); END;";
                        using (OracleCommand command = new OracleCommand(query, connection))
                        {
                            command.Parameters.Add("firstName", OracleDbType.Varchar2).Value = Firstname;
                            command.Parameters.Add("lastName", OracleDbType.Varchar2).Value = Lastname;
                            command.Parameters.Add("email", OracleDbType.Varchar2).Value = Email;
                            command.Parameters.Add("password", OracleDbType.Varchar2).Value = SignupPassword;
                            command.Parameters.Add("phoneNumber", OracleDbType.Int64).Value = Phonenumber;
                            command.Parameters.Add("cnic", OracleDbType.Int64).Value = cnic;
                            command.Parameters.Add("address", OracleDbType.Varchar2).Value = Address;
                            command.Parameters.Add("profilePicture", OracleDbType.Blob).Value = profilePicture;
                            int rowsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Signed Up Successfully");
                            this.Hide();
                            loginForm.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show("Error: " + ex.Message);
                        this.Hide();
                        signupForm.Show();
                    }
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid OTP Code");
            }
        }

        private void buttonSendOTP_Click(object sender, EventArgs e)
        {
            string messageBody = string.Empty;
            Random rand = new Random();
            random = (rand.Next(999999).ToString());
            MailMessage message = new MailMessage();
            messageBody = "Your OTP Code is " + random;
            message.To.Add(Email);
            message.From = new MailAddress(fromEmail);
            message.Body = messageBody;
            message.Subject = "Railway SignUp Verification";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(fromEmail, password);

            try
            {
                smtpClient.Send(message);
                MessageBox.Show("OTP Sent Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
