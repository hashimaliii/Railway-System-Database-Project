using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace G13_Railway_Management_System
{
    public partial class AdminAssignTask : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        public AdminAssignTask(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
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
                    string employeeCNIC = textBoxEmployeeCNIC.Text,
                        taskName = textBoxTaskName.Text;
                    string query = "SELECT U.CNIC, T.TASKNAME FROM USERS U\r\nINNER JOIN EMPLOYEE E ON U.USERID = E.USERID\r\nINNER JOIN ASSIGNED_TASK AT ON E.EMPLOYEEID = AT.EMPLOYEEID\r\nINNER JOIN TASKS T ON AT.TASKID = T.TASKID\r\nWHERE U.CNIC = U.CNIC";

                    if (employeeCNIC.Length > 0)
                    {
                        query += "  AND U.CNIC =:CNIC";
                    }
                    if (taskName.Length > 0)
                    {
                        query += " AND T.TASKNAME = :TASKNAME";
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (employeeCNIC.Length > 0)
                        {
                            command.Parameters.Add("CNIC", OracleDbType.Int64).Value = Int64.Parse(employeeCNIC);
                        }
                        if (taskName.Length > 0)
                        {
                            command.Parameters.Add("TASKNAME", OracleDbType.Varchar2).Value = taskName;
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            search();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open(); 
                    string employeeCNIC = textBoxEmployeeCNIC.Text,taskName = textBoxTaskName.Text;
                    string query = "INSERT INTO ASSIGNED_TASK (EMPLOYEEID, TASKID) VALUES ((SELECT EMPLOYEEID FROM EMPLOYEE E INNER JOIN USERS U ON E.USERID = U.USERID WHERE U.CNIC = :CNIC), (SELECT TASKID FROM TASKS T WHERE TASKNAME = :taskName))";
                    if (!(taskName.Length > 0 && employeeCNIC.Length > 0))
                    {
                        return;
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("CNIC", OracleDbType.Int64).Value = Int64.Parse(employeeCNIC);
                        command.Parameters.Add("TASKNAME", OracleDbType.Varchar2).Value = taskName;
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
                    string employeeCNIC = textBoxEmployeeCNIC.Text,taskName = textBoxTaskName.Text;
                    string query = "DELETE FROM ASSIGNED_TASK WHERE EMPLOYEEID = EMPLOYEEID ";
                    bool chk = false;
                    if(employeeCNIC.Length > 0)
                    {
                        query += " AND (SELECT EMPLOYEEID FROM EMPLOYEE E INNER JOIN USERS U ON E.USERID = U.USERID WHERE U.CNIC = :CNIC)";
                        chk = true;
                    }
                    if(taskName.Length > 0) 
                    {
                        query += " AND TASKID = (SELECT TASKID FROM TASKS T WHERE TASKNAME = :taskName)";
                        chk = true;
                    }
                    if(!chk)
                    {
                        connection.Close();
                        return;
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (employeeCNIC.Length > 0)
                        {
                            command.Parameters.Add("CNIC", OracleDbType.Int64).Value = Int64.Parse(employeeCNIC);
                        }
                        if (taskName.Length > 0)
                        {
                            command.Parameters.Add("TASKNAME", OracleDbType.Varchar2).Value = taskName;
                        }
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

        private void dataGridViewAdminEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxEmployeeCNIC.Text = dataGridViewAdminEmployee.CurrentRow.Cells[0].Value.ToString();
            textBoxTaskName.Text = dataGridViewAdminEmployee.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridViewAdminEmployee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxEmployeeCNIC.Text = dataGridViewAdminEmployee.CurrentRow.Cells[0].Value.ToString();
            textBoxTaskName.Text = dataGridViewAdminEmployee.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
