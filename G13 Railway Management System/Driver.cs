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
    public partial class Driver : Form
    {
        Login loginForm = null;
        string connectionString = null;
        string eID = null;
        public Driver(string connectionString, Login loginform, string eID, string firstName)
        {
            InitializeComponent();
            labelDriverName.Text = firstName;
            this.loginForm = loginform;
            this.connectionString = connectionString;
            this.eID = eID;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            EmployeeDashboard employeeDashboard = new EmployeeDashboard();
            AddUserControl(employeeDashboard);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelDriver.Controls.Clear();
            panelDriver.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void buttonDriverDashboard_Click(object sender, EventArgs e)
        {
            EmployeeDashboard employeeDashboard = new EmployeeDashboard();
            AddUserControl(employeeDashboard);
        }

        private void buttonDriverProfile_Click(object sender, EventArgs e)
        {
            EmployeeProfile employeeProfile = new EmployeeProfile(connectionString, eID);
            AddUserControl(employeeProfile);
        }

        private void buttonDriverSalary_Click(object sender, EventArgs e)
        {
            EmployeeSalary employeeSalary = new EmployeeSalary(connectionString, eID);
            AddUserControl(employeeSalary);
        }

        private void buttonDriverTask_Click(object sender, EventArgs e)
        {
            EmployeeTask employeeTask = new EmployeeTask(connectionString, eID);
            AddUserControl(employeeTask);
        }

        private void buttonDriverLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }
    }
}
