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

namespace G13_Railway_Management_System
{
    public partial class AdminManageTrainClass : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        public AdminManageTrainClass(string connectionString)
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
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string className = textBoxClassName.Text,
                        fareMultiplier = textBoxFareMultiplier.Text;
                    string query = "SELECT CLASSTYPE, FAREMULTIPLIER FROM TRAIN_CLASS\r\nWHERE CLASSID = CLASSID";
                    if (className.Length > 0)
                    {
                        query += " AND CLASSTYPE = :CLASSNAME";
                    }
                    if (fareMultiplier.Length > 0)
                    {
                        query += " AND FAREMULTIPLIER = :FAREMULTIPLIER";
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (className.Length > 0)
                        {
                            command.Parameters.Add("className", OracleDbType.Varchar2).Value = className;
                        }
                        if (fareMultiplier.Length > 0)
                        {
                            command.Parameters.Add("fareMultiplier", OracleDbType.Varchar2).Value = fareMultiplier;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewManageTrainClass.DataSource = dataTable;
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
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string className = textBoxClassName.Text,
                        fareMultiplier = textBoxFareMultiplier.Text;
                    string query = "INSERT INTO TRAIN_CLASS (CLASSTYPE, FAREMULTIPLIER) VALUES (:CLASSNAME, :FAREMULTIPLIER)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("className", OracleDbType.Varchar2).Value = className;
                        command.Parameters.Add("fareMultiplier", OracleDbType.Varchar2).Value = fareMultiplier;
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Added Successfully");
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string className = textBoxClassName.Text,
                        fareMultiplier = textBoxFareMultiplier.Text;
                    string query = "DELETE FROM TRAIN_CLASS\r\nWHERE CLASSTYPE = :CLASSNAME";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("className", OracleDbType.Varchar2).Value = className;
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("DELETED Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error NO DATA");
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

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string className = textBoxClassName.Text,
                        fareMultiplier = textBoxFareMultiplier.Text;
                    string query = "UPDATE TRAIN_CLASS\r\nSET CLASSTYPE = :CLASSNAME, FAREMULTIPLIER = :FAREMULTIPLIER\r\nWHERE CLASSTYPE = :CLASSNAME";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("className", OracleDbType.Varchar2).Value = className;
                        command.Parameters.Add("fareMultiplier", OracleDbType.Varchar2).Value = fareMultiplier;
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

        private void dataGridViewManageTrainClass_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxClassName.Text = dataGridViewManageTrainClass.CurrentRow.Cells[0].Value.ToString();
            textBoxFareMultiplier.Text = dataGridViewManageTrainClass.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridViewManageTrainClass_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxClassName.Text = dataGridViewManageTrainClass.CurrentRow.Cells[0].Value.ToString();
            textBoxFareMultiplier.Text = dataGridViewManageTrainClass.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
