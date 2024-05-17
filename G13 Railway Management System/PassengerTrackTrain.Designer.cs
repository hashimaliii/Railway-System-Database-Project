namespace G13_Railway_Management_System
{
    partial class PassengerTrackTrain
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
            this.labelTrainSchedule = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTrainRoute = new System.Windows.Forms.Label();
            this.labelTrainToRoute = new System.Windows.Forms.Label();
            this.labelTrainStatus = new System.Windows.Forms.Label();
            this.comboBoxTrainStatus = new System.Windows.Forms.ComboBox();
            this.labelTrainFromRoute = new System.Windows.Forms.Label();
            this.dataGridViewTrainSchedule = new System.Windows.Forms.DataGridView();
            this.labelTrainName = new System.Windows.Forms.Label();
            this.comboBoxTrainName = new System.Windows.Forms.ComboBox();
            this.comboBoxFromStation = new System.Windows.Forms.ComboBox();
            this.comboBoxToStation = new System.Windows.Forms.ComboBox();
            this.comboBoxRoute = new System.Windows.Forms.ComboBox();
            this.pictureBoxTrainPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTrainSchedule
            // 
            this.labelTrainSchedule.AutoSize = true;
            this.labelTrainSchedule.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelTrainSchedule.Location = new System.Drawing.Point(313, 44);
            this.labelTrainSchedule.Name = "labelTrainSchedule";
            this.labelTrainSchedule.Size = new System.Drawing.Size(150, 42);
            this.labelTrainSchedule.TabIndex = 145;
            this.labelTrainSchedule.Text = "Track Train";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(289, 169);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 143;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelTrainRoute
            // 
            this.labelTrainRoute.AutoSize = true;
            this.labelTrainRoute.Location = new System.Drawing.Point(524, 127);
            this.labelTrainRoute.Name = "labelTrainRoute";
            this.labelTrainRoute.Size = new System.Drawing.Size(36, 13);
            this.labelTrainRoute.TabIndex = 141;
            this.labelTrainRoute.Text = "Route";
            // 
            // labelTrainToRoute
            // 
            this.labelTrainToRoute.AutoSize = true;
            this.labelTrainToRoute.Location = new System.Drawing.Point(286, 127);
            this.labelTrainToRoute.Name = "labelTrainToRoute";
            this.labelTrainToRoute.Size = new System.Drawing.Size(20, 13);
            this.labelTrainToRoute.TabIndex = 139;
            this.labelTrainToRoute.Text = "To";
            // 
            // labelTrainStatus
            // 
            this.labelTrainStatus.AutoSize = true;
            this.labelTrainStatus.Location = new System.Drawing.Point(406, 127);
            this.labelTrainStatus.Name = "labelTrainStatus";
            this.labelTrainStatus.Size = new System.Drawing.Size(37, 13);
            this.labelTrainStatus.TabIndex = 138;
            this.labelTrainStatus.Text = "Status";
            // 
            // comboBoxTrainStatus
            // 
            this.comboBoxTrainStatus.FormattingEnabled = true;
            this.comboBoxTrainStatus.Location = new System.Drawing.Point(409, 143);
            this.comboBoxTrainStatus.Name = "comboBoxTrainStatus";
            this.comboBoxTrainStatus.Size = new System.Drawing.Size(113, 21);
            this.comboBoxTrainStatus.TabIndex = 137;
            // 
            // labelTrainFromRoute
            // 
            this.labelTrainFromRoute.AutoSize = true;
            this.labelTrainFromRoute.Location = new System.Drawing.Point(169, 127);
            this.labelTrainFromRoute.Name = "labelTrainFromRoute";
            this.labelTrainFromRoute.Size = new System.Drawing.Size(30, 13);
            this.labelTrainFromRoute.TabIndex = 130;
            this.labelTrainFromRoute.Text = "From";
            // 
            // dataGridViewTrainSchedule
            // 
            this.dataGridViewTrainSchedule.AllowUserToAddRows = false;
            this.dataGridViewTrainSchedule.AllowUserToDeleteRows = false;
            this.dataGridViewTrainSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainSchedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTrainSchedule.Location = new System.Drawing.Point(36, 201);
            this.dataGridViewTrainSchedule.Name = "dataGridViewTrainSchedule";
            this.dataGridViewTrainSchedule.RowHeadersWidth = 51;
            this.dataGridViewTrainSchedule.Size = new System.Drawing.Size(597, 284);
            this.dataGridViewTrainSchedule.TabIndex = 125;
            this.dataGridViewTrainSchedule.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrainSchedule_CellContentDoubleClick);
            this.dataGridViewTrainSchedule.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTrainSchedule_RowHeaderMouseDoubleClick);
            // 
            // labelTrainName
            // 
            this.labelTrainName.AutoSize = true;
            this.labelTrainName.Location = new System.Drawing.Point(34, 127);
            this.labelTrainName.Name = "labelTrainName";
            this.labelTrainName.Size = new System.Drawing.Size(62, 13);
            this.labelTrainName.TabIndex = 146;
            this.labelTrainName.Text = "Train Name";
            // 
            // comboBoxTrainName
            // 
            this.comboBoxTrainName.FormattingEnabled = true;
            this.comboBoxTrainName.Location = new System.Drawing.Point(36, 143);
            this.comboBoxTrainName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTrainName.Name = "comboBoxTrainName";
            this.comboBoxTrainName.Size = new System.Drawing.Size(132, 21);
            this.comboBoxTrainName.TabIndex = 150;
            // 
            // comboBoxFromStation
            // 
            this.comboBoxFromStation.FormattingEnabled = true;
            this.comboBoxFromStation.Location = new System.Drawing.Point(172, 143);
            this.comboBoxFromStation.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFromStation.Name = "comboBoxFromStation";
            this.comboBoxFromStation.Size = new System.Drawing.Size(113, 21);
            this.comboBoxFromStation.TabIndex = 151;
            // 
            // comboBoxToStation
            // 
            this.comboBoxToStation.FormattingEnabled = true;
            this.comboBoxToStation.Location = new System.Drawing.Point(289, 143);
            this.comboBoxToStation.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxToStation.Name = "comboBoxToStation";
            this.comboBoxToStation.Size = new System.Drawing.Size(115, 21);
            this.comboBoxToStation.TabIndex = 152;
            // 
            // comboBoxRoute
            // 
            this.comboBoxRoute.FormattingEnabled = true;
            this.comboBoxRoute.Location = new System.Drawing.Point(527, 143);
            this.comboBoxRoute.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRoute.Name = "comboBoxRoute";
            this.comboBoxRoute.Size = new System.Drawing.Size(106, 21);
            this.comboBoxRoute.TabIndex = 153;
            // 
            // pictureBoxTrainPicture
            // 
            this.pictureBoxTrainPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTrainPicture.Image = global::G13_Railway_Management_System.Properties.Resources.train;
            this.pictureBoxTrainPicture.Location = new System.Drawing.Point(202, 26);
            this.pictureBoxTrainPicture.Name = "pictureBoxTrainPicture";
            this.pictureBoxTrainPicture.Size = new System.Drawing.Size(95, 82);
            this.pictureBoxTrainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTrainPicture.TabIndex = 144;
            this.pictureBoxTrainPicture.TabStop = false;
            // 
            // PassengerTrackTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.comboBoxRoute);
            this.Controls.Add(this.comboBoxToStation);
            this.Controls.Add(this.comboBoxFromStation);
            this.Controls.Add(this.comboBoxTrainName);
            this.Controls.Add(this.labelTrainName);
            this.Controls.Add(this.labelTrainSchedule);
            this.Controls.Add(this.pictureBoxTrainPicture);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelTrainRoute);
            this.Controls.Add(this.labelTrainToRoute);
            this.Controls.Add(this.labelTrainStatus);
            this.Controls.Add(this.comboBoxTrainStatus);
            this.Controls.Add(this.labelTrainFromRoute);
            this.Controls.Add(this.dataGridViewTrainSchedule);
            this.Name = "PassengerTrackTrain";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTrainSchedule;
        private System.Windows.Forms.PictureBox pictureBoxTrainPicture;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelTrainRoute;
        private System.Windows.Forms.Label labelTrainToRoute;
        private System.Windows.Forms.Label labelTrainStatus;
        private System.Windows.Forms.ComboBox comboBoxTrainStatus;
        private System.Windows.Forms.Label labelTrainFromRoute;
        private System.Windows.Forms.DataGridView dataGridViewTrainSchedule;
        private System.Windows.Forms.Label labelTrainName;
        private System.Windows.Forms.ComboBox comboBoxTrainName;
        private System.Windows.Forms.ComboBox comboBoxFromStation;
        private System.Windows.Forms.ComboBox comboBoxToStation;
        private System.Windows.Forms.ComboBox comboBoxRoute;
    }
}
