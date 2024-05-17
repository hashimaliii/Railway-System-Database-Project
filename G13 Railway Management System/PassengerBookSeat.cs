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
    public partial class PassengerBookSeat : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString;
        string pID;
        Panel panelPassenger;
        public PassengerBookSeat(string connectionString, string pID, Panel panelPassenger)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.pID = pID;
            FillcomboBox();
            this.panelPassenger = panelPassenger;
            search();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelPassenger.Controls.Clear();
            panelPassenger.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public void FillcomboBox()
        {
            string query = "SELECT DISTINCT GETARRIVALTIME (ROUTEID) AS ARRIVALTIME FROM TRAIN_SCHEDULE ORDER BY GETARRIVALTIME (ROUTEID)";
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

                comboBoxArrivalTime.DataSource = dataList;
                conn.Close();
            }
            query = "SELECT DISTINCT GETDEPARTURETIME (ROUTEID) AS ARRIVALTIME FROM TRAIN_SCHEDULE ORDER BY GETDEPARTURETIME (ROUTEID)";
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

                comboBoxDepatureTime.DataSource = dataList;
                conn.Close();
            }
            //query = "SELECT CLASSTYPE FROM TRAIN_CLASS";
            //using (OracleConnection conn = new OracleConnection(connectionString))
            //{
            //    OracleCommand cmd = new OracleCommand(query, conn);
            //    conn.Open();

            //    OracleDataReader reader = cmd.ExecuteReader();

            //    List<string> dataList = new List<string>();
            //    dataList.Add(string.Empty);
            //    while (reader.Read())
            //    {
            //        dataList.Add(reader[0].ToString());
            //    }

            //    comboBoxClassType.DataSource = dataList;
            //    conn.Close();
            //}
            //query = "SELECT DISTINCT ROUTENAME FROM ROUTE WHERE ROUTEID = ANY (SELECT ROUTEID FROM TRAIN_SCHEDULE TS WHERE DEPARTUREDATE >= CURRENT_DATE) ORDER BY ROUTENAME";
            //using (OracleConnection conn = new OracleConnection(connectionString))
            //{
            //    OracleCommand cmd = new OracleCommand(query, conn);
            //    conn.Open();

            //    OracleDataReader reader = cmd.ExecuteReader();

            //    List<string> dataList = new List<string>();
            //    dataList.Add(string.Empty);
            //    while (reader.Read())
            //    {
            //        dataList.Add(reader[0].ToString());
            //    }

            //    comboBoxRoute.DataSource = dataList;
            //    conn.Close();
            //}
            query = "SELECT DISTINCT GETFROMSTATION (ROUTEID) AS FROMSTATION FROM TRAIN_SCHEDULE WHERE DEPARTUREDATE >= CURRENT_DATE ORDER BY GETFROMSTATION (ROUTEID)";
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

                comboBoxDepartureStation.DataSource = dataList;
                conn.Close();
            }
            query = "SELECT DISTINCT GETTOSTATION (ROUTEID) AS FROMSTATION FROM TRAIN_SCHEDULE WHERE DEPARTUREDATE >= CURRENT_DATE ORDER BY GETTOSTATION (ROUTEID)";
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

                comboBoxArrivalStations.DataSource = dataList;
                conn.Close();
            }
            query = "SELECT DISTINCT DEPARTUREDATE FROM TRAIN_SCHEDULE WHERE DEPARTUREDATE >= CURRENT_DATE ORDER BY DEPARTUREDATE";
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

                comboBoxDepartureDate.DataSource = dataList;
                conn.Close();
            }
            query = "SELECT DISTINCT SCHEDULESTATUS FROM TRAIN_SCHEDULE WHERE DEPARTUREDATE >= CURRENT_DATE ORDER BY SCHEDULESTATUS";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                conn.Open();
                cmd.Parameters.Add("pID", OracleDbType.Varchar2).Value = pID;

                OracleDataReader reader = cmd.ExecuteReader();

                List<string> dataList = new List<string>();
                dataList.Add(string.Empty);
                while (reader.Read())
                {
                    dataList.Add(reader[0].ToString());
                }

                comboBoxScheduleStatus.DataSource = dataList;
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
                    string departureTime = comboBoxDepatureTime.Text,
                        arrivalTime = comboBoxArrivalTime.Text,
                        departureStation = comboBoxDepartureStation.Text,
                        arrivalStation = comboBoxArrivalStations.Text,
                        departureDate = comboBoxDepartureDate.Text,
                        scheduleStatus = comboBoxScheduleStatus.Text;
                    string query = "SELECT SCHEDULEID, TRAINID, (SELECT TRAINNAME FROM TRAIN T WHERE T.TRAINID = TS.trainID) AS TRAINNAME, (SELECT COUNT (*) FROM SEAT S WHERE S.TRAINID = TS.TRAINID) - (SELECT COUNT (*) FROM SEAT S INNER JOIN TICKET_RESERVATION TR ON S.SEATID = TR.SEATID AND S.TRAINID = TR.TRAINID AND S.CLASSID = TR.CLASSID WHERE TR.SCHEDULEID = TS.SCHEDULEID AND S.TRAINID = TS.TRAINID) AS TOTALSEATS, GETFROMSTATION (ROUTEID) AS FROMSTATION, GETDEPARTURETIME (ROUTEID) AS DEPARTURETIME, GETTOSTATION (ROUTEID) AS TOSTATION, GETARRIVALTIME (ROUTEID) AS ARRIVALTIME, SCHEDULESTATUS, DEPARTUREDATE, BASEFARE FROM TRAIN_SCHEDULE TS WHERE 1 = 1";
                    if (departureTime.Length > 0)
                    {
                        query += " AND GETDEPARTURETIME (ROUTEID) = :departureTime";
                    }
                    if (arrivalTime.Length > 0)
                    {
                        query += " AND GETARRIVALTIME (ROUTEID) = :arrivalTime";
                    }
                    if (departureStation.Length > 0)
                    {
                        query += " AND GETFROMSTATION (ROUTEID) = :departureStation";
                    }
                    if (arrivalStation.Length > 0)
                    {
                        query += " AND GETTOSTATION (ROUTEID) = :arrivalStation";
                    }
                    if (departureDate.Length > 0)
                    {
                        query += " AND DEPARTUREDATE = :departureDate";
                    }
                    if (scheduleStatus.Length > 0)
                    {
                        query += " AND SCHEDULESTATUS = :scheduleStatus";
                    }
                    //if (classType.Length > 0)
                    //{
                    //    query += " AND :className = ANY (SELECT CLASSTYPE FROM TRAIN_CLASS TC WHERE TC.CLASSID = ANY (SELECT CLASSID FROM SEAT S WHERE S.TRAINID = TS.TRAINID))";
                    //}
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (departureTime.Length > 0)
                        {
                            command.Parameters.Add("departureTime", OracleDbType.Varchar2).Value = departureTime;
                        }
                        if (arrivalTime.Length > 0)
                        {
                            command.Parameters.Add("arrivalTime", OracleDbType.Varchar2).Value = arrivalTime;
                        }
                        if (departureStation.Length > 0)
                        {
                            command.Parameters.Add("departureStation", OracleDbType.Varchar2).Value = departureStation;
                        }
                        if (arrivalStation.Length > 0)
                        {
                            command.Parameters.Add("arrivalStation", OracleDbType.Varchar2).Value = arrivalStation;
                        }
                        if (departureDate.Length > 0)
                        {
                            command.Parameters.Add("departureDate", OracleDbType.Date).Value = DateTime.Parse(departureDate);
                        }
                        if (scheduleStatus.Length > 0)
                        {
                            command.Parameters.Add("scheduleStatus", OracleDbType.Varchar2).Value = scheduleStatus;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewSeat.DataSource = dataTable;
                            dataGridViewSeat.Columns["SCHEDULEID"].Visible = false;
                            dataGridViewSeat.Columns["TRAINID"].Visible = false;
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

        private void dataGridViewSeat_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sID = dataGridViewSeat.CurrentRow.Cells[0].Value.ToString(); 
            string tID = dataGridViewSeat.CurrentRow.Cells[1].Value.ToString();

            PassengerReserveTicket passengerReserveseTicket = new PassengerReserveTicket(panelPassenger, this, connectionString, sID, tID, pID);
            AddUserControl(passengerReserveseTicket);
        }

        private void dataGridViewSeat_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sID = dataGridViewSeat.CurrentRow.Cells[0].Value.ToString();
            string tID = dataGridViewSeat.CurrentRow.Cells[1].Value.ToString();

            PassengerReserveTicket passengerReserveseTicket = new PassengerReserveTicket(panelPassenger, this, connectionString, sID, tID, pID);
            AddUserControl(passengerReserveseTicket);
        }
    }
}
