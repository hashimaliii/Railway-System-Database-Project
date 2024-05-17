namespace G13_Railway_Management_System
{
    partial class PassengerBookSeat
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxTrainSeat = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSeatArrivalStation = new System.Windows.Forms.Label();
            this.labelSeatDepartureTime = new System.Windows.Forms.Label();
            this.labelSeatDepartureStation = new System.Windows.Forms.Label();
            this.labelSeatArrivalTime = new System.Windows.Forms.Label();
            this.dataGridViewSeat = new System.Windows.Forms.DataGridView();
            this.labelSeatDate = new System.Windows.Forms.Label();
            this.labelBookSeat = new System.Windows.Forms.Label();
            this.labelScheduleStatus = new System.Windows.Forms.Label();
            this.comboBoxDepartureDate = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartureStation = new System.Windows.Forms.ComboBox();
            this.comboBoxArrivalStations = new System.Windows.Forms.ComboBox();
            this.comboBoxArrivalTime = new System.Windows.Forms.ComboBox();
            this.comboBoxDepatureTime = new System.Windows.Forms.ComboBox();
            this.comboBoxScheduleStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTrainSeat
            // 
            this.pictureBoxTrainSeat.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.trainseat;
            this.pictureBoxTrainSeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTrainSeat.Location = new System.Drawing.Point(173, 16);
            this.pictureBoxTrainSeat.Name = "pictureBoxTrainSeat";
            this.pictureBoxTrainSeat.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxTrainSeat.TabIndex = 132;
            this.pictureBoxTrainSeat.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(281, 202);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 151;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSeatArrivalStation
            // 
            this.labelSeatArrivalStation.AutoSize = true;
            this.labelSeatArrivalStation.Location = new System.Drawing.Point(130, 159);
            this.labelSeatArrivalStation.Name = "labelSeatArrivalStation";
            this.labelSeatArrivalStation.Size = new System.Drawing.Size(72, 13);
            this.labelSeatArrivalStation.TabIndex = 147;
            this.labelSeatArrivalStation.Text = "Arrival Station";
            // 
            // labelSeatDepartureTime
            // 
            this.labelSeatDepartureTime.AutoSize = true;
            this.labelSeatDepartureTime.Location = new System.Drawing.Point(225, 159);
            this.labelSeatDepartureTime.Name = "labelSeatDepartureTime";
            this.labelSeatDepartureTime.Size = new System.Drawing.Size(80, 13);
            this.labelSeatDepartureTime.TabIndex = 140;
            this.labelSeatDepartureTime.Text = "Departure Time";
            // 
            // labelSeatDepartureStation
            // 
            this.labelSeatDepartureStation.AutoSize = true;
            this.labelSeatDepartureStation.Location = new System.Drawing.Point(34, 159);
            this.labelSeatDepartureStation.Name = "labelSeatDepartureStation";
            this.labelSeatDepartureStation.Size = new System.Drawing.Size(90, 13);
            this.labelSeatDepartureStation.TabIndex = 138;
            this.labelSeatDepartureStation.Text = "Departure Station";
            // 
            // labelSeatArrivalTime
            // 
            this.labelSeatArrivalTime.AutoSize = true;
            this.labelSeatArrivalTime.Location = new System.Drawing.Point(323, 159);
            this.labelSeatArrivalTime.Name = "labelSeatArrivalTime";
            this.labelSeatArrivalTime.Size = new System.Drawing.Size(62, 13);
            this.labelSeatArrivalTime.TabIndex = 136;
            this.labelSeatArrivalTime.Text = "Arrival Time";
            // 
            // dataGridViewSeat
            // 
            this.dataGridViewSeat.AllowUserToAddRows = false;
            this.dataGridViewSeat.AllowUserToDeleteRows = false;
            this.dataGridViewSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSeat.Location = new System.Drawing.Point(36, 235);
            this.dataGridViewSeat.Name = "dataGridViewSeat";
            this.dataGridViewSeat.RowHeadersWidth = 51;
            this.dataGridViewSeat.Size = new System.Drawing.Size(597, 247);
            this.dataGridViewSeat.TabIndex = 133;
            this.dataGridViewSeat.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeat_CellContentDoubleClick);
            this.dataGridViewSeat.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSeat_RowHeaderMouseDoubleClick);
            // 
            // labelSeatDate
            // 
            this.labelSeatDate.AutoSize = true;
            this.labelSeatDate.Location = new System.Drawing.Point(513, 159);
            this.labelSeatDate.Name = "labelSeatDate";
            this.labelSeatDate.Size = new System.Drawing.Size(80, 13);
            this.labelSeatDate.TabIndex = 153;
            this.labelSeatDate.Text = "Departure Date";
            // 
            // labelBookSeat
            // 
            this.labelBookSeat.AutoSize = true;
            this.labelBookSeat.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookSeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelBookSeat.Location = new System.Drawing.Point(319, 46);
            this.labelBookSeat.Name = "labelBookSeat";
            this.labelBookSeat.Size = new System.Drawing.Size(134, 42);
            this.labelBookSeat.TabIndex = 154;
            this.labelBookSeat.Text = "Book Seat";
            // 
            // labelScheduleStatus
            // 
            this.labelScheduleStatus.AutoSize = true;
            this.labelScheduleStatus.Location = new System.Drawing.Point(418, 160);
            this.labelScheduleStatus.Name = "labelScheduleStatus";
            this.labelScheduleStatus.Size = new System.Drawing.Size(85, 13);
            this.labelScheduleStatus.TabIndex = 157;
            this.labelScheduleStatus.Text = "Schedule Status";
            // 
            // comboBoxDepartureDate
            // 
            this.comboBoxDepartureDate.FormattingEnabled = true;
            this.comboBoxDepartureDate.Location = new System.Drawing.Point(516, 176);
            this.comboBoxDepartureDate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDepartureDate.Name = "comboBoxDepartureDate";
            this.comboBoxDepartureDate.Size = new System.Drawing.Size(117, 21);
            this.comboBoxDepartureDate.TabIndex = 159;
            // 
            // comboBoxDepartureStation
            // 
            this.comboBoxDepartureStation.FormattingEnabled = true;
            this.comboBoxDepartureStation.Location = new System.Drawing.Point(36, 176);
            this.comboBoxDepartureStation.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDepartureStation.Name = "comboBoxDepartureStation";
            this.comboBoxDepartureStation.Size = new System.Drawing.Size(92, 21);
            this.comboBoxDepartureStation.TabIndex = 161;
            // 
            // comboBoxArrivalStations
            // 
            this.comboBoxArrivalStations.FormattingEnabled = true;
            this.comboBoxArrivalStations.Location = new System.Drawing.Point(132, 176);
            this.comboBoxArrivalStations.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxArrivalStations.Name = "comboBoxArrivalStations";
            this.comboBoxArrivalStations.Size = new System.Drawing.Size(92, 21);
            this.comboBoxArrivalStations.TabIndex = 162;
            // 
            // comboBoxArrivalTime
            // 
            this.comboBoxArrivalTime.FormattingEnabled = true;
            this.comboBoxArrivalTime.Location = new System.Drawing.Point(324, 176);
            this.comboBoxArrivalTime.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxArrivalTime.Name = "comboBoxArrivalTime";
            this.comboBoxArrivalTime.Size = new System.Drawing.Size(92, 21);
            this.comboBoxArrivalTime.TabIndex = 163;
            // 
            // comboBoxDepatureTime
            // 
            this.comboBoxDepatureTime.FormattingEnabled = true;
            this.comboBoxDepatureTime.Location = new System.Drawing.Point(228, 176);
            this.comboBoxDepatureTime.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDepatureTime.Name = "comboBoxDepatureTime";
            this.comboBoxDepatureTime.Size = new System.Drawing.Size(92, 21);
            this.comboBoxDepatureTime.TabIndex = 164;
            // 
            // comboBoxScheduleStatus
            // 
            this.comboBoxScheduleStatus.FormattingEnabled = true;
            this.comboBoxScheduleStatus.Location = new System.Drawing.Point(420, 176);
            this.comboBoxScheduleStatus.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxScheduleStatus.Name = "comboBoxScheduleStatus";
            this.comboBoxScheduleStatus.Size = new System.Drawing.Size(92, 21);
            this.comboBoxScheduleStatus.TabIndex = 165;
            // 
            // PassengerBookSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.comboBoxScheduleStatus);
            this.Controls.Add(this.comboBoxDepatureTime);
            this.Controls.Add(this.comboBoxArrivalTime);
            this.Controls.Add(this.comboBoxArrivalStations);
            this.Controls.Add(this.comboBoxDepartureStation);
            this.Controls.Add(this.comboBoxDepartureDate);
            this.Controls.Add(this.labelScheduleStatus);
            this.Controls.Add(this.labelBookSeat);
            this.Controls.Add(this.labelSeatDate);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSeatArrivalStation);
            this.Controls.Add(this.labelSeatDepartureTime);
            this.Controls.Add(this.labelSeatDepartureStation);
            this.Controls.Add(this.labelSeatArrivalTime);
            this.Controls.Add(this.dataGridViewSeat);
            this.Controls.Add(this.pictureBoxTrainSeat);
            this.Name = "PassengerBookSeat";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTrainSeat;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSeatArrivalStation;
        private System.Windows.Forms.Label labelSeatDepartureTime;
        private System.Windows.Forms.Label labelSeatDepartureStation;
        private System.Windows.Forms.Label labelSeatArrivalTime;
        private System.Windows.Forms.DataGridView dataGridViewSeat;
        private System.Windows.Forms.Label labelSeatDate;
        private System.Windows.Forms.Label labelBookSeat;
        private System.Windows.Forms.Label labelScheduleStatus;
        private System.Windows.Forms.ComboBox comboBoxDepartureDate;
        private System.Windows.Forms.ComboBox comboBoxDepartureStation;
        private System.Windows.Forms.ComboBox comboBoxArrivalStations;
        private System.Windows.Forms.ComboBox comboBoxArrivalTime;
        private System.Windows.Forms.ComboBox comboBoxDepatureTime;
        private System.Windows.Forms.ComboBox comboBoxScheduleStatus;
    }
}
