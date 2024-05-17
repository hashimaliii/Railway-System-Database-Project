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
    public partial class AdminManageRoute : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        public AdminManageRoute(string connectionString)
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
            string routeName = textBoxRouteName.Text;
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ROUTENAME FROM ROUTE WHERE ROUTENAME = ROUTENAME";
                    if (routeName.Length > 0)
                    {
                        query += " AND ROUTENAME = :ROUTENAME";
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (routeName.Length > 0)
                        {
                            command.Parameters.Add("routeName", OracleDbType.Varchar2).Value = routeName;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewManageRoute.DataSource = dataTable;
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
            string routeName = textBoxRouteName.Text;
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO ROUTE (ROUTENAME) VALUES (:routeName)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("routeName", OracleDbType.Varchar2).Value = routeName;
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
            string routeName = textBoxRouteName.Text;
            if (routeName.Length == 0)
            {
                return;
            }
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM ROUTE WHERE ROUTENAME = :routeName";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("routeName", OracleDbType.Varchar2).Value = routeName;
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted Successfully");
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

        private void dataGridViewManageRoute_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxRouteName.Text = dataGridViewManageRoute.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridViewManageRoute_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxRouteName.Text = dataGridViewManageRoute.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
