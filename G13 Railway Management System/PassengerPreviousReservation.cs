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
    public partial class PassengerPreviousReservation : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString;
        string pID;
        public PassengerPreviousReservation(string connectionString, string pID)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.pID = pID;
            FillcomboBox();
            search();
        }

        public void FillcomboBox()
        {
            string query = "SELECT TICKETRESERVATIONID FROM TICKET_RESERVATION WHERE PASSENGERID = :pID ORDER BY TICKETRESERVATIONID";
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

                comboBoxTicketID.DataSource = dataList;
                conn.Close();
            }
            query = "SELECT DISTINCT CLASSTYPE FROM TRAIN_CLASS WHERE CLASSID = ANY (SELECT CLASSID FROM TICKET_RESERVATION WHERE PASSENGERID = :pID) ORDER BY CLASSTYPE";
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

                comboBoxClassType.DataSource = dataList;
                conn.Close();
            }
            query = "SELECT ROUTENAME FROM ROUTE WHERE ROUTEID = ANY (SELECT ROUTEID FROM TRAIN_SCHEDULE TS WHERE SCHEDULEID = ANY (SELECT SCHEDULEID FROM TICKET_RESERVATION WHERE PASSENGERID = :pID)) ORDER BY ROUTENAME";
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

                comboBoxRouteName.DataSource = dataList;
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
            query = "SELECT BOOKINGDATE FROM TICKET_RESERVATION WHERE PASSENGERID = :pID ORDER BY BOOKINGDATE";
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

                comboBoxBookingDate.DataSource = dataList;
                conn.Close();
            }
            query = "SELECT DEPARTUREDATE FROM TRAIN_SCHEDULE WHERE SCHEDULEID = ANY (SELECT SCHEDULEID FROM TICKET_RESERVATION WHERE PASSENGERID = :pID) ORDER BY DEPARTUREDATE";
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

                comboBoxDepartureDate.DataSource = dataList;
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
                    string ticketID = comboBoxTicketID.Text,
                        from = comboBoxFromStation.Text,
                        to = comboBoxToStation.Text,
                        route = comboBoxRouteName.Text,
                        bookingDate = comboBoxBookingDate.Text,
                        departureDate = comboBoxDepartureDate.Text,
                        type = comboBoxClassType.Text;
                    string query = "SELECT TICKETRESERVATIONID, GETFROMSTATION (R.ROUTEID) AS FROMSTATION, GETTOSTATION (R.ROUTEID) AS TOSTATION, CLASSTYPE, ROUTENAME, BOOKINGDATE, DEPARTUREDATE, RESERVATIONSTATUS, FARE, SOLDSTATUS FROM TICKET_RESERVATION TR\r\nINNER JOIN TRAIN_SCHEDULE TS ON TS.SCHEDULEID = TR.SCHEDULEID\r\nINNER JOIN ROUTE R ON R.ROUTEID = TS.ROUTEID\r\nINNER JOIN TRAIN_CLASS TC ON TC.CLASSID = TR.CLASSID\r\nWHERE PASSENGERID = :pID";
                    if (ticketID.Length > 0)
                    {
                        query += " AND TICKETRESERVATIONID = :TICKETID";
                    }
                    if (from.Length > 0)
                    {
                        query += " AND GETFROMSTATION (R.ROUTEID) = :fromStation";
                    }
                    if (to.Length > 0)
                    {
                        query += " AND GETTOSTATION (R.ROUTEID) = :toStation";
                    }
                    if (route.Length > 0)
                    {
                        query += " AND ROUTENAME = :routeName";
                    }
                    if (bookingDate.Length > 0)
                    {
                        query += " AND BOOKINGDATE = :bookingDate";
                    }
                    if (departureDate.Length > 0)
                    {
                        query += " AND DEPARTUREDATE = :departureDate";
                    }
                    if (type.Length > 0)
                    {
                        query += " AND CLASSTYPE = :type";
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("pID", OracleDbType.Varchar2).Value = pID;
                        if (ticketID.Length > 0)
                        {
                            command.Parameters.Add("ticketID", OracleDbType.Varchar2).Value = ticketID;
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
                        if (bookingDate.Length > 0)
                        {
                            command.Parameters.Add("bookingDate", OracleDbType.Date).Value = DateTime.Parse(bookingDate);
                        }
                        if (departureDate.Length > 0)
                        {
                            command.Parameters.Add("departureDate", OracleDbType.Date).Value = DateTime.Parse(departureDate);
                        }
                        if (type.Length > 0)
                        {
                            command.Parameters.Add("type", OracleDbType.Varchar2).Value = type;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewSeat.DataSource = dataTable;
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            string ticketID = comboBoxTicketID.Text;
            if (ticketID.Length == 0)
            {
                return;
            }
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM TICKET_RESERVATION TR WHERE TICKETRESERVATIONID = :ticketID AND CURRENT_DATE < (SELECT DEPARTUREDATE FROM TRAIN_SCHEDULE TS WHERE TS.SCHEDULEID = TR.SCHEDULEID)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("ticketID", OracleDbType.Varchar2).Value = ticketID;
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cancelled Successfully");
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

        private void dataGridViewSeat_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxTicketID.Text = dataGridViewSeat.CurrentRow.Cells[0].Value.ToString();
            comboBoxFromStation.Text = dataGridViewSeat.CurrentRow.Cells[1].Value.ToString();
            comboBoxToStation.Text = dataGridViewSeat.CurrentRow.Cells[2].Value.ToString();
            comboBoxClassType.Text = dataGridViewSeat.CurrentRow.Cells[3].Value.ToString();
            comboBoxRouteName.Text = dataGridViewSeat.CurrentRow.Cells[4].Value.ToString();
            comboBoxBookingDate.Text = dataGridViewSeat.CurrentRow.Cells[5].Value.ToString();
            comboBoxDepartureDate.Text = dataGridViewSeat.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridViewSeat_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBoxTicketID.Text = dataGridViewSeat.CurrentRow.Cells[0].Value.ToString();
            comboBoxFromStation.Text = dataGridViewSeat.CurrentRow.Cells[1].Value.ToString();
            comboBoxToStation.Text = dataGridViewSeat.CurrentRow.Cells[2].Value.ToString();
            comboBoxClassType.Text = dataGridViewSeat.CurrentRow.Cells[3].Value.ToString();
            comboBoxRouteName.Text = dataGridViewSeat.CurrentRow.Cells[4].Value.ToString();
            comboBoxBookingDate.Text = dataGridViewSeat.CurrentRow.Cells[5].Value.ToString();
            comboBoxDepartureDate.Text = dataGridViewSeat.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
