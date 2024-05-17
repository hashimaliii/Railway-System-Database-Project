namespace G13_Railway_Management_System
{
    partial class AdminManageStop
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
            this.textBoxDepartureTime = new System.Windows.Forms.TextBox();
            this.labelDepartureTime = new System.Windows.Forms.Label();
            this.textBoxArrivalTime = new System.Windows.Forms.TextBox();
            this.labelArrivalTime = new System.Windows.Forms.Label();
            this.labelTaskManageStop = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewManageStop = new System.Windows.Forms.DataGridView();
            this.pictureBoxManageStop = new System.Windows.Forms.PictureBox();
            this.labelStationNo = new System.Windows.Forms.Label();
            this.labelRouteName = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxStationNo = new System.Windows.Forms.ComboBox();
            this.comboBoxRouteName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManageStop)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDepartureTime
            // 
            this.textBoxDepartureTime.Location = new System.Drawing.Point(313, 163);
            this.textBoxDepartureTime.Name = "textBoxDepartureTime";
            this.textBoxDepartureTime.Size = new System.Drawing.Size(157, 20);
            this.textBoxDepartureTime.TabIndex = 154;
            // 
            // labelDepartureTime
            // 
            this.labelDepartureTime.AutoSize = true;
            this.labelDepartureTime.Location = new System.Drawing.Point(310, 147);
            this.labelDepartureTime.Name = "labelDepartureTime";
            this.labelDepartureTime.Size = new System.Drawing.Size(80, 13);
            this.labelDepartureTime.TabIndex = 153;
            this.labelDepartureTime.Text = "Departure Time";
            // 
            // textBoxArrivalTime
            // 
            this.textBoxArrivalTime.Location = new System.Drawing.Point(476, 164);
            this.textBoxArrivalTime.Name = "textBoxArrivalTime";
            this.textBoxArrivalTime.Size = new System.Drawing.Size(157, 20);
            this.textBoxArrivalTime.TabIndex = 152;
            // 
            // labelArrivalTime
            // 
            this.labelArrivalTime.AutoSize = true;
            this.labelArrivalTime.Location = new System.Drawing.Point(473, 148);
            this.labelArrivalTime.Name = "labelArrivalTime";
            this.labelArrivalTime.Size = new System.Drawing.Size(62, 13);
            this.labelArrivalTime.TabIndex = 151;
            this.labelArrivalTime.Text = "Arrival Time";
            // 
            // labelTaskManageStop
            // 
            this.labelTaskManageStop.AutoSize = true;
            this.labelTaskManageStop.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskManageStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelTaskManageStop.Location = new System.Drawing.Point(325, 54);
            this.labelTaskManageStop.Name = "labelTaskManageStop";
            this.labelTaskManageStop.Size = new System.Drawing.Size(167, 42);
            this.labelTaskManageStop.TabIndex = 150;
            this.labelTaskManageStop.Text = "Manage Stop";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(155, 189);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 149;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(436, 189);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 27);
            this.buttonDelete.TabIndex = 145;
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
            this.buttonAdd.Location = new System.Drawing.Point(249, 189);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 27);
            this.buttonAdd.TabIndex = 144;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewManageStop
            // 
            this.dataGridViewManageStop.AllowUserToAddRows = false;
            this.dataGridViewManageStop.AllowUserToDeleteRows = false;
            this.dataGridViewManageStop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageStop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewManageStop.Location = new System.Drawing.Point(36, 222);
            this.dataGridViewManageStop.Name = "dataGridViewManageStop";
            this.dataGridViewManageStop.RowHeadersWidth = 51;
            this.dataGridViewManageStop.Size = new System.Drawing.Size(597, 268);
            this.dataGridViewManageStop.TabIndex = 143;
            this.dataGridViewManageStop.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageStop_CellContentDoubleClick);
            this.dataGridViewManageStop.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewManageStop_RowHeaderMouseDoubleClick);
            // 
            // pictureBoxManageStop
            // 
            this.pictureBoxManageStop.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.trainstop;
            this.pictureBoxManageStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxManageStop.Location = new System.Drawing.Point(180, 21);
            this.pictureBoxManageStop.Name = "pictureBoxManageStop";
            this.pictureBoxManageStop.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxManageStop.TabIndex = 146;
            this.pictureBoxManageStop.TabStop = false;
            // 
            // labelStationNo
            // 
            this.labelStationNo.AutoSize = true;
            this.labelStationNo.Location = new System.Drawing.Point(169, 148);
            this.labelStationNo.Name = "labelStationNo";
            this.labelStationNo.Size = new System.Drawing.Size(54, 13);
            this.labelStationNo.TabIndex = 157;
            this.labelStationNo.Text = "StationNo";
            // 
            // labelRouteName
            // 
            this.labelRouteName.AutoSize = true;
            this.labelRouteName.Location = new System.Drawing.Point(33, 147);
            this.labelRouteName.Name = "labelRouteName";
            this.labelRouteName.Size = new System.Drawing.Size(67, 13);
            this.labelRouteName.TabIndex = 155;
            this.labelRouteName.Text = "Route Name";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(343, 189);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(88, 27);
            this.buttonUpdate.TabIndex = 159;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxStationNo
            // 
            this.comboBoxStationNo.FormattingEnabled = true;
            this.comboBoxStationNo.Location = new System.Drawing.Point(172, 163);
            this.comboBoxStationNo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStationNo.Name = "comboBoxStationNo";
            this.comboBoxStationNo.Size = new System.Drawing.Size(136, 21);
            this.comboBoxStationNo.TabIndex = 160;
            // 
            // comboBoxRouteName
            // 
            this.comboBoxRouteName.FormattingEnabled = true;
            this.comboBoxRouteName.Location = new System.Drawing.Point(35, 163);
            this.comboBoxRouteName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRouteName.Name = "comboBoxRouteName";
            this.comboBoxRouteName.Size = new System.Drawing.Size(133, 21);
            this.comboBoxRouteName.TabIndex = 161;
            // 
            // AdminManageStop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.comboBoxRouteName);
            this.Controls.Add(this.comboBoxStationNo);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelStationNo);
            this.Controls.Add(this.labelRouteName);
            this.Controls.Add(this.textBoxDepartureTime);
            this.Controls.Add(this.labelDepartureTime);
            this.Controls.Add(this.textBoxArrivalTime);
            this.Controls.Add(this.labelArrivalTime);
            this.Controls.Add(this.labelTaskManageStop);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.pictureBoxManageStop);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewManageStop);
            this.Name = "AdminManageStop";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManageStop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDepartureTime;
        private System.Windows.Forms.Label labelDepartureTime;
        private System.Windows.Forms.TextBox textBoxArrivalTime;
        private System.Windows.Forms.Label labelArrivalTime;
        private System.Windows.Forms.Label labelTaskManageStop;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBoxManageStop;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewManageStop;
        private System.Windows.Forms.Label labelStationNo;
        private System.Windows.Forms.Label labelRouteName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxStationNo;
        private System.Windows.Forms.ComboBox comboBoxRouteName;
    }
}
