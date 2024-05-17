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
    public partial class AdminManageStation : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        public AdminManageStation(string connectionString)
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
                    string stationNo = textBoxStationNo.Text,
                        stationName = textBoxStationName.Text,
                        stationCity = textBoxStationCity.Text,
                        stationCountry = textBoxStationCountry.Text;
                    string query = "SELECT STATIONNO, STATIONNAME, CITY, COUNTRY FROM STATION\r\nWHERE STATIONID = STATIONID";
                    if (stationNo.Length > 0)
                    {
                        query += " AND STATIONNO = :STATIONNO";
                    }
                    if (stationName.Length > 0)
                    {
                        query += " AND STATIONNAME = :STATIONNAME";
                    }
                    if (stationCity.Length > 0)
                    {
                        query += " AND CITY = :CITY";
                    }
                    if (stationCountry.Length > 0)
                    {
                        query += " AND COUNTRY = :COUNTRY";
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (stationNo.Length > 0)
                        {
                            command.Parameters.Add("stationNo", OracleDbType.Int64).Value = stationNo;
                        }
                        if (stationName.Length > 0)
                        {
                            command.Parameters.Add("stationName", OracleDbType.Varchar2).Value = stationName;
                        }
                        if (stationCity.Length > 0)
                        {
                            command.Parameters.Add("stationCity", OracleDbType.Varchar2).Value = stationCity;
                        }
                        if (stationCountry.Length > 0)
                        {
                            command.Parameters.Add("stationCountry", OracleDbType.Varchar2).Value = stationCountry;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewManageStation.DataSource = dataTable;
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
                    string stationNo = textBoxStationNo.Text,
                        stationName = textBoxStationName.Text,
                        stationCity = textBoxStationCity.Text,
                        stationCountry = textBoxStationCountry.Text;
                    string query = "INSERT INTO STATION (STATIONNO, STATIONNAME, CITY, COUNTRY) VALUES (:STATIONNO, :STATIONNAME, :CITY, :COUNTRY)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("stationNo", OracleDbType.Int64).Value = stationNo;
                        command.Parameters.Add("stationName", OracleDbType.Varchar2).Value = stationName;
                        command.Parameters.Add("stationCity", OracleDbType.Varchar2).Value = stationCity;
                        command.Parameters.Add("stationCountry", OracleDbType.Varchar2).Value = stationCountry;
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string stationNo = textBoxStationNo.Text,
                        stationName = textBoxStationName.Text,
                        stationCity = textBoxStationCity.Text,
                        stationCountry = textBoxStationCountry.Text;
                    string query = "UPDATE STATION \r\nSET STATIONNO = :STATIONNO, STATIONNAME = :STATIONNAME, CITY = :CITY, COUNTRY = :COUNTRY\r\nWHERE STATIONNO = :STATIONNO OR STATIONNAME = :STATIONNAME";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("stationNo", OracleDbType.Int64).Value = stationNo;
                        command.Parameters.Add("stationName", OracleDbType.Varchar2).Value = stationName;
                        command.Parameters.Add("stationCity", OracleDbType.Varchar2).Value = stationCity;
                        command.Parameters.Add("stationCountry", OracleDbType.Varchar2).Value = stationCountry;
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string stationNo = textBoxStationNo.Text,
                        stationName = textBoxStationName.Text,
                        stationCity = textBoxStationCity.Text,
                        stationCountry = textBoxStationCountry.Text;
                    string query = "DELETE FROM STATION WHERE STATIONID = STATIONID";
                    bool chk = false;
                    if (stationNo.Length > 0)
                    {
                        query += " AND STATIONNO = :STATIONNO";
                        chk = true;
                    }
                    if (stationName.Length > 0)
                    {
                        query += " AND STATIONNAME = :STATIONNAME";
                        chk = true;
                    }
                    if(!chk)
                    {
                        connection.Close();
                        return;
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (stationNo.Length > 0)
                        {
                            command.Parameters.Add("stationNo", OracleDbType.Int64).Value = stationNo;
                        }
                        if (stationName.Length > 0)
                        {
                            command.Parameters.Add("stationName", OracleDbType.Varchar2).Value = stationName;
                        }
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error No Station Found");
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

        private void dataGridViewManageStation_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxStationNo.Text = dataGridViewManageStation.CurrentRow.Cells[0].Value.ToString();
            textBoxStationName.Text = dataGridViewManageStation.CurrentRow.Cells[1].Value.ToString();
            textBoxStationCity.Text = dataGridViewManageStation.CurrentRow.Cells[2].Value.ToString();
            textBoxStationCountry.Text = dataGridViewManageStation.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridViewManageStation_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxStationNo.Text = dataGridViewManageStation.CurrentRow.Cells[0].Value.ToString();
            textBoxStationName.Text = dataGridViewManageStation.CurrentRow.Cells[1].Value.ToString();
            textBoxStationCity.Text = dataGridViewManageStation.CurrentRow.Cells[2].Value.ToString();
            textBoxStationCountry.Text = dataGridViewManageStation.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
