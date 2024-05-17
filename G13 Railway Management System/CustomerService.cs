using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace G13_Railway_Management_System
{
    public partial class CustomerService : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        string eID;

        public CustomerService(string connectionString, string eID)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.eID = eID;
            FillcomboBox();
            if (eID == "admin")
            {
                buttonPost.Hide();
            }
            pending();
        }

        public void FillcomboBox()
        {
            string query = "SELECT ID FROM CUSTOMER_SERVICE WHERE RESPONSE IS NULL ORDER BY ID";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();

                List<string> dataList = new List<string>();
                dataList.Add(string.Empty);
                while (reader.Read())
                {
                    dataList.Add(reader[0].ToString());
                }

                comboBoxID.DataSource = dataList;
                conn.Close();
            }
            query = "SELECT SCHEDULEID FROM CUSTOMER_SERVICE WHERE RESPONSE IS NULL ORDER BY SCHEDULEID";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();

                List<string> dataList = new List<string>();
                dataList.Add(string.Empty);
                while (reader.Read())
                {
                    dataList.Add(reader[0].ToString());
                }

                comboBoxScheduleID.DataSource = dataList;
                conn.Close();
            }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string scheduleID = comboBoxScheduleID.Text,
                        ID = comboBoxID.Text,
                        type = comboBoxType.Text,
                        response = textBoxResponse.Text;
                    string query = "SELECT ID, SCHEDULEID, SUBMISSIONDATE, DESCRIPTION, RESPONSE, SERVICETYPE FROM CUSTOMER_SERVICE WHERE ID = ID";
                    if (ID.Length > 0)
                    {
                        query += " AND ID = :ID ";
                    }
                    if (scheduleID.Length > 0)
                    {
                        query += " AND SCHEDULEID = :scheduleID ";
                    }
                    if (response.Length > 0)
                    {
                        query += " AND RESPONSE = :response ";
                    }
                    if (type.Length > 0)
                    {
                        query += " AND SERVICETYPE = :typeService ";
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (ID.Length > 0)
                        {
                            command.Parameters.Add("ID", OracleDbType.Varchar2).Value = ID;
                        }
                        if (scheduleID.Length > 0)
                        {
                            command.Parameters.Add("scheduleID", OracleDbType.Varchar2).Value = scheduleID;
                        }
                        if (response.Length > 0)
                        {
                            command.Parameters.Add("response", OracleDbType.Varchar2).Value = response;
                        }
                        if (type.Length > 0)
                        {
                            command.Parameters.Add("typeService", OracleDbType.Varchar2).Value = type;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewCustomerService.DataSource = dataTable;
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

        private void buttonPost_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string ID = comboBoxID.Text,
                        type = comboBoxType.Text,
                        response = textBoxResponse.Text;
                    string query = "UPDATE CUSTOMER_SERVICE SET RESPONSE = :response, EMPLOYEEID = :eID WHERE ID = :ID";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.BindByName = true;
                        command.Parameters.Add("response", OracleDbType.Varchar2).Value = response;
                        command.Parameters.Add("eID", OracleDbType.Varchar2).Value = eID;
                        command.Parameters.Add("ID", OracleDbType.Varchar2).Value = ID;
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Updated");
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
            FillcomboBox();
        }

        private void buttonPending_Click(object sender, EventArgs e)
        {
            pending();
        }

        private void pending()
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string scheduleID = comboBoxScheduleID.Text,
                        ID = comboBoxID.Text,
                        type = comboBoxType.Text,
                        response = textBoxResponse.Text;
                    string query = "SELECT ID, SCHEDULEID, SUBMISSIONDATE, DESCRIPTION, RESPONSE, SERVICETYPE FROM CUSTOMER_SERVICE WHERE ID = ID AND RESPONSE IS NULL";
                    if (ID.Length > 0)
                    {
                        query += " AND ID = :ID ";
                    }
                    if (scheduleID.Length > 0)
                    {
                        query += " AND SCHEDULEID = :scheduleID ";
                    }
                    if (type.Length > 0)
                    {
                        query += " AND SERVICETYPE = :typeService ";
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (ID.Length > 0)
                        {
                            command.Parameters.Add("ID", OracleDbType.Varchar2).Value = ID;
                        }
                        if (scheduleID.Length > 0)
                        {
                            command.Parameters.Add("scheduleID", OracleDbType.Varchar2).Value = scheduleID;
                        }
                        if (type.Length > 0)
                        {
                            command.Parameters.Add("typeService", OracleDbType.Varchar2).Value = type;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewCustomerService.DataSource = dataTable;
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

        private void dataGridViewCustomerService_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxID.Text = dataGridViewCustomerService.CurrentRow.Cells[0].Value.ToString();
            comboBoxScheduleID.Text = dataGridViewCustomerService.CurrentRow.Cells[1].Value.ToString();
            textBoxResponse.Text = dataGridViewCustomerService.CurrentRow.Cells[4].Value.ToString();
            comboBoxType.Text = dataGridViewCustomerService.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataGridViewCustomerService_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBoxID.Text = dataGridViewCustomerService.CurrentRow.Cells[0].Value.ToString();
            comboBoxScheduleID.Text = dataGridViewCustomerService.CurrentRow.Cells[1].Value.ToString();
            textBoxResponse.Text = dataGridViewCustomerService.CurrentRow.Cells[4].Value.ToString();
            comboBoxType.Text = dataGridViewCustomerService.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
