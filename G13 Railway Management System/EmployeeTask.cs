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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace G13_Railway_Management_System
{
    public partial class EmployeeTask : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        string eID;
        public EmployeeTask(string connectionString, string eID)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.eID = eID;
            search();
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
                    string taskName = textBoxTaskName.Text,
                        dueDate = textBoxTaskDueDate.Text,
                        status = comboBoxTaskStatus.Text,
                        description = textBoxTaskDescription.Text,
                        amount = textBoxAmount.Text;
                    string query = "SELECT TASKNAME, DESCRIPTION, DUEDATE, TASKSTATUS, PAY FROM ASSIGNED_TASK AT INNER JOIN TASKS T ON AT.TASKID = T.TASKID WHERE EMPLOYEEID = :eID";
                    if (taskName.Length > 0)
                    {
                        query += " AND TASKNAME = :taskName ";
                    }
                    if (dueDate.Length > 0)
                    {
                        query += " AND DUEDATE = :dueDate ";
                    }
                    if (status.Length > 0)
                    {
                        query += " AND TASKSTATUS = :status ";
                    }
                    if (description.Length > 0)
                    {
                        query += " AND DESCRIPTION = :description ";
                    }
                    if (amount.Length > 0)
                    {
                        query += " AND PAY = :amount ";
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("eID", OracleDbType.Varchar2).Value = eID;
                        if (taskName.Length > 0)
                        {
                            command.Parameters.Add("taskName", OracleDbType.Varchar2).Value = taskName;
                        }
                        if (dueDate.Length > 0)
                        {
                            command.Parameters.Add("dueDate", OracleDbType.Varchar2).Value = dueDate;
                        }
                        if (status.Length > 0)
                        {
                            command.Parameters.Add("taskStatus", OracleDbType.Varchar2).Value = status;
                        }
                        if (description.Length > 0)
                        {
                            command.Parameters.Add("description", OracleDbType.Varchar2).Value = description;
                        }
                        if (amount.Length > 0)
                        {
                            command.Parameters.Add("amount", OracleDbType.Int32).Value = amount;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewAdminEmployee.DataSource = dataTable;
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

        private void buttonMarkAsComplete_Click(object sender, EventArgs e)
        {
            string taskName = textBoxTaskName.Text;
            if (taskName.Length == 0) { return; }

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE TASKS SET TASKSTATUS = 'Completed' WHERE TASKNAME = :taskName";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("taskName", OracleDbType.Varchar2).Value = taskName;
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Task Updated");
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
        }

        private void dataGridViewAdminEmployee_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTaskName.Text = dataGridViewAdminEmployee.CurrentRow.Cells[0].Value.ToString();
            textBoxTaskDescription.Text = dataGridViewAdminEmployee.CurrentRow.Cells[1].Value.ToString();
            textBoxTaskDueDate.Text = dataGridViewAdminEmployee.CurrentRow.Cells[2].Value.ToString();
            comboBoxTaskStatus.Text = dataGridViewAdminEmployee.CurrentRow.Cells[3].Value.ToString();
            textBoxAmount.Text = dataGridViewAdminEmployee.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridViewAdminEmployee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxTaskName.Text = dataGridViewAdminEmployee.CurrentRow.Cells[0].Value.ToString();
            textBoxTaskDescription.Text = dataGridViewAdminEmployee.CurrentRow.Cells[1].Value.ToString();
            textBoxTaskDueDate.Text = dataGridViewAdminEmployee.CurrentRow.Cells[2].Value.ToString();
            comboBoxTaskStatus.Text = dataGridViewAdminEmployee.CurrentRow.Cells[3].Value.ToString();
            textBoxAmount.Text = dataGridViewAdminEmployee.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
