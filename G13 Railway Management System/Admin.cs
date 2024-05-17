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
    public partial class Admin : Form
    {
        Login loginForm = null;
        string adminID = string.Empty, connectionString = string.Empty;
        public Admin(string connectionString, Login loginform, string aID, string firstName)
        {
            adminID = aID;
            InitializeComponent();
            labelAdminName.Text = firstName;
            this.loginForm = loginform;
            this.connectionString = connectionString;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            AdminDashboard adminDashboard = new AdminDashboard(connectionString);
            AddUserControl(adminDashboard);
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelAdmin.Controls.Clear();
            panelAdmin.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void buttonAdminDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard(connectionString);
            AddUserControl(adminDashboard);
        }

        private void buttonAdminLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }

        private void buttonAdminProfile_Click(object sender, EventArgs e)
        {
            AdminProfile adminProfile = new AdminProfile(connectionString, adminID);
            AddUserControl(adminProfile);
        }

        private void buttonAdminManageEmployee_Click(object sender, EventArgs e)
        {
            AdminManageEmployee adminManageEmployee = new AdminManageEmployee(connectionString);
            AddUserControl(adminManageEmployee);
        }

        private void buttonAdminManageTrainSchedule_Click(object sender, EventArgs e)
        {
            AdminManageTrainSchedule adminManageTrainSchedule = new AdminManageTrainSchedule(connectionString);
            AddUserControl(adminManageTrainSchedule);
        }

        private void buttonAdminViewTrain_Click(object sender, EventArgs e)
        {
            AdminManageTrain adminViewTrain = new AdminManageTrain(connectionString);
            AddUserControl(adminViewTrain);
        }

        private void buttonAdminAssignTask_Click(object sender, EventArgs e)
        {
            AdminAssignTask adminAssignTask = new AdminAssignTask(connectionString);
            AddUserControl(adminAssignTask);
        }

        private void buttonAdminFeedback_Click(object sender, EventArgs e)
        {
            CustomerService adminFeedback = new CustomerService(connectionString, "admin");
            AddUserControl(adminFeedback);
        }

        private void buttonRevenue_Click(object sender, EventArgs e)
        {
            AdminRevenue adminRevenue = new AdminRevenue(connectionString);
            AddUserControl(adminRevenue);
        }

        private void buttonAssingTrainClass_Click(object sender, EventArgs e)
        {
            AdminAssignTrainClass adminAssignTrainClass = new AdminAssignTrainClass(connectionString);
            AddUserControl(adminAssignTrainClass);
        }

        private void buttonManageTrainClass_Click(object sender, EventArgs e)
        {
            AdminManageTrainClass adminManageTrainClass = new AdminManageTrainClass(connectionString);
            AddUserControl(adminManageTrainClass);
        }

        private void buttonManageStation_Click(object sender, EventArgs e)
        {
            AdminManageStation adminManageStation = new AdminManageStation(connectionString);
            AddUserControl(adminManageStation);
        }

        private void buttonManageRoute_Click(object sender, EventArgs e)
        {
            AdminManageRoute adminManageRoute = new AdminManageRoute(connectionString);
            AddUserControl(adminManageRoute);
        }

        private void buttonManageStop_Click(object sender, EventArgs e)
        {
            AdminManageStop adminManageStop = new AdminManageStop(connectionString);
            AddUserControl(adminManageStop);
        }

        private void buttonManageTask_Click(object sender, EventArgs e)
        {
            AdminManageTask adminManageTask = new AdminManageTask(connectionString);
            AddUserControl(adminManageTask);
        }
    }
}
