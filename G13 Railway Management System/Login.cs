using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace G13_Railway_Management_System
{
    public partial class Login : Form
    {
        string connectionString = null;
        public Login(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoginSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signupForm = new Signup(connectionString, this);
            signupForm.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLoginUserName.Text) && string.IsNullOrEmpty(textBoxLoginPassword.Text))
            {
                MessageBox.Show("Please enter email and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBoxLoginUserName.Text))
            {
                MessageBox.Show("Please enter email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBoxLoginPassword.Text))
            {
                MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT E.role, U.firstName, P.passengerID, E.employeeID, A.adminID FROM USERS U FULL OUTER JOIN EMPLOYEE E ON E.userID = U.userID FULL OUTER JOIN ADMIN A ON A.userID = U.userID FULL OUTER JOIN PASSENGER P ON P.userID = U.userID WHERE U.email = :email AND U.password = :password";
                    string role = null, pID = null, eID = null, aID = null, firstName = null;
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("email", OracleDbType.Varchar2).Value = textBoxLoginUserName.Text.ToLower();
                        command.Parameters.Add("password", OracleDbType.Varchar2).Value = textBoxLoginPassword.Text;
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                role = reader["role"].ToString();
                                firstName = reader["firstName"].ToString();
                                pID = reader["passengerID"].ToString();
                                eID = reader["employeeID"].ToString();
                                aID = reader["adminID"].ToString();
                                this.Hide();
                                if (aID.Length != 0)
                                {
                                    Admin adminForm = new Admin(connectionString, this, aID, firstName);
                                    adminForm.Show();
                                }
                                else if (pID.Length != 0)
                                {
                                    Passenger passengerForm = new Passenger(connectionString, this, pID, firstName);
                                    passengerForm.Show();
                                }
                                else if (role == "Customer Support")
                                {
                                    CustomerSupport customerSupportForm = new CustomerSupport(connectionString, this, eID, firstName);
                                    customerSupportForm.Show();
                                }
                                else if (role == "Cashier")
                                {
                                    Cashier cashierForm = new Cashier(connectionString, this, eID, firstName);
                                    cashierForm.Show();
                                }
                                else if (role == "Driver")
                                {
                                    Driver driverForm = new Driver(connectionString, this, eID, firstName);
                                    driverForm.Show();
                                }
                                else
                                {
                                    //this.Close();
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
            // Here login will end
        }
    }
}
