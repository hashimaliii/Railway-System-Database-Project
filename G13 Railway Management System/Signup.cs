using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace G13_Railway_Management_System
{
    public partial class Signup : Form
    {
        Login loginForm = null;
        string connectionString = null;
        public Signup(string connectionString, Login LoginForm)
        {
            InitializeComponent();
            this.loginForm = LoginForm;
            this.connectionString = connectionString;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text) && string.IsNullOrEmpty(textBoxSignupPassword.Text))
            {
                MessageBox.Show("Please enter email and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBoxSignupPassword.Text))
            {
                MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBoxcnic.Text))
            {
                MessageBox.Show("Please enter cnic!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PasswordScore passwordStrengthScore = PasswordAdvisor.CheckStrength(textBoxSignupPassword.Text);
            bool strongPassword = false;

            switch (passwordStrengthScore)
            {
                case PasswordScore.VeryWeak:
                    MessageBox.Show("Please enter a medium/strong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxSignupPassword.Clear();
                    return;
                //break;
                case PasswordScore.Weak:
                    MessageBox.Show("Please enter a medium/strong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxSignupPassword.Clear();
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

            if (strongPassword == true)
            {
                this.Hide();
                OTP otpForm = new OTP(this, loginForm, connectionString, textBoxFirstname.Text, textBoxLastname.Text, textBoxEmail.Text.ToLower(), textBoxSignupPassword.Text, textBoxPhonenumber.Text, textBoxcnic.Text, textBoxAddress.Text, getPhoto());
                otpForm.Show();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
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

        private void textBoxSignupPassword_TextChanged(object sender, EventArgs e)
        {
            string password = textBoxSignupPassword.Text;
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
    }
}

public enum PasswordScore
{
    Blank = 0,
    VeryWeak = 1,
    Weak = 2,
    Medium = 3,
    Strong = 4,
    VeryStrong = 5
}

public class PasswordAdvisor
{
    public static PasswordScore CheckStrength(string password)
    {
        int score = 0;

        if (password.Length < 1)
        {
            return PasswordScore.Blank;
        }
        if (password.Length < 4)
        {
            return PasswordScore.VeryWeak;
        }
        if (password.Length >= 8)
        {
            score++;
        }
        if (password.Length >= 12)
        {
            score++;
        }
        if (Regex.IsMatch(password, @"[a-z]"))
        {
            score++;
        }
        if (Regex.IsMatch(password, @"[A-Z]"))
        {
            score++;
        }
        if (Regex.IsMatch(password, @"\d"))
        {
            score++;
        }
        if (Regex.IsMatch(password, @"[^\w]"))
        {
            score++;
        }

        return (PasswordScore)score;
    }
}
