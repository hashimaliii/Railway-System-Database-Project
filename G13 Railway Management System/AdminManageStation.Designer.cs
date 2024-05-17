namespace G13_Railway_Management_System
{
    partial class AdminManageStation
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
            this.labelTaskManageStation = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxStationName = new System.Windows.Forms.TextBox();
            this.labelEmployeeStationName = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewManageStation = new System.Windows.Forms.DataGridView();
            this.pictureBoxManageStation = new System.Windows.Forms.PictureBox();
            this.textBoxStationCity = new System.Windows.Forms.TextBox();
            this.labelStationCity = new System.Windows.Forms.Label();
            this.textBoxStationCountry = new System.Windows.Forms.TextBox();
            this.labelStationCountry = new System.Windows.Forms.Label();
            this.textBoxStationNo = new System.Windows.Forms.TextBox();
            this.labelStationNo = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManageStation)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTaskManageStation
            // 
            this.labelTaskManageStation.AutoSize = true;
            this.labelTaskManageStation.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskManageStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelTaskManageStation.Location = new System.Drawing.Point(334, 54);
            this.labelTaskManageStation.Name = "labelTaskManageStation";
            this.labelTaskManageStation.Size = new System.Drawing.Size(195, 42);
            this.labelTaskManageStation.TabIndex = 138;
            this.labelTaskManageStation.Text = "Manage Station";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(146, 193);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 137;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxStationName
            // 
            this.textBoxStationName.Location = new System.Drawing.Point(189, 167);
            this.textBoxStationName.Name = "textBoxStationName";
            this.textBoxStationName.Size = new System.Drawing.Size(139, 20);
            this.textBoxStationName.TabIndex = 131;
            // 
            // labelEmployeeStationName
            // 
            this.labelEmployeeStationName.AutoSize = true;
            this.labelEmployeeStationName.Location = new System.Drawing.Point(186, 151);
            this.labelEmployeeStationName.Name = "labelEmployeeStationName";
            this.labelEmployeeStationName.Size = new System.Drawing.Size(71, 13);
            this.labelEmployeeStationName.TabIndex = 130;
            this.labelEmployeeStationName.Text = "Station Name";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(428, 193);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 27);
            this.buttonDelete.TabIndex = 128;
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
            this.buttonAdd.Location = new System.Drawing.Point(240, 193);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 27);
            this.buttonAdd.TabIndex = 127;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewManageStation
            // 
            this.dataGridViewManageStation.AllowUserToAddRows = false;
            this.dataGridViewManageStation.AllowUserToDeleteRows = false;
            this.dataGridViewManageStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageStation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewManageStation.Location = new System.Drawing.Point(37, 226);
            this.dataGridViewManageStation.Name = "dataGridViewManageStation";
            this.dataGridViewManageStation.RowHeadersWidth = 51;
            this.dataGridViewManageStation.Size = new System.Drawing.Size(597, 264);
            this.dataGridViewManageStation.TabIndex = 123;
            this.dataGridViewManageStation.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageStation_CellContentDoubleClick);
            this.dataGridViewManageStation.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewManageStation_RowHeaderMouseDoubleClick);
            // 
            // pictureBoxManageStation
            // 
            this.pictureBoxManageStation.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.train_station;
            this.pictureBoxManageStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxManageStation.Location = new System.Drawing.Point(189, 21);
            this.pictureBoxManageStation.Name = "pictureBoxManageStation";
            this.pictureBoxManageStation.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxManageStation.TabIndex = 129;
            this.pictureBoxManageStation.TabStop = false;
            // 
            // textBoxStationCity
            // 
            this.textBoxStationCity.Location = new System.Drawing.Point(337, 167);
            this.textBoxStationCity.Name = "textBoxStationCity";
            this.textBoxStationCity.Size = new System.Drawing.Size(139, 20);
            this.textBoxStationCity.TabIndex = 140;
            // 
            // labelStationCity
            // 
            this.labelStationCity.AutoSize = true;
            this.labelStationCity.Location = new System.Drawing.Point(334, 151);
            this.labelStationCity.Name = "labelStationCity";
            this.labelStationCity.Size = new System.Drawing.Size(60, 13);
            this.labelStationCity.TabIndex = 139;
            this.labelStationCity.Text = "Station City";
            // 
            // textBoxStationCountry
            // 
            this.textBoxStationCountry.Location = new System.Drawing.Point(482, 167);
            this.textBoxStationCountry.Name = "textBoxStationCountry";
            this.textBoxStationCountry.Size = new System.Drawing.Size(139, 20);
            this.textBoxStationCountry.TabIndex = 142;
            // 
            // labelStationCountry
            // 
            this.labelStationCountry.AutoSize = true;
            this.labelStationCountry.Location = new System.Drawing.Point(479, 151);
            this.labelStationCountry.Name = "labelStationCountry";
            this.labelStationCountry.Size = new System.Drawing.Size(79, 13);
            this.labelStationCountry.TabIndex = 141;
            this.labelStationCountry.Text = "Station Country";
            // 
            // textBoxStationNo
            // 
            this.textBoxStationNo.Location = new System.Drawing.Point(44, 167);
            this.textBoxStationNo.Name = "textBoxStationNo";
            this.textBoxStationNo.Size = new System.Drawing.Size(139, 20);
            this.textBoxStationNo.TabIndex = 144;
            // 
            // labelStationNo
            // 
            this.labelStationNo.AutoSize = true;
            this.labelStationNo.Location = new System.Drawing.Point(43, 151);
            this.labelStationNo.Name = "labelStationNo";
            this.labelStationNo.Size = new System.Drawing.Size(57, 13);
            this.labelStationNo.TabIndex = 143;
            this.labelStationNo.Text = "Station No";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(334, 193);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(88, 27);
            this.buttonUpdate.TabIndex = 145;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // AdminManageStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxStationNo);
            this.Controls.Add(this.labelStationNo);
            this.Controls.Add(this.textBoxStationCountry);
            this.Controls.Add(this.labelStationCountry);
            this.Controls.Add(this.textBoxStationCity);
            this.Controls.Add(this.labelStationCity);
            this.Controls.Add(this.labelTaskManageStation);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxStationName);
            this.Controls.Add(this.labelEmployeeStationName);
            this.Controls.Add(this.pictureBoxManageStation);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewManageStation);
            this.Name = "AdminManageStation";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManageStation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTaskManageStation;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxStationName;
        private System.Windows.Forms.Label labelEmployeeStationName;
        private System.Windows.Forms.PictureBox pictureBoxManageStation;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewManageStation;
        private System.Windows.Forms.TextBox textBoxStationCity;
        private System.Windows.Forms.Label labelStationCity;
        private System.Windows.Forms.TextBox textBoxStationCountry;
        private System.Windows.Forms.Label labelStationCountry;
        private System.Windows.Forms.TextBox textBoxStationNo;
        private System.Windows.Forms.Label labelStationNo;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
