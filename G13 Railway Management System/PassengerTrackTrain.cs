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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace G13_Railway_Management_System
{
    public partial class PassengerTrackTrain : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        string pID = string.Empty;
        public PassengerTrackTrain(string connectionString, string pID)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.pID = pID;
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
            query = "SELECT DISTINCT SCHEDULESTATUS FROM TRAIN_SCHEDULE ORDER BY SCHEDULESTATUS";
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

                comboBoxTrainStatus.DataSource = dataList;
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

                comboBoxRoute.DataSource = dataList;
                conn.Close();
            }
            query = "SELECT STATIONNAME FROM STATION ORDER BY STATIONNAME";
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

                comboBoxFromStation.DataSource = dataList;
                conn.Close();
            }
            query = "SELECT STATIONNAME FROM STATION ORDER BY STATIONNAME";
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

                comboBoxToStation.DataSource = dataList;
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
                    string trainName = comboBoxTrainName.Text,
                        status = comboBoxTrainStatus.Text,
                        from = comboBoxFromStation.Text,
                        to = comboBoxToStation.Text,
                        route = comboBoxRoute.Text;
                    string query = "SELECT (SELECT TRAINNAME FROM TRAIN T WHERE T.TRAINID = TS.TRAINID) AS TRAINNAME, (SELECT ROUTENAME FROM ROUTE R WHERE R.ROUTEID = TS.ROUTEID) AS ROUTENAME, SCHEDULESTATUS, DEPARTUREDATE, GETFROMSTATION (ROUTEID) AS FROMSTATION, GETTOSTATION (ROUTEID) AS TOSTATION, (SELECT TRAINPICTURE FROM TRAIN T WHERE T.TRAINID = TS.TRAINID) AS TRAINPICTURE FROM TRAIN_SCHEDULE TS\r\nWHERE 1 = 1";
                    if (trainName.Length > 0)
                    {
                        query += " AND TRAINID = (SELECT TRAINID FROM TRAIN WHERE TRAINNAME = :trainName)";
                    }
                    if (status.Length > 0)
                    {
                        query += " AND SCHEDULESTATUS = :status ";
                    }
                    if (from.Length > 0)
                    {
                        query += " AND GETFROMSTATION (ROUTEID) = :fromStation";
                    }
                    if (to.Length > 0)
                    {
                        query += " AND GETTOSTATION (ROUTEID) = :toStation";
                    }
                    if (route.Length > 0)
                    {
                        query += " AND ROUTEID = (SELECT ROUTEID FROM ROUTE WHERE ROUTENAME = :routeName)";
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (trainName.Length > 0)
                        {
                            command.Parameters.Add("trainName", OracleDbType.Varchar2).Value = trainName;
                        }
                        if (status.Length > 0)
                        {
                            command.Parameters.Add("status", OracleDbType.Varchar2).Value = status;
                        }
                        if (from.Length > 0)
                        {
                            command.Parameters.Add("fromStation", OracleDbType.Varchar2).Value = from;
                        }
                        if (to.Length > 0)
                        {
                            command.Parameters.Add("toStation", OracleDbType.Varchar2).Value = to;
                        }
                        if (route.Length > 0)
                        {
                            command.Parameters.Add("routeName", OracleDbType.Varchar2).Value = route;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewTrainSchedule.DataSource = dataTable;
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

        private Image blobToImage(byte[] byteImage)
        {
            return new Bitmap(new MemoryStream(byteImage));
        }

        private void dataGridViewTrainSchedule_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxTrainName.Text = dataGridViewTrainSchedule.CurrentRow.Cells[0].Value.ToString();
            comboBoxRoute.Text = dataGridViewTrainSchedule.CurrentRow.Cells[1].Value.ToString();
            comboBoxTrainStatus.Text = dataGridViewTrainSchedule.CurrentRow.Cells[2].Value.ToString();
            comboBoxFromStation.Text = dataGridViewTrainSchedule.CurrentRow.Cells[4].Value.ToString();
            comboBoxToStation.Text = dataGridViewTrainSchedule.CurrentRow.Cells[5].Value.ToString();
            if (!Convert.IsDBNull(dataGridViewTrainSchedule.CurrentRow.Cells[6].Value))
            {
                pictureBoxTrainPicture.Image = blobToImage((byte[])dataGridViewTrainSchedule.CurrentRow.Cells[6].Value);
            }
            else
            {
                pictureBoxTrainPicture.Image = Properties.Resources.train;
            }
        }

        private void dataGridViewTrainSchedule_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBoxTrainName.Text = dataGridViewTrainSchedule.CurrentRow.Cells[0].Value.ToString();
            comboBoxRoute.Text = dataGridViewTrainSchedule.CurrentRow.Cells[1].Value.ToString();
            comboBoxTrainStatus.Text = dataGridViewTrainSchedule.CurrentRow.Cells[2].Value.ToString();
            comboBoxFromStation.Text = dataGridViewTrainSchedule.CurrentRow.Cells[4].Value.ToString();
            comboBoxToStation.Text = dataGridViewTrainSchedule.CurrentRow.Cells[5].Value.ToString();
            if (!Convert.IsDBNull(dataGridViewTrainSchedule.CurrentRow.Cells[6].Value))
            {
                pictureBoxTrainPicture.Image = blobToImage((byte[])dataGridViewTrainSchedule.CurrentRow.Cells[6].Value);
            }
            else
            {
                pictureBoxTrainPicture.Image = Properties.Resources.train;
            }
        }
    }
}
