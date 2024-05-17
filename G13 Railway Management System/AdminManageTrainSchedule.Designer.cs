namespace G13_Railway_Management_System
{
    partial class AdminManageTrainSchedule
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAdminUpdate = new System.Windows.Forms.Button();
            this.labelTrainName = new System.Windows.Forms.Label();
            this.dataGridViewManageTrainSchedule = new System.Windows.Forms.DataGridView();
            this.comboBoxScheduleStatus = new System.Windows.Forms.ComboBox();
            this.labelTrainStatus = new System.Windows.Forms.Label();
            this.labelTrainRouteName = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureBoxAdminUser = new System.Windows.Forms.PictureBox();
            this.labelTrainSchedule = new System.Windows.Forms.Label();
            this.labelSeatDate = new System.Windows.Forms.Label();
            this.labelScheduleName = new System.Windows.Forms.Label();
            this.textBoxBaseFare = new System.Windows.Forms.TextBox();
            this.comboBoxScheduleName = new System.Windows.Forms.ComboBox();
            this.comboBoxRouteName = new System.Windows.Forms.ComboBox();
            this.comboBoxTrainName = new System.Windows.Forms.ComboBox();
            this.labelBaseFare = new System.Windows.Forms.Label();
            this.textBoxDepartureDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTrainSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminUser)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(436, 220);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 27);
            this.buttonDelete.TabIndex = 85;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(342, 220);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 27);
            this.buttonAdd.TabIndex = 84;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAdminUpdate
            // 
            this.buttonAdminUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAdminUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonAdminUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdminUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdminUpdate.Location = new System.Drawing.Point(248, 220);
            this.buttonAdminUpdate.Name = "buttonAdminUpdate";
            this.buttonAdminUpdate.Size = new System.Drawing.Size(88, 27);
            this.buttonAdminUpdate.TabIndex = 83;
            this.buttonAdminUpdate.Text = "Update";
            this.buttonAdminUpdate.UseVisualStyleBackColor = false;
            this.buttonAdminUpdate.Click += new System.EventHandler(this.buttonAdminUpdate_Click);
            // 
            // labelTrainName
            // 
            this.labelTrainName.AutoSize = true;
            this.labelTrainName.Location = new System.Drawing.Point(33, 140);
            this.labelTrainName.Name = "labelTrainName";
            this.labelTrainName.Size = new System.Drawing.Size(62, 13);
            this.labelTrainName.TabIndex = 61;
            this.labelTrainName.Text = "Train Name";
            // 
            // dataGridViewManageTrainSchedule
            // 
            this.dataGridViewManageTrainSchedule.AllowUserToAddRows = false;
            this.dataGridViewManageTrainSchedule.AllowUserToDeleteRows = false;
            this.dataGridViewManageTrainSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageTrainSchedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewManageTrainSchedule.Location = new System.Drawing.Point(36, 253);
            this.dataGridViewManageTrainSchedule.Name = "dataGridViewManageTrainSchedule";
            this.dataGridViewManageTrainSchedule.RowHeadersWidth = 51;
            this.dataGridViewManageTrainSchedule.Size = new System.Drawing.Size(597, 225);
            this.dataGridViewManageTrainSchedule.TabIndex = 60;
            this.dataGridViewManageTrainSchedule.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageTrainSchedule_CellContentDoubleClick);
            this.dataGridViewManageTrainSchedule.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewManageTrainSchedule_RowHeaderMouseDoubleClick);
            // 
            // comboBoxScheduleStatus
            // 
            this.comboBoxScheduleStatus.FormattingEnabled = true;
            this.comboBoxScheduleStatus.Items.AddRange(new object[] {
            "On Time",
            "Delayed",
            "Cancelled"});
            this.comboBoxScheduleStatus.Location = new System.Drawing.Point(410, 156);
            this.comboBoxScheduleStatus.Name = "comboBoxScheduleStatus";
            this.comboBoxScheduleStatus.Size = new System.Drawing.Size(109, 21);
            this.comboBoxScheduleStatus.TabIndex = 86;
            // 
            // labelTrainStatus
            // 
            this.labelTrainStatus.AutoSize = true;
            this.labelTrainStatus.Location = new System.Drawing.Point(407, 140);
            this.labelTrainStatus.Name = "labelTrainStatus";
            this.labelTrainStatus.Size = new System.Drawing.Size(37, 13);
            this.labelTrainStatus.TabIndex = 87;
            this.labelTrainStatus.Text = "Status";
            // 
            // labelTrainRouteName
            // 
            this.labelTrainRouteName.AutoSize = true;
            this.labelTrainRouteName.Location = new System.Drawing.Point(292, 140);
            this.labelTrainRouteName.Name = "labelTrainRouteName";
            this.labelTrainRouteName.Size = new System.Drawing.Size(67, 13);
            this.labelTrainRouteName.TabIndex = 90;
            this.labelTrainRouteName.Text = "Route Name";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(154, 220);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 122;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // pictureBoxAdminUser
            // 
            this.pictureBoxAdminUser.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.schedulemanagement;
            this.pictureBoxAdminUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAdminUser.Location = new System.Drawing.Point(202, 19);
            this.pictureBoxAdminUser.Name = "pictureBoxAdminUser";
            this.pictureBoxAdminUser.Size = new System.Drawing.Size(95, 82);
            this.pictureBoxAdminUser.TabIndex = 123;
            this.pictureBoxAdminUser.TabStop = false;
            // 
            // labelTrainSchedule
            // 
            this.labelTrainSchedule.AutoSize = true;
            this.labelTrainSchedule.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelTrainSchedule.Location = new System.Drawing.Point(313, 37);
            this.labelTrainSchedule.Name = "labelTrainSchedule";
            this.labelTrainSchedule.Size = new System.Drawing.Size(190, 42);
            this.labelTrainSchedule.TabIndex = 124;
            this.labelTrainSchedule.Text = "Train Schedule";
            // 
            // labelSeatDate
            // 
            this.labelSeatDate.AutoSize = true;
            this.labelSeatDate.Location = new System.Drawing.Point(33, 178);
            this.labelSeatDate.Name = "labelSeatDate";
            this.labelSeatDate.Size = new System.Drawing.Size(80, 13);
            this.labelSeatDate.TabIndex = 155;
            this.labelSeatDate.Text = "Departure Date";
            // 
            // labelScheduleName
            // 
            this.labelScheduleName.AutoSize = true;
            this.labelScheduleName.Location = new System.Drawing.Point(178, 140);
            this.labelScheduleName.Name = "labelScheduleName";
            this.labelScheduleName.Size = new System.Drawing.Size(83, 13);
            this.labelScheduleName.TabIndex = 156;
            this.labelScheduleName.Text = "Schedule Name";
            // 
            // textBoxBaseFare
            // 
            this.textBoxBaseFare.Location = new System.Drawing.Point(524, 156);
            this.textBoxBaseFare.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBaseFare.Name = "textBoxBaseFare";
            this.textBoxBaseFare.Size = new System.Drawing.Size(109, 20);
            this.textBoxBaseFare.TabIndex = 161;
            // 
            // comboBoxScheduleName
            // 
            this.comboBoxScheduleName.FormattingEnabled = true;
            this.comboBoxScheduleName.Location = new System.Drawing.Point(181, 155);
            this.comboBoxScheduleName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxScheduleName.Name = "comboBoxScheduleName";
            this.comboBoxScheduleName.Size = new System.Drawing.Size(109, 21);
            this.comboBoxScheduleName.TabIndex = 162;
            // 
            // comboBoxRouteName
            // 
            this.comboBoxRouteName.FormattingEnabled = true;
            this.comboBoxRouteName.Location = new System.Drawing.Point(295, 156);
            this.comboBoxRouteName.Name = "comboBoxRouteName";
            this.comboBoxRouteName.Size = new System.Drawing.Size(109, 21);
            this.comboBoxRouteName.TabIndex = 163;
            // 
            // comboBoxTrainName
            // 
            this.comboBoxTrainName.FormattingEnabled = true;
            this.comboBoxTrainName.Location = new System.Drawing.Point(36, 155);
            this.comboBoxTrainName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTrainName.Name = "comboBoxTrainName";
            this.comboBoxTrainName.Size = new System.Drawing.Size(141, 21);
            this.comboBoxTrainName.TabIndex = 164;
            // 
            // labelBaseFare
            // 
            this.labelBaseFare.AutoSize = true;
            this.labelBaseFare.Location = new System.Drawing.Point(521, 140);
            this.labelBaseFare.Name = "labelBaseFare";
            this.labelBaseFare.Size = new System.Drawing.Size(55, 13);
            this.labelBaseFare.TabIndex = 165;
            this.labelBaseFare.Text = "Base Fare";
            // 
            // textBoxDepartureDate
            // 
            this.textBoxDepartureDate.Location = new System.Drawing.Point(36, 193);
            this.textBoxDepartureDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDepartureDate.Name = "textBoxDepartureDate";
            this.textBoxDepartureDate.Size = new System.Drawing.Size(141, 20);
            this.textBoxDepartureDate.TabIndex = 166;
            // 
            // AdminManageTrainSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.textBoxDepartureDate);
            this.Controls.Add(this.labelBaseFare);
            this.Controls.Add(this.comboBoxTrainName);
            this.Controls.Add(this.comboBoxRouteName);
            this.Controls.Add(this.comboBoxScheduleName);
            this.Controls.Add(this.textBoxBaseFare);
            this.Controls.Add(this.labelScheduleName);
            this.Controls.Add(this.labelSeatDate);
            this.Controls.Add(this.labelTrainSchedule);
            this.Controls.Add(this.pictureBoxAdminUser);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelTrainRouteName);
            this.Controls.Add(this.labelTrainStatus);
            this.Controls.Add(this.comboBoxScheduleStatus);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonAdminUpdate);
            this.Controls.Add(this.labelTrainName);
            this.Controls.Add(this.dataGridViewManageTrainSchedule);
            this.Name = "AdminManageTrainSchedule";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTrainSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAdminUpdate;
        private System.Windows.Forms.Label labelTrainName;
        private System.Windows.Forms.DataGridView dataGridViewManageTrainSchedule;
        private System.Windows.Forms.ComboBox comboBoxScheduleStatus;
        private System.Windows.Forms.Label labelTrainStatus;
        private System.Windows.Forms.Label labelTrainRouteName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBoxAdminUser;
        private System.Windows.Forms.Label labelTrainSchedule;
        private System.Windows.Forms.Label labelSeatDate;
        private System.Windows.Forms.Label labelScheduleName;
        private System.Windows.Forms.TextBox textBoxBaseFare;
        private System.Windows.Forms.ComboBox comboBoxScheduleName;
        private System.Windows.Forms.ComboBox comboBoxRouteName;
        private System.Windows.Forms.ComboBox comboBoxTrainName;
        private System.Windows.Forms.Label labelBaseFare;
        private System.Windows.Forms.TextBox textBoxDepartureDate;
    }
}
