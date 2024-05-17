using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace G13_Railway_Management_System
{
    public partial class CashierTicket : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        string eID;
        public CashierTicket(string connectionString, string eID)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.eID = eID;
            FillcomboBox();
            search();
        }

        public void FillcomboBox()
        {
            string query = "SELECT TICKETRESERVATIONID FROM TICKET_RESERVATION TR WHERE CURRENT_DATE < (SELECT DEPARTUREDATE FROM TRAIN_SCHEDULE TS WHERE TS.SCHEDULEID = TR.SCHEDULEID) ORDER BY TICKETRESERVATIONID";
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

                comboBoxTicketID.DataSource = dataList;
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
                        soldStatus = comboBoxSoldStatus.Text;
                    string query = "SELECT TICKETRESERVATIONID, GETFROMSTATION (R.ROUTEID) AS FROMSTATION, GETTOSTATION (R.ROUTEID) AS TOSTATION, CLASSTYPE, ROUTENAME, BOOKINGDATE, DEPARTUREDATE, RESERVATIONSTATUS, FARE, SOLDSTATUS FROM TICKET_RESERVATION TR INNER JOIN TRAIN_SCHEDULE TS ON TS.SCHEDULEID = TR.SCHEDULEID INNER JOIN ROUTE R ON R.ROUTEID = TS.ROUTEID INNER JOIN TRAIN_CLASS TC ON TC.CLASSID = TR.CLASSID WHERE 1 = 1 ";
                    if (ticketID.Length > 0)
                    {
                        query += " AND TICKETRESERVATIONID = :ticketID";
                    }
                    if (soldStatus.Length > 0)
                    {
                        query += " AND SOLDSTATUS = :soldStatus";
                    }
                    query += " ORDER BY TICKETRESERVATIONID";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (ticketID.Length > 0)
                        {
                            command.Parameters.Add("ticketID", OracleDbType.Int64).Value = ticketID;
                        }
                        if (soldStatus.Length > 0)
                        {
                            command.Parameters.Add("soldStatus", OracleDbType.Varchar2).Value = soldStatus;
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

        private void buttonAdminUpdate_Click(object sender, EventArgs e)
        {
            bool check = false;
            string ticketID = comboBoxTicketID.Text,
                soldStatus = comboBoxSoldStatus.Text;
            if(ticketID.Length == 0 || soldStatus.Length == 0 )
            { 
                return;
            }
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE TICKET_RESERVATION SET SOLDSTATUS = :soldStatus WHERE TICKETRESERVATIONID = :ticketID";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("soldStatus", OracleDbType.Varchar2).Value = soldStatus;
                        command.Parameters.Add("ticketID", OracleDbType.Int64).Value = ticketID;
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            check = true;
                            MessageBox.Show("Ticket Updated");
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
            if (check == true)
            {
                string passengerEmail = string.Empty,
                    ticketNo = string.Empty,
                    fromStation = string.Empty,
                    toStation = string.Empty,
                    classType = string.Empty,
                    routeName = string.Empty,
                    bookingDate = string.Empty,
                    departureDate = string.Empty,
                    reservationStatus = string.Empty,
                    fare = string.Empty;
                string query = "SELECT TICKETRESERVATIONID, (SELECT EMAIL FROM USERS U INNER JOIN PASSENGER P ON U.USERID = P.USERID WHERE P.PASSENGERID = TR.PASSENGERID ) AS EMAIL, GETFROMSTATION (R.ROUTEID) AS FROMSTATION, GETTOSTATION (R.ROUTEID) AS TOSTATION, CLASSTYPE, ROUTENAME, BOOKINGDATE, DEPARTUREDATE, RESERVATIONSTATUS, FARE, SOLDSTATUS FROM TICKET_RESERVATION TR INNER JOIN TRAIN_SCHEDULE TS ON TS.SCHEDULEID = TR.SCHEDULEID INNER JOIN ROUTE R ON R.ROUTEID = TS.ROUTEID INNER JOIN TRAIN_CLASS TC ON TC.CLASSID = TR.CLASSID WHERE TR.TICKETRESERVATIONID = :ticketID";
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand(query, conn);
                        cmd.Parameters.Add("tID", OracleDbType.Varchar2).Value = ticketID;
                        OracleDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            if (soldStatus == "Sold")
                            {
                                passengerEmail = reader["EMAIL"].ToString();
                                ticketNo = reader["TICKETRESERVATIONID"].ToString();
                                fromStation = reader["FROMSTATION"].ToString();
                                toStation = reader["TOSTATION"].ToString();
                                classType = reader["CLASSTYPE"].ToString();
                                routeName = reader["ROUTENAME"].ToString();
                                bookingDate = reader["BOOKINGDATE"].ToString();
                                departureDate = reader["DEPARTUREDATE"].ToString();
                                reservationStatus = reader["RESERVATIONSTATUS"].ToString();
                                fare = reader["FARE"].ToString();
                                soldStatus = reader["SOLDSTATUS"].ToString();

                                sendEmail("G13 Railway Ticket Reservation", @"Ticket No. " + ticketNo +
                                    " \nDeparture Station: " + fromStation +
                                    " \nArrival/To Station: " + toStation +
                                    " \nClass Type: " + classType +
                                    " \nRoute Name: " + routeName +
                                    " \nBooking Date: " + bookingDate +
                                    " \nDeparture Date: " + departureDate +
                                    " \nReservation Status: " + reservationStatus +
                                    " \nFare: " + fare +
                                    " \nSold Status: " + soldStatus +
                                    " \nYour Ticket Payment Received", passengerEmail);
                            }
                            else if (soldStatus == "Not Sold")
                            {
                                passengerEmail = reader["EMAIL"].ToString();
                                ticketNo = reader["TICKETRESERVATIONID"].ToString();
                                fromStation = reader["FROMSTATION"].ToString();
                                toStation = reader["TOSTATION"].ToString();
                                classType = reader["CLASSTYPE"].ToString();
                                routeName = reader["ROUTENAME"].ToString();
                                bookingDate = reader["BOOKINGDATE"].ToString();
                                departureDate = reader["DEPARTUREDATE"].ToString();
                                reservationStatus = reader["RESERVATIONSTATUS"].ToString();
                                fare = reader["FARE"].ToString();
                                soldStatus = reader["SOLDSTATUS"].ToString();

                                sendEmail("G13 Railway Ticket Reservation", @"Ticket No. " + ticketNo +
                                    " \nDeparture Station: " + fromStation +
                                    " \nArrival/To Station: " + toStation +
                                    " \nClass Type: " + classType +
                                    " \nRoute Name: " + routeName +
                                    " \nBooking Date: " + bookingDate +
                                    " \nDeparture Date: " + departureDate +
                                    " \nReservation Status: " + reservationStatus +
                                    " \nFare: " + fare +
                                    " \nSold Status: " + soldStatus +
                                    " \nYour Ticket Payment Is Refunded", passengerEmail);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    conn.Close();
                }
            }
            FillcomboBox();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            string ticketID = comboBoxTicketID.Text;
            if (ticketID.Length == 0)
            {
                return;
            }

            string passengerEmail = string.Empty,
                    ticketNo = string.Empty,
                    fromStation = string.Empty,
                    toStation = string.Empty,
                    classType = string.Empty,
                    routeName = string.Empty,
                    bookingDate = string.Empty,
                    departureDate = string.Empty,
                    reservationStatus = string.Empty,
                    fare = string.Empty;
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = "SELECT TICKETRESERVATIONID, (SELECT EMAIL FROM USERS U INNER JOIN PASSENGER P ON U.USERID = P.USERID WHERE P.PASSENGERID = TR.PASSENGERID ) AS EMAIL, GETFROMSTATION (R.ROUTEID) AS FROMSTATION, GETTOSTATION (R.ROUTEID) AS TOSTATION, CLASSTYPE, ROUTENAME, BOOKINGDATE, DEPARTUREDATE, RESERVATIONSTATUS, FARE, SOLDSTATUS FROM TICKET_RESERVATION TR INNER JOIN TRAIN_SCHEDULE TS ON TS.SCHEDULEID = TR.SCHEDULEID INNER JOIN ROUTE R ON R.ROUTEID = TS.ROUTEID INNER JOIN TRAIN_CLASS TC ON TC.CLASSID = TR.CLASSID WHERE TR.TICKETRESERVATIONID = :ticketID";
                try
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add("tID", OracleDbType.Varchar2).Value = ticketID;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                passengerEmail = reader["EMAIL"].ToString();
                                ticketNo = reader["TICKETRESERVATIONID"].ToString();
                                fromStation = reader["FROMSTATION"].ToString();
                                toStation = reader["TOSTATION"].ToString();
                                classType = reader["CLASSTYPE"].ToString();
                                routeName = reader["ROUTENAME"].ToString();
                                bookingDate = reader["BOOKINGDATE"].ToString();
                                departureDate = reader["DEPARTUREDATE"].ToString();
                                reservationStatus = reader["RESERVATIONSTATUS"].ToString();
                                fare = reader["FARE"].ToString();

                                sendEmail("G13 Railway Ticket Reservation", @"Ticket No. " + ticketNo +
                                    " \nDeparture Station: " + fromStation +
                                    " \nArrival/To Station: " + toStation +
                                    " \nClass Type: " + classType +
                                    " \nRoute Name: " + routeName +
                                    " \nBooking Date: " + bookingDate +
                                    " \nDeparture Date: " + departureDate +
                                    " \nReservation Status: " + reservationStatus +
                                    " \nFare: " + fare +
                                    " \nYour Ticket Is Canceled", passengerEmail);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                conn.Close();
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
            comboBoxSoldStatus.Text = dataGridViewSeat.CurrentRow.Cells[9].Value.ToString();
        }

        private void dataGridViewSeat_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBoxTicketID.Text = dataGridViewSeat.CurrentRow.Cells[0].Value.ToString();
            comboBoxSoldStatus.Text = dataGridViewSeat.CurrentRow.Cells[9].Value.ToString();
        }

        private void sendEmail(string subject, string emailMessage, string ToEmail)
        {
            string fromEmail = "g13railway@gmail.com", password = "tdpr nobb lovl viqw";
            string messageBody = string.Empty;
            MailMessage message = new MailMessage();
            messageBody = emailMessage;
            message.To.Add(ToEmail);
            message.From = new MailAddress(fromEmail);
            message.Body = messageBody;
            message.Subject = subject;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(fromEmail, password);

            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Email Sent Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
