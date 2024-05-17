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
    public partial class CustomerSupport : Form
    {
        Login loginForm = null;
        string connectionString = null;
        string eID = null;
        public CustomerSupport(string connectionString, Login loginform, string eID, string firstName)
        {
            InitializeComponent();
            labelCustomerSupportName.Text = firstName;
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
            panelCustomerSupport.Controls.Clear();
            panelCustomerSupport.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void buttonCustomerSupportDashboard_Click(object sender, EventArgs e)
        {
            EmployeeDashboard employeeDashboard = new EmployeeDashboard();
            AddUserControl(employeeDashboard);
        }

        private void buttonCustomerSupportProfile_Click(object sender, EventArgs e)
        {
            EmployeeProfile employeeProfile = new EmployeeProfile(connectionString, eID);
            AddUserControl(employeeProfile);
        }

        private void buttonCustomerSupportSalary_Click(object sender, EventArgs e)
        {
            EmployeeSalary employeeSalary = new EmployeeSalary(connectionString, eID);
            AddUserControl(employeeSalary);
        }

        private void buttonCustomerSupportTask_Click(object sender, EventArgs e)
        {
            EmployeeTask employeeTask = new EmployeeTask(connectionString, eID);
            AddUserControl(employeeTask);
        }
        private void buttonCustomerSupport_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService(connectionString, eID);
            AddUserControl(customerService);
        }

        private void buttonCustomerSupportLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }

    }
}
