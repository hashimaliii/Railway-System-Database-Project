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
    public partial class PassengerCustomerSupport : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString;
        string pID;
        public PassengerCustomerSupport(string connectionString, string pID)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.pID = pID;
            FillcomboBox();
            search();
        }

        public void FillcomboBox()
        {
            string query = "SELECT DISTINCT SCHEDULEID FROM TICKET_RESERVATION WHERE PASSENGERID = :pID";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                conn.Open();
                cmd.Parameters.Add("pID", OracleDbType.Int64).Value = pID;

                OracleDataReader reader = cmd.ExecuteReader();

                List<string> dataList = new List<string>();
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
            search();
        }

        private void search()
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string type = comboBoxType.Text,
                        scheduleID = comboBoxScheduleID.Text,
                        description = textBoxTaskDescription.Text;
                    string query = "SELECT SCHEDULEID, SUBMISSIONDATE, DESCRIPTION, RESPONSE, SERVICETYPE FROM CUSTOMER_SERVICE WHERE PASSENGERID = :pID ";
                    if (scheduleID.Length > 0)
                    {
                        query += " AND SCHEDULEID = :scheduleID";
                    }
                    if (type.Length > 0)
                    {
                        query += " AND SERVICETYPE = :type";
                    }
                    if (description.Length > 0)
                    {
                        query += " AND SERVICETYPE = :description";
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("pID", OracleDbType.Varchar2).Value = pID;
                        if (scheduleID.Length > 0)
                        {
                            command.Parameters.Add("scheduleID", OracleDbType.Varchar2).Value = scheduleID;
                        }
                        if (type.Length > 0)
                        {
                            command.Parameters.Add("type", OracleDbType.Varchar2).Value = type;
                        }
                        if (description.Length > 0)
                        {
                            command.Parameters.Add("description", OracleDbType.Varchar2).Value = description;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewFeedback.DataSource = dataTable;
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
            string type = comboBoxType.Text,
                scheduleID = comboBoxScheduleID.Text,
                description = textBoxTaskDescription.Text;
            if(type.Length == 0 || description.Length == 0 || scheduleID.Length == 0)
            {
                return;
            }
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO CUSTOMER_SERVICE (PASSENGERID, TRAINID, SCHEDULEID, SUBMISSIONDATE, DESCRIPTION, SERVICETYPE) VALUES (:pID, (SELECT TRAINID FROM TRAIN_SCHEDULE WHERE SCHEDULEID = :sID), :sID, CURRENT_DATE, :description, :type)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.BindByName = true;
                        command.Parameters.Add("pID", OracleDbType.Varchar2).Value = pID;
                        command.Parameters.Add("sID", OracleDbType.Varchar2).Value = scheduleID;
                        command.Parameters.Add("description", OracleDbType.Varchar2).Value = description;
                        command.Parameters.Add("type", OracleDbType.Varchar2).Value = type;
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Posted");
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

        private void dataGridViewFeedback_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxScheduleID.Text = dataGridViewFeedback.CurrentRow.Cells[0].Value.ToString();
            textBoxTaskDescription.Text = dataGridViewFeedback.CurrentRow.Cells[2].Value.ToString();
            comboBoxType.Text = dataGridViewFeedback.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridViewFeedback_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBoxScheduleID.Text = dataGridViewFeedback.CurrentRow.Cells[0].Value.ToString();
            textBoxTaskDescription.Text = dataGridViewFeedback.CurrentRow.Cells[2].Value.ToString();
            comboBoxType.Text = dataGridViewFeedback.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
