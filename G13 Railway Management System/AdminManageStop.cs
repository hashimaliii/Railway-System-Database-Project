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
    public partial class AdminManageStop : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        public AdminManageStop(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            FillcomboBox();
            search();
        }

        public void FillcomboBox()
        {
            string query = "SELECT STATIONNO FROM STATION";
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

                comboBoxStationNo.DataSource = dataList;
                conn.Close();
            }
            query = "SELECT ROUTENAME FROM ROUTE";
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

                comboBoxRouteName.DataSource = dataList;
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
                    string stationNo = comboBoxStationNo.Text,
                        routeName = comboBoxRouteName.Text,
                        arrivalTime = textBoxArrivalTime.Text,
                        departureTime = textBoxDepartureTime.Text;
                    string query = "SELECT ROUTENAME, STATIONNO, DEPARTURETIME, ARRIVALTIME FROM STOP S\r\nINNER JOIN ROUTE R ON R.ROUTEID = S.ROUTEID\r\nINNER JOIN STATION ST ON ST.STATIONID = S.STATIONID\r\nWHERE 1 = 1";
                    if (routeName.Length > 0)
                    {
                        query += " AND ROUTENAME = :ROUTENAME";
                    }
                    if (stationNo.Length > 0)
                    {
                        query += " AND STATIONNO = :STATIONNO";
                    }
                    if (arrivalTime.Length > 0)
                    {
                        query += " AND ARRIVALTIME = :ARRIVALTIME";
                    }
                    if (departureTime.Length > 0)
                    {
                        query += " AND DEPARTURETIME = :DEPARTURETIME";
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (routeName.Length > 0)
                        {
                            command.Parameters.Add("routeName", OracleDbType.Varchar2).Value = routeName;
                        }
                        if (stationNo.Length > 0)
                        {
                            command.Parameters.Add("stationNo", OracleDbType.Varchar2).Value = stationNo;
                        }
                        if (arrivalTime.Length > 0)
                        {
                            command.Parameters.Add("arrivalTime", OracleDbType.Varchar2).Value = arrivalTime;
                        }
                        if (departureTime.Length > 0)
                        {
                            command.Parameters.Add("departureTime", OracleDbType.Varchar2).Value = departureTime;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewManageStop.DataSource = dataTable;
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
                    string stationNo = comboBoxStationNo.Text,
                        routeName = comboBoxRouteName.Text,
                        arrivalTime = textBoxArrivalTime.Text,
                        departureTime = textBoxDepartureTime.Text;
                    string query = "INSERT INTO STOP (ROUTEID, STATIONID, ARRIVALTIME, DEPARTURETIME) VALUES ((SELECT ROUTEID FROM ROUTE WHERE ROUTENAME = :ROUTENAME), (SELECT STATIONID FROM STATION WHERE STATIONNO = :STATIONNO), :ARRIVALTIME, :DEPARTURETIME)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("routeName", OracleDbType.Varchar2).Value = routeName;
                        command.Parameters.Add("stationNo", OracleDbType.Varchar2).Value = stationNo;
                        command.Parameters.Add("arrivalTime", OracleDbType.Varchar2).Value = arrivalTime;
                        command.Parameters.Add("departureTime", OracleDbType.Varchar2).Value = departureTime;
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
            FillcomboBox();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string stationNo = comboBoxStationNo.Text,
                        routeName = comboBoxRouteName.Text,
                        arrivalTime = textBoxArrivalTime.Text,
                        departureTime = textBoxDepartureTime.Text;
                    string query = "UPDATE STOP \r\nSET ROUTEID = (SELECT ROUTEID FROM ROUTE WHERE ROUTENAME = :ROUTENAME), STATIONID = (SELECT STATIONID FROM STATION WHERE STATIONNO = :STATIONNO), ARRIVALTIME = :ARRIVALTIME, DEPARTURETIME = :DEPARTURETIME\r\nWHERE ROUTEID = (SELECT ROUTEID FROM ROUTE WHERE ROUTENAME = :ROUTENAME) AND STATIONID = (SELECT STATIONID FROM STATION WHERE STATIONNO = :STATIONNO)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("routeName", OracleDbType.Varchar2).Value = routeName;
                        command.Parameters.Add("stationNo", OracleDbType.Varchar2).Value = stationNo;
                        command.Parameters.Add("arrivalTime", OracleDbType.Varchar2).Value = arrivalTime;
                        command.Parameters.Add("departureTime", OracleDbType.Varchar2).Value = departureTime;
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
            FillcomboBox();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string stationNo = comboBoxStationNo.Text,
                        routeName = comboBoxRouteName.Text,
                        arrivalTime = textBoxArrivalTime.Text,
                        departureTime = textBoxDepartureTime.Text;
                    string query = "DELETE FROM STOP \r\nWHERE ROUTEID = (SELECT ROUTEID FROM ROUTE WHERE ROUTENAME = :ROUTENAME) AND STATIONID = (SELECT STATIONID FROM STATION WHERE STATIONNO = :STATIONNO)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("routeName", OracleDbType.Varchar2).Value = routeName;
                        command.Parameters.Add("stationNo", OracleDbType.Varchar2).Value = stationNo;
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
            FillcomboBox();
        }

        private void dataGridViewManageStop_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxRouteName.Text = dataGridViewManageStop.CurrentRow.Cells[0].Value.ToString();
            comboBoxStationNo.Text = dataGridViewManageStop.CurrentRow.Cells[1].Value.ToString();
            textBoxDepartureTime.Text = dataGridViewManageStop.CurrentRow.Cells[2].Value.ToString();
            textBoxArrivalTime.Text = dataGridViewManageStop.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridViewManageStop_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBoxRouteName.Text = dataGridViewManageStop.CurrentRow.Cells[0].Value.ToString();
            comboBoxStationNo.Text = dataGridViewManageStop.CurrentRow.Cells[1].Value.ToString();
            textBoxDepartureTime.Text = dataGridViewManageStop.CurrentRow.Cells[2].Value.ToString();
            textBoxArrivalTime.Text = dataGridViewManageStop.CurrentRow.Cells[3].Value.ToString();
        }
    }
}