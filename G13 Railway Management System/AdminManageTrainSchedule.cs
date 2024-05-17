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
    public partial class AdminManageTrainSchedule : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        public AdminManageTrainSchedule(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            FillcomboBox();
            search();
        }

        public void FillcomboBox()
        {
            string query = "SELECT TRAINNAME FROM TRAIN ORDER BY TRAINNAME";
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

                comboBoxTrainName.DataSource = dataList;
                conn.Close();
            }
            query = "SELECT ROUTENAME FROM ROUTE ORDER BY ROUTENAME";
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
            query = "SELECT SCHEDULENAME FROM TRAIN_SCHEDULE ORDER BY SCHEDULENAME";
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

                comboBoxScheduleName.DataSource = dataList;
                conn.Close();
            }
        }
        private string getDateFormat(DateTime Dt)
        {
            string departureDate = "";
            if (Dt.Month.ToString().Length == 1)
            {
                departureDate += "0";
            }
            departureDate += Dt.Month.ToString() + "/";
            if (Dt.Day.ToString().Length == 1)
            {
                departureDate += "0";
            }
            departureDate += Dt.Day.ToString() + "/" + Dt.Year.ToString();
            return departureDate;
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
                    string trainName = comboBoxTrainName.Text,
                        routeName = comboBoxRouteName.Text,
                        scheduleName = comboBoxScheduleName.Text,
                        status = comboBoxScheduleStatus.Text,
                        departureDate = textBoxDepartureDate.Text,
                        baseFare = textBoxBaseFare.Text;
                    string query = "SELECT TRAINNAME, ROUTENAME, SCHEDULENAME, SCHEDULESTATUS, DEPARTUREDATE, BASEFARE FROM TRAIN_SCHEDULE TS\r\nINNER JOIN ROUTE R ON R.ROUTEID = TS.ROUTEID\r\nINNER JOIN TRAIN T ON T.TRAINID = TS.TRAINID\r\nWHERE SCHEDULEID = SCHEDULEID";
                    if (trainName.Length > 0)
                    {
                        query += " AND TRAINNAME = :TRAINNAME";
                    }
                    if (routeName.Length > 0)
                    {
                        query += " AND ROUTENAME = :ROUTENAME";
                    }
                    if (scheduleName.Length > 0)
                    {
                        query += " AND SCHEDULENAME = :SCHEDULENAME";
                    }
                    if (status.Length > 0)
                    {
                        query += " AND SCHEDULESTATUS = :STATUS";
                    }
                    if (departureDate.Length > 0)
                    {
                        query += " AND DEPARTUREDATE = :DEPARTUREDATE";
                    }
                    if (baseFare.Length > 0)
                    {
                        query += " AND BASEFARE = :BASEFARE";
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (trainName.Length > 0)
                        {
                            command.Parameters.Add("trainName", OracleDbType.Varchar2).Value = trainName;
                        }
                        if (routeName.Length > 0)
                        {
                            command.Parameters.Add("routeName", OracleDbType.Varchar2).Value = routeName;
                        }
                        if (scheduleName.Length > 0)
                        {
                            command.Parameters.Add("scheduleName", OracleDbType.Varchar2).Value = scheduleName;
                        }
                        if (status.Length > 0)
                        {
                            command.Parameters.Add("status", OracleDbType.Varchar2).Value = status;
                        }
                        if (departureDate.Length > 0)
                        {
                            command.Parameters.Add("departureDate", OracleDbType.Date).Value = DateTime.Parse(departureDate);
                        }
                        if (baseFare.Length > 0)
                        {
                            command.Parameters.Add("baseFare", OracleDbType.Int64).Value = baseFare;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewManageTrainSchedule.DataSource = dataTable;
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

        private void buttonAdminUpdate_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string trainName = comboBoxTrainName.Text,
                        routeName = comboBoxRouteName.Text,
                        scheduleName = comboBoxScheduleName.Text,
                        status = comboBoxScheduleStatus.Text,
                        departureDate = textBoxDepartureDate.Text,
                        baseFare = textBoxBaseFare.Text;
                    string query = "UPDATE TRAIN_SCHEDULE\r\nSET TRAINID = (SELECT TRAINID FROM TRAIN WHERE TRAINNAME = :TRAINNAME), ROUTEID = (SELECT ROUTEID FROM ROUTE WHERE ROUTENAME = :ROUTENAME), SCHEDULENAME = :SCHEDULENAME, SCHEDULESTATUS = :STATUS, DEPARTUREDATE = :DEPARTUREDATE, BASEFARE = :BASEFARE\r\nWHERE SCHEDULENAME = :SCHEDULENAME AND DEPARTUREDATE = :DEPARTUREDATE";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("trainName", OracleDbType.Varchar2).Value = trainName;
                        command.Parameters.Add("routeName", OracleDbType.Varchar2).Value = routeName; ;
                        command.Parameters.Add("scheduleName", OracleDbType.Varchar2).Value = scheduleName;
                        command.Parameters.Add("status", OracleDbType.Varchar2).Value = status;
                        command.Parameters.Add("departureDate", OracleDbType.Date).Value = DateTime.Parse(departureDate);
                        command.Parameters.Add("baseFare", OracleDbType.Int64).Value = baseFare;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string trainName = comboBoxTrainName.Text,
                        routeName = comboBoxRouteName.Text,
                        scheduleName = comboBoxScheduleName.Text,
                        status = comboBoxScheduleStatus.Text,
                        departureDate = textBoxDepartureDate.Text,
                        baseFare = textBoxBaseFare.Text;
                    string query = "INSERT INTO TRAIN_SCHEDULE (TRAINID, ROUTEID, SCHEDULENAME, SCHEDULESTATUS, DEPARTUREDATE, BASEFARE) VALUES ((SELECT TRAINID FROM TRAIN WHERE TRAINNAME = :TRAINNAME), (SELECT ROUTEID FROM ROUTE WHERE ROUTENAME = :ROUTENAME), :SCHEDULENAME, :STATUS, :DEPARTUREDATE, :BASEFARE)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("trainName", OracleDbType.Varchar2).Value = trainName;
                        command.Parameters.Add("routeName", OracleDbType.Varchar2).Value = routeName; ;
                        command.Parameters.Add("scheduleName", OracleDbType.Varchar2).Value = scheduleName;
                        command.Parameters.Add("status", OracleDbType.Varchar2).Value = status;
                        command.Parameters.Add("departureDate", OracleDbType.Date).Value = DateTime.Parse(departureDate);
                        command.Parameters.Add("baseFare", OracleDbType.Int64).Value = baseFare;
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string trainName = comboBoxTrainName.Text,
                        routeName = comboBoxRouteName.Text,
                        scheduleName = comboBoxScheduleName.Text,
                        status = comboBoxScheduleStatus.Text,
                        departureDate = textBoxDepartureDate.Text,
                        baseFare = textBoxBaseFare.Text;
                    string query = "DELETE FROM TRAIN_SCHEDULE \r\nWHERE SCHEDULENAME = :SCHEDULENAME AND DEPARTUREDATE = :DEPARTUREDATE";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("scheduleName", OracleDbType.Varchar2).Value = scheduleName;
                        command.Parameters.Add("departureDate", OracleDbType.Date).Value = DateTime.Parse(departureDate);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error No Data Found");
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

        private void dataGridViewManageTrainSchedule_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxTrainName.Text = dataGridViewManageTrainSchedule.CurrentRow.Cells[0].Value.ToString();
            comboBoxRouteName.Text = dataGridViewManageTrainSchedule.CurrentRow.Cells[1].Value.ToString();
            comboBoxScheduleName.Text = dataGridViewManageTrainSchedule.CurrentRow.Cells[2].Value.ToString();
            comboBoxScheduleStatus.Text = dataGridViewManageTrainSchedule.CurrentRow.Cells[3].Value.ToString();
            textBoxDepartureDate.Text = dataGridViewManageTrainSchedule.CurrentRow.Cells[4].Value.ToString();
            textBoxBaseFare.Text = dataGridViewManageTrainSchedule.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataGridViewManageTrainSchedule_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBoxTrainName.Text = dataGridViewManageTrainSchedule.CurrentRow.Cells[0].Value.ToString();
            comboBoxRouteName.Text = dataGridViewManageTrainSchedule.CurrentRow.Cells[1].Value.ToString();
            comboBoxScheduleName.Text = dataGridViewManageTrainSchedule.CurrentRow.Cells[2].Value.ToString();
            comboBoxScheduleStatus.Text = dataGridViewManageTrainSchedule.CurrentRow.Cells[3].Value.ToString();
            textBoxDepartureDate.Text = dataGridViewManageTrainSchedule.CurrentRow.Cells[4].Value.ToString();
            textBoxBaseFare.Text = dataGridViewManageTrainSchedule.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
