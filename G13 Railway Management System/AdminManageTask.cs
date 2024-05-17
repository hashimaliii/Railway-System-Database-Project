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
    public partial class AdminManageTask : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        public AdminManageTask(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
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
                    string query = "SELECT TASKNAME, DESCRIPTION, DUEDATE, TASKSTATUS, PAY FROM TASKS WHERE TASKID = TASKID";
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

        private void buttonAdd_Click(object sender, EventArgs e)
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
                    string query = "INSERT INTO TASKS (TASKNAME, DESCRIPTION, DUEDATE, TASKSTATUS, PAY) VALUES (:taskName, :description, :dueDate, :taskStatus, :amount)";

                    //if (!(taskName.Length > 0))
                    //{
                    //    connection.Close();
                    //    return;
                    //}

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("taskName", OracleDbType.Varchar2).Value = taskName;
                        command.Parameters.Add("description", OracleDbType.Varchar2).Value = description;
                        command.Parameters.Add("dueDate", OracleDbType.Varchar2).Value = dueDate;
                        command.Parameters.Add("taskStatus", OracleDbType.Varchar2).Value = status;
                        command.Parameters.Add("pay", OracleDbType.Int32).Value = amount;

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Added Successfully");
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string taskName = textBoxTaskName.Text;
                    string query = "DELETE FROM TASKS WHERE TASKNAME = :taskName";
                    if (!(taskName.Length > 0))
                    {
                        connection.Close();
                        return;
                    }

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("taskName", OracleDbType.Varchar2).Value = taskName;

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted Successfully");
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

        private void buttonAdminUpdate_Click(object sender, EventArgs e)
        {
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
                    string query = "UPDATE TASKS SET TASKNAME = :taskName, DESCRIPTION = :description, DUEDATE = :dueDate, TASKSTATUS= :taskStatus, PAY = :pay WHERE TASKNAME = :taskName";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("description", OracleDbType.Varchar2).Value = description;
                        command.Parameters.Add("dueDate", OracleDbType.Varchar2).Value = dueDate;
                        command.Parameters.Add("taskStatus", OracleDbType.Varchar2).Value = status;
                        command.Parameters.Add("pay", OracleDbType.Int64).Value = amount;
                        command.Parameters.Add("taskName", OracleDbType.Varchar2).Value = taskName;

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Updated Successfully");
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
