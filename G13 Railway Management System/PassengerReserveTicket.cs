using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace G13_Railway_Management_System
{
    public partial class PassengerReserveTicket : UserControl
    {
        string connectionString;
        Panel panelPassenger = null;
        PassengerBookSeat passengerBookSeat = null;
        string sID, tID, pID;
        public PassengerReserveTicket(Panel panelPassenger, PassengerBookSeat passengerBookSeat, string connectionString, string sID, string tID, string pID)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.sID = sID;
            this.tID = tID;
            this.pID = pID;
            this.panelPassenger = panelPassenger;
            this.passengerBookSeat = passengerBookSeat;


            string query = "SELECT DISTINCT CLASSTYPE FROM TRAIN_SCHEDULE TS INNER JOIN SEAT S ON S.TRAINID = TS.TRAINID INNER JOIN TRAIN_CLASS TC ON S.CLASSID = TC.CLASSID WHERE TS.TRAINID = :tID AND TS.SCHEDULEID = :sID";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add("tID", OracleDbType.Varchar2).Value = tID;
                cmd.Parameters.Add("sID", OracleDbType.Varchar2).Value = sID;
                OracleDataReader reader = cmd.ExecuteReader();

                List<string> dataList = new List<string>();
                while (reader.Read())
                {
                    dataList.Add(reader[0].ToString());
                }

                comboBoxClassType.DataSource = dataList;
                conn.Close();
            }
        }
        public void FillcomboBox()
        {
            string cName = comboBoxClassType.Text;
            string query = "SELECT SEATID FROM (SELECT S.SEATID FROM SEAT S INNER JOIN TRAIN_SCHEDULE TS ON TS.TRAINID = S.TRAINID WHERE TS.TRAINID = :tID AND TS.SCHEDULEID = :sID AND S.CLASSID = (SELECT CLASSID FROM TRAIN_CLASS WHERE CLASSTYPE = :cName) ORDER BY S.SEATID) MINUS SELECT SEATID FROM (SELECT SEATID FROM TICKET_RESERVATION WHERE TRAINID = :tID AND SCHEDULEID = :sID AND CLASSID = (SELECT CLASSID FROM TRAIN_CLASS WHERE CLASSTYPE = :cName) ORDER BY SEATID)";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add("tID", OracleDbType.Varchar2).Value = tID;
                cmd.Parameters.Add("sID", OracleDbType.Varchar2).Value = sID;
                cmd.Parameters.Add("cName", OracleDbType.Varchar2).Value = cName;
                OracleDataReader reader = cmd.ExecuteReader();

                List<string> dataList = new List<string>();
                while (reader.Read())
                {
                    dataList.Add(reader[0].ToString());
                }

                comboBoxSeatNo.DataSource = dataList;
                conn.Close();
            }
            query = "SELECT BASEFARE * (SELECT FAREMULTIPLIER FROM TRAIN_CLASS WHERE CLASSTYPE = :cName) AS FARE FROM TRAIN_SCHEDULE WHERE SCHEDULEID = :sID";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                conn.Open();
                cmd.Parameters.Add("cName", OracleDbType.Varchar2).Value = cName;
                cmd.Parameters.Add("sID", OracleDbType.Varchar2).Value = sID;
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBoxFare.Text = reader["fare"].ToString();
                }
                conn.Close();
            }
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelPassenger.Controls.Clear();
            panelPassenger.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            bool check = false;
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string cName = comboBoxClassType.Text,
                        seatID = comboBoxSeatNo.Text,
                        fare = textBoxFare.Text;
                    string query = "INSERT INTO TICKET_RESERVATION (SEATID, TRAINID, CLASSID, SCHEDULEID, PASSENGERID, BOOKINGDATE,\tRESERVATIONSTATUS, FARE, SOLDSTATUS) VALUES (:seatID, :tID, (SELECT CLASSID FROM TRAIN_CLASS WHERE CLASSTYPE = :cName), :sID, :pID, CURRENT_DATE, 'Active', :fare, 'Not Sold')";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("seatID", OracleDbType.Varchar2).Value = seatID;
                        command.Parameters.Add("tID", OracleDbType.Varchar2).Value = tID;
                        command.Parameters.Add("cName", OracleDbType.Varchar2).Value = cName;
                        command.Parameters.Add("sID", OracleDbType.Varchar2).Value = sID;
                        command.Parameters.Add("pID", OracleDbType.Varchar2).Value = pID;
                        command.Parameters.Add("fare", OracleDbType.Varchar2).Value = fare;
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ticket Booked");
                            check = true;
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
                    fare = string.Empty,
                    soldStatus = string.Empty;
                string query = "SELECT TICKETRESERVATIONID, (SELECT EMAIL FROM USERS U INNER JOIN PASSENGER P ON U.USERID = P.USERID WHERE P.PASSENGERID = :pID) AS EMAIL, GETFROMSTATION (R.ROUTEID) AS FROMSTATION, GETTOSTATION (R.ROUTEID) AS TOSTATION, CLASSTYPE, ROUTENAME, BOOKINGDATE, DEPARTUREDATE, RESERVATIONSTATUS, FARE, SOLDSTATUS FROM TICKET_RESERVATION TR INNER JOIN TRAIN_SCHEDULE TS ON TS.SCHEDULEID = TR.SCHEDULEID INNER JOIN ROUTE R ON R.ROUTEID = TS.ROUTEID INNER JOIN TRAIN_CLASS TC ON TC.CLASSID = TR.CLASSID WHERE PASSENGERID = :pID AND TICKETRESERVATIONID = (SELECT MAX(TICKETRESERVATIONID) FROM TICKET_RESERVATION)";
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand(query, conn);
                        cmd.Parameters.Add("pID", OracleDbType.Varchar2).Value = pID;
                        OracleDataReader reader = cmd.ExecuteReader();

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
                                " \nYour Ticket is Booked", passengerEmail);
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

        private void comboBoxClassType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillcomboBox();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AddUserControl(passengerBookSeat);
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
