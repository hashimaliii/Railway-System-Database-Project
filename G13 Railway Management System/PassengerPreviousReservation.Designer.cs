namespace G13_Railway_Management_System
{
    partial class PassengerPreviousReservation
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
            this.labelPreviousReservation = new System.Windows.Forms.Label();
            this.labelSeatDate = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSeatRouteName = new System.Windows.Forms.Label();
            this.labelSeatToRoute = new System.Windows.Forms.Label();
            this.labelSeatFromRoute = new System.Windows.Forms.Label();
            this.labelTicketID = new System.Windows.Forms.Label();
            this.dataGridViewSeat = new System.Windows.Forms.DataGridView();
            this.pictureBoxPreviousReservation = new System.Windows.Forms.PictureBox();
            this.comboBoxClassType = new System.Windows.Forms.ComboBox();
            this.labelCkassType = new System.Windows.Forms.Label();
            this.comboBoxTicketID = new System.Windows.Forms.ComboBox();
            this.comboBoxFromStation = new System.Windows.Forms.ComboBox();
            this.comboBoxToStation = new System.Windows.Forms.ComboBox();
            this.comboBoxRouteName = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartureDate = new System.Windows.Forms.ComboBox();
            this.comboBoxBookingDate = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelBookingDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviousReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPreviousReservation
            // 
            this.labelPreviousReservation.AutoSize = true;
            this.labelPreviousReservation.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreviousReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelPreviousReservation.Location = new System.Drawing.Point(290, 52);
            this.labelPreviousReservation.Name = "labelPreviousReservation";
            this.labelPreviousReservation.Size = new System.Drawing.Size(267, 42);
            this.labelPreviousReservation.TabIndex = 175;
            this.labelPreviousReservation.Text = "Previous Reservation";
            // 
            // labelSeatDate
            // 
            this.labelSeatDate.AutoSize = true;
            this.labelSeatDate.Location = new System.Drawing.Point(179, 191);
            this.labelSeatDate.Name = "labelSeatDate";
            this.labelSeatDate.Size = new System.Drawing.Size(80, 13);
            this.labelSeatDate.TabIndex = 174;
            this.labelSeatDate.Text = "Departure Date";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(263, 234);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 172;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSeatRouteName
            // 
            this.labelSeatRouteName.AutoSize = true;
            this.labelSeatRouteName.Location = new System.Drawing.Point(176, 148);
            this.labelSeatRouteName.Name = "labelSeatRouteName";
            this.labelSeatRouteName.Size = new System.Drawing.Size(67, 13);
            this.labelSeatRouteName.TabIndex = 170;
            this.labelSeatRouteName.Text = "Route Name";
            // 
            // labelSeatToRoute
            // 
            this.labelSeatToRoute.AutoSize = true;
            this.labelSeatToRoute.Location = new System.Drawing.Point(416, 148);
            this.labelSeatToRoute.Name = "labelSeatToRoute";
            this.labelSeatToRoute.Size = new System.Drawing.Size(56, 13);
            this.labelSeatToRoute.TabIndex = 168;
            this.labelSeatToRoute.Text = "To Station";
            // 
            // labelSeatFromRoute
            // 
            this.labelSeatFromRoute.AutoSize = true;
            this.labelSeatFromRoute.Location = new System.Drawing.Point(285, 148);
            this.labelSeatFromRoute.Name = "labelSeatFromRoute";
            this.labelSeatFromRoute.Size = new System.Drawing.Size(66, 13);
            this.labelSeatFromRoute.TabIndex = 161;
            this.labelSeatFromRoute.Text = "From Station";
            // 
            // labelTicketID
            // 
            this.labelTicketID.AutoSize = true;
            this.labelTicketID.Location = new System.Drawing.Point(33, 149);
            this.labelTicketID.Name = "labelTicketID";
            this.labelTicketID.Size = new System.Drawing.Size(51, 13);
            this.labelTicketID.TabIndex = 157;
            this.labelTicketID.Text = "Ticket ID";
            // 
            // dataGridViewSeat
            // 
            this.dataGridViewSeat.AllowUserToAddRows = false;
            this.dataGridViewSeat.AllowUserToDeleteRows = false;
            this.dataGridViewSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSeat.Location = new System.Drawing.Point(36, 267);
            this.dataGridViewSeat.Name = "dataGridViewSeat";
            this.dataGridViewSeat.RowHeadersWidth = 51;
            this.dataGridViewSeat.Size = new System.Drawing.Size(597, 221);
            this.dataGridViewSeat.TabIndex = 156;
            this.dataGridViewSeat.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeat_CellContentDoubleClick);
            this.dataGridViewSeat.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSeat_RowHeaderMouseDoubleClick);
            // 
            // pictureBoxPreviousReservation
            // 
            this.pictureBoxPreviousReservation.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.trainseat;
            this.pictureBoxPreviousReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPreviousReservation.Location = new System.Drawing.Point(144, 22);
            this.pictureBoxPreviousReservation.Name = "pictureBoxPreviousReservation";
            this.pictureBoxPreviousReservation.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxPreviousReservation.TabIndex = 155;
            this.pictureBoxPreviousReservation.TabStop = false;
            // 
            // comboBoxClassType
            // 
            this.comboBoxClassType.FormattingEnabled = true;
            this.comboBoxClassType.Location = new System.Drawing.Point(544, 165);
            this.comboBoxClassType.Name = "comboBoxClassType";
            this.comboBoxClassType.Size = new System.Drawing.Size(89, 21);
            this.comboBoxClassType.TabIndex = 177;
            // 
            // labelCkassType
            // 
            this.labelCkassType.AutoSize = true;
            this.labelCkassType.Location = new System.Drawing.Point(542, 149);
            this.labelCkassType.Name = "labelCkassType";
            this.labelCkassType.Size = new System.Drawing.Size(59, 13);
            this.labelCkassType.TabIndex = 176;
            this.labelCkassType.Text = "Class Type";
            // 
            // comboBoxTicketID
            // 
            this.comboBoxTicketID.FormattingEnabled = true;
            this.comboBoxTicketID.Location = new System.Drawing.Point(36, 165);
            this.comboBoxTicketID.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTicketID.Name = "comboBoxTicketID";
            this.comboBoxTicketID.Size = new System.Drawing.Size(139, 21);
            this.comboBoxTicketID.TabIndex = 178;
            // 
            // comboBoxFromStation
            // 
            this.comboBoxFromStation.FormattingEnabled = true;
            this.comboBoxFromStation.Location = new System.Drawing.Point(287, 165);
            this.comboBoxFromStation.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFromStation.Name = "comboBoxFromStation";
            this.comboBoxFromStation.Size = new System.Drawing.Size(127, 21);
            this.comboBoxFromStation.TabIndex = 179;
            // 
            // comboBoxToStation
            // 
            this.comboBoxToStation.FormattingEnabled = true;
            this.comboBoxToStation.Location = new System.Drawing.Point(418, 164);
            this.comboBoxToStation.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxToStation.Name = "comboBoxToStation";
            this.comboBoxToStation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxToStation.TabIndex = 180;
            // 
            // comboBoxRouteName
            // 
            this.comboBoxRouteName.FormattingEnabled = true;
            this.comboBoxRouteName.Location = new System.Drawing.Point(179, 165);
            this.comboBoxRouteName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRouteName.Name = "comboBoxRouteName";
            this.comboBoxRouteName.Size = new System.Drawing.Size(105, 21);
            this.comboBoxRouteName.TabIndex = 181;
            // 
            // comboBoxDepartureDate
            // 
            this.comboBoxDepartureDate.FormattingEnabled = true;
            this.comboBoxDepartureDate.Location = new System.Drawing.Point(181, 208);
            this.comboBoxDepartureDate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDepartureDate.Name = "comboBoxDepartureDate";
            this.comboBoxDepartureDate.Size = new System.Drawing.Size(139, 21);
            this.comboBoxDepartureDate.TabIndex = 182;
            // 
            // comboBoxBookingDate
            // 
            this.comboBoxBookingDate.FormattingEnabled = true;
            this.comboBoxBookingDate.Location = new System.Drawing.Point(36, 208);
            this.comboBoxBookingDate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBookingDate.Name = "comboBoxBookingDate";
            this.comboBoxBookingDate.Size = new System.Drawing.Size(139, 21);
            this.comboBoxBookingDate.TabIndex = 183;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(357, 234);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 27);
            this.buttonCancel.TabIndex = 184;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelBookingDate
            // 
            this.labelBookingDate.AutoSize = true;
            this.labelBookingDate.Location = new System.Drawing.Point(33, 193);
            this.labelBookingDate.Name = "labelBookingDate";
            this.labelBookingDate.Size = new System.Drawing.Size(72, 13);
            this.labelBookingDate.TabIndex = 185;
            this.labelBookingDate.Text = "Booking Date";
            // 
            // PassengerPreviousReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.labelBookingDate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxBookingDate);
            this.Controls.Add(this.comboBoxDepartureDate);
            this.Controls.Add(this.comboBoxRouteName);
            this.Controls.Add(this.comboBoxToStation);
            this.Controls.Add(this.comboBoxFromStation);
            this.Controls.Add(this.comboBoxTicketID);
            this.Controls.Add(this.comboBoxClassType);
            this.Controls.Add(this.labelCkassType);
            this.Controls.Add(this.labelPreviousReservation);
            this.Controls.Add(this.labelSeatDate);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSeatRouteName);
            this.Controls.Add(this.labelSeatToRoute);
            this.Controls.Add(this.labelSeatFromRoute);
            this.Controls.Add(this.labelTicketID);
            this.Controls.Add(this.dataGridViewSeat);
            this.Controls.Add(this.pictureBoxPreviousReservation);
            this.Name = "PassengerPreviousReservation";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviousReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPreviousReservation;
        private System.Windows.Forms.Label labelSeatDate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSeatRouteName;
        private System.Windows.Forms.Label labelSeatToRoute;
        private System.Windows.Forms.Label labelSeatFromRoute;
        private System.Windows.Forms.Label labelTicketID;
        private System.Windows.Forms.DataGridView dataGridViewSeat;
        private System.Windows.Forms.PictureBox pictureBoxPreviousReservation;
        private System.Windows.Forms.ComboBox comboBoxClassType;
        private System.Windows.Forms.Label labelCkassType;
        private System.Windows.Forms.ComboBox comboBoxTicketID;
        private System.Windows.Forms.ComboBox comboBoxFromStation;
        private System.Windows.Forms.ComboBox comboBoxToStation;
        private System.Windows.Forms.ComboBox comboBoxRouteName;
        private System.Windows.Forms.ComboBox comboBoxDepartureDate;
        private System.Windows.Forms.ComboBox comboBoxBookingDate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelBookingDate;
    }
}
