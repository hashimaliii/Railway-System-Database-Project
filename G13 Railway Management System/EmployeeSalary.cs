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
using Org.BouncyCastle.Asn1.Cmp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace G13_Railway_Management_System
{
    public partial class EmployeeSalary : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        string eID;
        public EmployeeSalary(string connectionString, string eID)
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
                    string amount = textBoxAmount.Text,
                        numberOfTask = textBoxTaskCount.Text,
                        paidStatus = comboBoxPaidStatus.Text,
                        salaryMonth = textBoxSalaryMonth.Text,
                        salaryYear = textBoxSalaryYear.Text;
                    string query = "SELECT SALARYDATE, AMOUNT, TASKCOUNT, PAIDSTATUS FROM SALARY_RECORD WHERE EMPLOYEEID = :EMPLOYEEID ";
                    if (amount.Length > 0)
                    {
                        query += " AND AMOUNT = :AMOUNT";
                    }
                    if (numberOfTask.Length > 0)
                    {
                        query += " AND TASKCOUNT = :TASKCOUNT";
                    }
                    if (paidStatus.Length > 0)
                    {
                        query += " AND PAIDSTATUS = :PAIDSTATUS";
                    }
                    if (salaryMonth.Length > 0)
                    {
                        query += "AND EXTRACT(MONTH FROM SALARYDATE) = :SALARYMONTH";
                    }
                    if (salaryYear.Length > 0)
                    {
                        query += "AND EXTRACT(YEAR FROM SALARYDATE) = :SALARYYEAR";
                    }

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("EMPLOYEEID", OracleDbType.Int64).Value = eID;
                        if (amount.Length > 0)
                        {
                            command.Parameters.Add("AMOUNT", OracleDbType.Int64).Value = amount;
                        }
                        if (numberOfTask.Length > 0)
                        {
                            command.Parameters.Add("TASKCOUNT", OracleDbType.Int64).Value = numberOfTask;
                        }
                        if (paidStatus.Length > 0)
                        {
                            command.Parameters.Add("PAIDSTATUS", OracleDbType.Varchar2).Value = paidStatus;
                        }
                        if (salaryMonth.Length > 0)
                        {
                            command.Parameters.Add("SALARYMONTH", OracleDbType.Int64).Value = salaryMonth;
                        }
                        if (salaryYear.Length > 0)
                        {
                            command.Parameters.Add("SALARYYEAR", OracleDbType.Int64).Value = salaryYear;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewSalaryRecord.DataSource = dataTable;
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

        private void dataGridViewSalaryRecord_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime salaryDate = DateTime.Parse(dataGridViewSalaryRecord.CurrentRow.Cells[0].Value.ToString());
            textBoxSalaryMonth.Text = salaryDate.Month.ToString();
            textBoxSalaryYear.Text = salaryDate.Year.ToString();
            textBoxAmount.Text = dataGridViewSalaryRecord.CurrentRow.Cells[1].Value.ToString();
            textBoxTaskCount.Text = dataGridViewSalaryRecord.CurrentRow.Cells[2].Value.ToString();
            comboBoxPaidStatus.Text = dataGridViewSalaryRecord.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridViewSalaryRecord_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DateTime salaryDate = DateTime.Parse(dataGridViewSalaryRecord.CurrentRow.Cells[0].Value.ToString());
            textBoxSalaryMonth.Text = salaryDate.Month.ToString();
            textBoxSalaryYear.Text = salaryDate.Year.ToString();
            textBoxAmount.Text = dataGridViewSalaryRecord.CurrentRow.Cells[1].Value.ToString();
            textBoxTaskCount.Text = dataGridViewSalaryRecord.CurrentRow.Cells[2].Value.ToString();
            comboBoxPaidStatus.Text = dataGridViewSalaryRecord.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
