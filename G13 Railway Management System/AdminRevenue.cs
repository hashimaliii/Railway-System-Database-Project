using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Oracle.ManagedDataAccess.Client;

namespace G13_Railway_Management_System
{
    public partial class AdminRevenue : UserControl
    {

        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        public AdminRevenue(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            search();
        }

        private string getDateFormat(DateTime Dt)
        {
            string Date = "";
            if (Dt.Month.ToString().Length == 1)
            {
                Date += "0";
            }
            Date += Dt.Month.ToString() + "/";
            if (Dt.Day.ToString().Length == 1)
            {
                Date += "0";
            }
            Date += Dt.Day.ToString() + "/" + Dt.Year.ToString();
            return Date;
        }

        private void buttonCalculateRevenue_Click(object sender, EventArgs e)
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
                    //string revenueFrom = getDateFormat(dateTimePickerRevenueFrom.Value), revenueTo = getDateFormat(dateTimePickerRevenueTo.Value);
                    DateTime revenueFrom = dateTimePickerRevenueFrom.Value, revenueTo = dateTimePickerRevenueTo.Value;
                    string query = "SELECT SUM (FARE) AS TOTAL FROM TICKET_RESERVATION\r\nWHERE SOLDSTATUS = 'Sold' AND RESERVATIONSTATUS = 'Active' AND BOOKINGDATE > :RevenueFrom AND BOOKINGDATE < :RevenueTo";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("RevenueFrom", OracleDbType.Date).Value = revenueFrom;
                        command.Parameters.Add("RevenueTo", OracleDbType.Date).Value = revenueTo;
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBoxTotalRevenue.Text = reader["TOTAL"].ToString();
                            }
                        }
                    }
                    query = "SELECT FIRSTNAME, LASTNAME, EMAIL, PHONENUMBER, CNIC, ADDRESS, BOOKINGDATE, FARE FROM TICKET_RESERVATION TR\r\nINNER JOIN PASSENGER P ON P.PASSENGERID = TR.PASSENGERID\r\nINNER JOIN USERS U ON U.USERID = P.USERID\r\nWHERE SOLDSTATUS = 'Sold' AND RESERVATIONSTATUS = 'Active' AND BOOKINGDATE > :RFrom AND BOOKINGDATE < :RTo";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("RevenueFrom", OracleDbType.Date).Value = revenueFrom;
                        command.Parameters.Add("RevenueTo", OracleDbType.Date).Value = revenueTo;
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewRevenue.DataSource = dataTable;
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

        private void buttonAdminMakePDF_Click(object sender, EventArgs e)
        {
            if (dataGridViewRevenue.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Revenue.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridViewRevenue.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dataGridViewRevenue.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridViewRevenue.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    if (dcell.Value == null)
                                    {
                                        pTable.AddCell("");
                                    }
                                    else
                                    {
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Revenue Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Revenue" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }
    }
}
