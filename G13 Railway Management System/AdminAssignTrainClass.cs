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

    public partial class AdminAssignTrainClass : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        public AdminAssignTrainClass(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            FillcomboBox();
            search();
        }

        public void FillcomboBox()
        {
            string query = "SELECT CLASSTYPE FROM TRAIN_CLASS";

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

                comboBoxClassName.DataSource = dataList;
                conn.Close();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            string trainName = textBoxTrainName.Text,
                className = comboBoxClassName.Text,
                seats = textBoxSeatCapacity.Text;

            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT T.TRAINNAME, TC.CLASSTYPE, COUNT (S.SEATID) AS NUMBER_OF_SEATS FROM SEAT S\r\nINNER JOIN TRAIN T ON T.TRAINID = S.TRAINID\r\nINNER JOIN TRAIN_CLASS TC ON TC.CLASSID = S.CLASSID\r\nWHERE SEATID = SEATID ";

                    if (trainName.Length > 0)
                    {
                        query += " AND S.TRAINID = (SELECT TRAINID FROM TRAIN WHERE TRAINNAME = :trainName) ";
                    }
                    if (className.Length > 0)
                    {
                        query += " AND S.CLASSID = (SELECT CLASSID FROM TRAIN_CLASS WHERE CLASSTYPE = :className) ";
                    }
                    if (seats.Length > 0)
                    {
                        query += " HAVING COUNT (S.SEATID) = :seats";
                    }
                    query += " GROUP BY (T.TRAINNAME, TC.CLASSTYPE)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (trainName.Length > 0)
                        {
                            command.Parameters.Add("trainName", OracleDbType.Varchar2).Value = trainName;
                        }
                        if (className.Length > 0)
                        {
                            command.Parameters.Add("className", OracleDbType.Varchar2).Value = className;
                        }
                        if (seats.Length > 0)
                        {
                            command.Parameters.Add("seats", OracleDbType.Varchar2).Value = seats;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewAssignTrainClass.DataSource = dataTable;
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
            string trainName = textBoxTrainName.Text,
                className = comboBoxClassName.Text,
                seats = textBoxSeatCapacity.Text;

            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DECLARE\r\ncounter NUMBER := 1;\r\nit NUMBER := :seats;\r\nBEGIN\r\nLOOP\r\nINSERT INTO SEAT (SEATID, TRAINID, CLASSID) VALUES (counter, (SELECT TRAINID FROM TRAIN WHERE TRAINNAME = :trainName), (SELECT CLASSID FROM TRAIN_CLASS WHERE CLASSTYPE = :className));\r\nIF counter = it THEN\r\nEXIT;\r\nEND IF;\r\ncounter := counter + 1;\r\nEND LOOP;\r\nEND;";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("seats", OracleDbType.Int64).Value = seats;
                        command.Parameters.Add("trainName", OracleDbType.Varchar2).Value = trainName;
                        command.Parameters.Add("className", OracleDbType.Varchar2).Value = className;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Added Successfully");
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string trainName = textBoxTrainName.Text,
                className = comboBoxClassName.Text,
                seats = textBoxSeatCapacity.Text;

            dataTable.Clear();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM SEAT S\r\nWHERE SEATID = SEATID AND S.TRAINID = (SELECT TRAINID FROM TRAIN WHERE TRAINNAME = :trainName) AND S.CLASSID = (SELECT CLASSID FROM TRAIN_CLASS WHERE CLASSTYPE = :className)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("trainName", OracleDbType.Varchar2).Value = trainName;
                        command.Parameters.Add("className", OracleDbType.Varchar2).Value = className;
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
            FillcomboBox();
        }

        private void dataGridViewAssignTrainClass_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTrainName.Text = dataGridViewAssignTrainClass.CurrentRow.Cells[0].Value.ToString();
            comboBoxClassName.Text = dataGridViewAssignTrainClass.CurrentRow.Cells[1].Value.ToString();
            textBoxSeatCapacity.Text = dataGridViewAssignTrainClass.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridViewAssignTrainClass_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxTrainName.Text = dataGridViewAssignTrainClass.CurrentRow.Cells[0].Value.ToString();
            comboBoxClassName.Text = dataGridViewAssignTrainClass.CurrentRow.Cells[1].Value.ToString();
            textBoxSeatCapacity.Text = dataGridViewAssignTrainClass.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
