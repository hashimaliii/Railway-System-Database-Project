using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G13_Railway_Management_System
{
    public partial class Passenger : Form
    {
        Login loginForm = null;
        string connectionString = null;
        string pID;
        public Passenger(string connectionString, Login loginform, string pID, string firstName)
        {
            InitializeComponent();
            labelPassengerName.Text = firstName;
            this.loginForm = loginform;
            this.connectionString = connectionString;
            this.pID = pID;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            PassengerDashboard passengerDashboard = new PassengerDashboard();
            AddUserControl(passengerDashboard);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelPassenger.Controls.Clear();
            panelPassenger.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void buttonPassengerDashboard_Click(object sender, EventArgs e)
        {
            PassengerDashboard passengerDashboard = new PassengerDashboard();
            AddUserControl(passengerDashboard);
        }

        private void buttonPassengerProfile_Click(object sender, EventArgs e)
        {
            PassengerProfile passengerProfile = new PassengerProfile(connectionString, pID);
            AddUserControl(passengerProfile);
        }

        private void buttonBookSeat_Click(object sender, EventArgs e)
        {
            PassengerBookSeat passengerBookSeat = new PassengerBookSeat(connectionString, pID, panelPassenger);
            AddUserControl(passengerBookSeat);
        }

        private void buttonPreviousReservation_Click(object sender, EventArgs e)
        {
            PassengerPreviousReservation passengerPreviousReservation = new PassengerPreviousReservation(connectionString, pID);
            AddUserControl(passengerPreviousReservation);
        }

        private void buttonCustomerSupport_Click(object sender, EventArgs e)
        {
            PassengerCustomerSupport passengerCustomerService = new PassengerCustomerSupport(connectionString, pID);
            AddUserControl(passengerCustomerService);
        }

        private void buttonTrackTrain_Click(object sender, EventArgs e)
        {
            PassengerTrackTrain passengerTrackTrain = new PassengerTrackTrain(connectionString, pID);
            AddUserControl(passengerTrackTrain);
        }

        private void buttonPassengerLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }
    }
}
