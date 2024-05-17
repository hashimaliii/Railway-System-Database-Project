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
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace G13_Railway_Management_System
{
    public partial class AdminManageTrain : UserControl
    {
        DataTable dataTable = new DataTable();
        string connectionString = string.Empty;
        public AdminManageTrain(string connectionString)
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
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string trainName = textBoxTrainName.Text;
                    string query = "SELECT TRAINNAME, TRAINPICTURE FROM TRAIN WHERE TRAINNAME = TRAINNAME";
                    if (trainName.Length > 0)
                    {
                        query += " AND trainName = :trainName ";
                    }
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (trainName.Length > 0)
                        {
                            command.Parameters.Add("trainName", OracleDbType.Varchar2).Value = trainName;
                        }
                        using (OracleDataAdapter oracleAdapter = new OracleDataAdapter(command))
                        {
                            oracleAdapter.Fill(dataTable);
                            dataGridViewTrain.DataSource = dataTable;
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
            string trainName = textBoxTrainName.Text;
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM TRAIN WHERE TRAINNAME = :trainName";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("trainName", OracleDbType.Varchar2).Value = trainName;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string trainName = textBoxTrainName.Text;
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO TRAIN (TRAINNAME, TRAINPICTURE) VALUES (:trainName, :trainPicture)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("trainName", OracleDbType.Varchar2).Value = trainName;
                        command.Parameters.Add("trainPicture", OracleDbType.Blob).Value = getPhoto();

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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE TRAIN SET TRAINNAME = :trainName, TRAINPICTURE = :trainPicture WHERE TRAINNAME = :trainName";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("trainName", OracleDbType.Varchar2).Value = textBoxTrainName.Text;
                        command.Parameters.Add("trainPicture", OracleDbType.Blob).Value = getPhoto();

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

        private void buttonChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxTrainPicture.Image = new Bitmap(openFileDialog.FileName);
            }
        }
        private byte[] getPhoto()
        {
            //MemoryStream memoryStream = new MemoryStream();
            //pictureBoxProfilePicture.Image.Save(memoryStream, pictureBoxProfilePicture.Image.RawFormat);
            //return memoryStream.GetBuffer();
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(pictureBoxTrainPicture.Image, typeof(byte[]));
        }
        private Image blobToImage(byte[] byteImage)
        {
            return new Bitmap(new MemoryStream(byteImage));
        }

        private void dataGridViewTrain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTrainName.Text = dataGridViewTrain.CurrentRow.Cells[0].Value.ToString();
            if (!Convert.IsDBNull(dataGridViewTrain.CurrentRow.Cells[1].Value))
            {
                pictureBoxTrainPicture.Image = blobToImage((byte[])dataGridViewTrain.CurrentRow.Cells[1].Value);
            }
            else
            {
                pictureBoxTrainPicture.Image = Properties.Resources.train;
            }
        }

        private void dataGridViewTrain_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxTrainName.Text = dataGridViewTrain.CurrentRow.Cells[0].Value.ToString();
            if (!Convert.IsDBNull(dataGridViewTrain.CurrentRow.Cells[1].Value))
            {
                pictureBoxTrainPicture.Image = blobToImage((byte[])dataGridViewTrain.CurrentRow.Cells[1].Value);
            }
            else
            {
                pictureBoxTrainPicture.Image = Properties.Resources.train;
            }
        }
    }
}
