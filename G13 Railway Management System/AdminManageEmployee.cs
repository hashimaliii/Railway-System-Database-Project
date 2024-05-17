using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace G13_Railway_Management_System
{
    public partial class AdminManageEmployee : UserControl
    {
        string connectionString = string.Empty;
        public AdminManageEmployee(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            search();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string fname = textBoxEmployeeFirstName.Text,
                        lname = textBoxEmployeeLastName.Text,
                        email = textBoxEmployeeEmail.Text,
                        phoneNo = textBoxEmployeePhoneNumber.Text,
                        cnic = textBoxEmployeeCNIC.Text,
                        address = textBoxEmployeeAddress.Text,
                        salary = textBoxEmployeeSalary.Text,
                        dateJoining = textBoxDateOfJoining.Text,
                        role = comboBoxEmployeeRole.Text,
                        password = textBoxPassword.Text;
                    string query = "SELECT FIRSTNAME, LASTNAME, EMAIL, PASSWORD, CNIC, ADDRESS, PHONENUMBER, ROLE, SALARY, JOININGDATE, PROFILEPICTURE FROM EMPLOYEE E INNER JOIN USERS U ON U.userid = E.userid ";
                    if (cnic.Length > 0)
                    {
                        query += " AND CNIC = :cnic ";
                    }
                    if (fname.Length > 0)
                    {
                        query += " AND FirstNAME = :fname ";
                    }
                    if (lname.Length > 0)
                    {
                        query += " AND LastNAME = :lname ";
                    }
                    if (email.Length > 0)
                    {
                        query += " AND email = :email ";
                    }
                    if (phoneNo.Length > 0)
                    {
                        query += " AND phoneNumber = :phoneNo ";
                    }
                    if (address.Length > 0)
                    {
                        query += " AND address = :address ";
                    }
                    if (salary.Length > 0)
                    {
                        query += " AND salary = :salary ";
                    }
                    if (dateJoining.Length > 0)
                    {
                        query += " AND joiningDate = :dateJoining ";
                    }
                    if (role.Length > 0)
                    {
                        query += " AND role = :role ";
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.BindByName = true;
                        if (cnic.Length > 0)
                        {
                            command.Parameters.Add("cnic", OracleDbType.Int64).Value = cnic;
                        }
                        if (fname.Length > 0)
                        {
                            command.Parameters.Add("fName", OracleDbType.Varchar2).Value = fname;
                        }
                        if (lname.Length > 0)
                        {
                            command.Parameters.Add("lName", OracleDbType.Varchar2).Value = lname;
                        }
                        if (email.Length > 0)
                        {
                            command.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
                        }
                        if (phoneNo.Length > 0)
                        {
                            command.Parameters.Add("phoneNo", OracleDbType.Int64).Value = phoneNo;
                        }
                        if (address.Length > 0)
                        {
                            command.Parameters.Add("address", OracleDbType.Varchar2).Value = address;
                        }
                        if (salary.Length > 0)
                        {
                            command.Parameters.Add("salary", OracleDbType.Int64).Value = salary;
                        }
                        if (dateJoining.Length > 0)
                        {
                            command.Parameters.Add("datejoining", OracleDbType.Date).Value = DateTime.Parse(dateJoining);
                        }
                        if (role.Length > 0)
                        {
                            command.Parameters.Add("role", OracleDbType.Varchar2).Value = role;
                        }

                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            oracleAdapter.Fill(dataTable);
                            dataGridViewEmployee.DataSource = dataTable;
                            dataGridViewEmployee.Columns["PASSWORD"].Visible = false;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string cnic = textBoxEmployeeCNIC.Text,
                        fname = textBoxEmployeeFirstName.Text,
                        lname = textBoxEmployeeLastName.Text,
                        email = textBoxEmployeeEmail.Text,
                        phoneNo = textBoxEmployeePhoneNumber.Text,
                        address = textBoxEmployeeAddress.Text,
                        salary = textBoxEmployeeSalary.Text,
                        dateJoining = textBoxDateOfJoining.Text,
                        role = comboBoxEmployeeRole.Text,
                        password = textBoxPassword.Text;
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "BEGIN \r\nINSERT INTO USERS (FIRSTNAME, LASTNAME, EMAIL, PHONENUMBER, CNIC, ADDRESS, PASSWORD, PROFILEPICTURE) VALUES (:fname, :lname, :email, :phoneNo, :cnic, :address, :password, :profilePicture);\r\nINSERT INTO EMPLOYEE (USERID, ROLE, SALARY, JOININGDATE) VALUES ((SELECT MAX (USERID) FROM USERS), :role, :salary, :datejoining);\r\nEND;";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("fName", OracleDbType.Varchar2).Value = fname;
                        command.Parameters.Add("lName", OracleDbType.Varchar2).Value = lname;
                        command.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
                        command.Parameters.Add("phoneNo", OracleDbType.Int64).Value = phoneNo;
                        command.Parameters.Add("cnic", OracleDbType.Int64).Value = cnic;
                        command.Parameters.Add("address", OracleDbType.Varchar2).Value = address;
                        command.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
                        command.Parameters.Add("profilePicture", OracleDbType.Blob).Value = getPhoto();
                        command.Parameters.Add("role", OracleDbType.Varchar2).Value = role;
                        command.Parameters.Add("salary", OracleDbType.Int64).Value = salary;
                        command.Parameters.Add("datejoining", OracleDbType.Date).Value = DateTime.Parse(dateJoining);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Added Successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string cnic = textBoxEmployeeCNIC.Text;
            if (cnic.Length == 0 ) 
            { 
                return;
            }

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "BEGIN \r\nDELETE FROM EMPLOYEE WHERE userID = (SELECT USERID FROM USERS WHERE CNIC = :CNIC);\r\nDELETE FROM USERS WHERE CNIC = :CNIC;\r\nEND;";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("CNIC", OracleDbType.Varchar2).Value = cnic;
                        int rowsAffectedUser = command.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
        }

        private void buttonAdminUpdate_Click(object sender, EventArgs e)
        {
            string fname = textBoxEmployeeFirstName.Text,
                lname = textBoxEmployeeLastName.Text,
                email = textBoxEmployeeEmail.Text,
                phoneNo = textBoxEmployeePhoneNumber.Text,
                cnic = textBoxEmployeeCNIC.Text,
                address = textBoxEmployeeAddress.Text,
                salary = textBoxEmployeeSalary.Text,
                dateJoining = textBoxDateOfJoining.Text,
                role = comboBoxEmployeeRole.Text,
                password = textBoxPassword.Text;
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    
                    string query = "BEGIN \r\nUPDATE EMPLOYEE SET ROLE = :role, SALARY = :salary, JOININGDATE = :datejoining WHERE USERID = (SELECT USERID FROM USERS WHERE CNIC = :CNIC);\r\nUPDATE USERS SET FIRSTNAME = :fname, LASTNAME = :lname, EMAIL = :email, PHONENUMBER = :phoneNo, CNIC = :CNIC, ADDRESS = :address, PASSWORD = :password, PROFILEPICTURE = :profilePicture WHERE CNIC = :CNIC;\r\nEND;";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("role", OracleDbType.Varchar2).Value = role;
                        command.Parameters.Add("salary", OracleDbType.Int64).Value = salary;
                        command.Parameters.Add("datejoining", OracleDbType.Date).Value = DateTime.Parse(dateJoining);
                        command.Parameters.Add("cnic", OracleDbType.Int64).Value = cnic;
                        command.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
                        command.Parameters.Add("fName", OracleDbType.Varchar2).Value = fname;
                        command.Parameters.Add("lName", OracleDbType.Varchar2).Value = lname;
                        command.Parameters.Add("phoneNo", OracleDbType.Int64).Value = phoneNo;
                        command.Parameters.Add("address", OracleDbType.Varchar2).Value = address;
                        command.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
                        command.Parameters.Add("profilePicture", OracleDbType.Blob).Value = getPhoto();

                        if (cnic.Length > 0 || email.Length > 0)
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error ");
                            return;
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

        private void dataGridViewEmployee_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxEmployeeFirstName.Text = dataGridViewEmployee.CurrentRow.Cells[0].Value.ToString();
            textBoxEmployeeLastName.Text = dataGridViewEmployee.CurrentRow.Cells[1].Value.ToString();
            textBoxEmployeeEmail.Text = dataGridViewEmployee.CurrentRow.Cells[2].Value.ToString();
            textBoxPassword.Text = dataGridViewEmployee.CurrentRow.Cells[3].Value.ToString();
            textBoxEmployeeCNIC.Text = dataGridViewEmployee.CurrentRow.Cells[4].Value.ToString();
            textBoxEmployeeAddress.Text = dataGridViewEmployee.CurrentRow.Cells[5].Value.ToString();
            textBoxEmployeePhoneNumber.Text = dataGridViewEmployee.CurrentRow.Cells[6].Value.ToString();
            comboBoxEmployeeRole.Text = dataGridViewEmployee.CurrentRow.Cells[7].Value.ToString();
            textBoxEmployeeSalary.Text = dataGridViewEmployee.CurrentRow.Cells[8].Value.ToString();
            textBoxDateOfJoining.Text = dataGridViewEmployee.CurrentRow.Cells[9].Value.ToString();

            if (!Convert.IsDBNull(dataGridViewEmployee.CurrentRow.Cells[10].Value))
            {
                pictureBoxProfilePicture.Image = blobToImage((byte[])dataGridViewEmployee.CurrentRow.Cells[10].Value);
            }
            else
            {
                pictureBoxProfilePicture.Image = Properties.Resources.user;
            }    
        }

        private void dataGridViewEmployee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxEmployeeFirstName.Text = dataGridViewEmployee.CurrentRow.Cells[0].Value.ToString();
            textBoxEmployeeLastName.Text = dataGridViewEmployee.CurrentRow.Cells[1].Value.ToString();
            textBoxEmployeeEmail.Text = dataGridViewEmployee.CurrentRow.Cells[2].Value.ToString();
            textBoxPassword.Text = dataGridViewEmployee.CurrentRow.Cells[3].Value.ToString();
            textBoxEmployeeCNIC.Text = dataGridViewEmployee.CurrentRow.Cells[4].Value.ToString();
            textBoxEmployeeAddress.Text = dataGridViewEmployee.CurrentRow.Cells[5].Value.ToString();
            textBoxEmployeePhoneNumber.Text = dataGridViewEmployee.CurrentRow.Cells[6].Value.ToString();
            comboBoxEmployeeRole.Text = dataGridViewEmployee.CurrentRow.Cells[7].Value.ToString();
            textBoxEmployeeSalary.Text = dataGridViewEmployee.CurrentRow.Cells[8].Value.ToString();
            textBoxDateOfJoining.Text = dataGridViewEmployee.CurrentRow.Cells[9].Value.ToString();

            if (!Convert.IsDBNull(dataGridViewEmployee.CurrentRow.Cells[10].Value))
            {
                pictureBoxProfilePicture.Image = blobToImage((byte[])dataGridViewEmployee.CurrentRow.Cells[10].Value);
            }
            else
            {
                pictureBoxProfilePicture.Image = Properties.Resources.user;
            }
        }
    }
}
