namespace G13_Railway_Management_System
{
    partial class AdminRevenue
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
            this.labelRevenue = new System.Windows.Forms.Label();
            this.buttonCalculateRevenue = new System.Windows.Forms.Button();
            this.buttonAdminMakePDF = new System.Windows.Forms.Button();
            this.labelRevenueTo = new System.Windows.Forms.Label();
            this.labelRevenueFrom = new System.Windows.Forms.Label();
            this.dataGridViewRevenue = new System.Windows.Forms.DataGridView();
            this.pictureBoxRevenue = new System.Windows.Forms.PictureBox();
            this.dateTimePickerRevenueFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRevenueTo = new System.Windows.Forms.DateTimePicker();
            this.labelTotalRevenue = new System.Windows.Forms.Label();
            this.textBoxTotalRevenue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRevenue
            // 
            this.labelRevenue.AutoSize = true;
            this.labelRevenue.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelRevenue.Location = new System.Drawing.Point(340, 57);
            this.labelRevenue.Name = "labelRevenue";
            this.labelRevenue.Size = new System.Drawing.Size(116, 42);
            this.labelRevenue.TabIndex = 136;
            this.labelRevenue.Text = "Revenue";
            // 
            // buttonCalculateRevenue
            // 
            this.buttonCalculateRevenue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCalculateRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonCalculateRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCalculateRevenue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCalculateRevenue.Location = new System.Drawing.Point(194, 225);
            this.buttonCalculateRevenue.Name = "buttonCalculateRevenue";
            this.buttonCalculateRevenue.Size = new System.Drawing.Size(128, 27);
            this.buttonCalculateRevenue.TabIndex = 135;
            this.buttonCalculateRevenue.Text = "Calculate Revenue";
            this.buttonCalculateRevenue.UseVisualStyleBackColor = false;
            this.buttonCalculateRevenue.Click += new System.EventHandler(this.buttonCalculateRevenue_Click);
            // 
            // buttonAdminMakePDF
            // 
            this.buttonAdminMakePDF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAdminMakePDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonAdminMakePDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdminMakePDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdminMakePDF.Location = new System.Drawing.Point(328, 225);
            this.buttonAdminMakePDF.Name = "buttonAdminMakePDF";
            this.buttonAdminMakePDF.Size = new System.Drawing.Size(128, 27);
            this.buttonAdminMakePDF.TabIndex = 131;
            this.buttonAdminMakePDF.Text = "Make PDF";
            this.buttonAdminMakePDF.UseVisualStyleBackColor = false;
            this.buttonAdminMakePDF.Click += new System.EventHandler(this.buttonAdminMakePDF_Click);
            // 
            // labelRevenueTo
            // 
            this.labelRevenueTo.AutoSize = true;
            this.labelRevenueTo.Location = new System.Drawing.Point(325, 144);
            this.labelRevenueTo.Name = "labelRevenueTo";
            this.labelRevenueTo.Size = new System.Drawing.Size(67, 13);
            this.labelRevenueTo.TabIndex = 127;
            this.labelRevenueTo.Text = "Revenue To";
            // 
            // labelRevenueFrom
            // 
            this.labelRevenueFrom.AutoSize = true;
            this.labelRevenueFrom.Location = new System.Drawing.Point(120, 144);
            this.labelRevenueFrom.Name = "labelRevenueFrom";
            this.labelRevenueFrom.Size = new System.Drawing.Size(77, 13);
            this.labelRevenueFrom.TabIndex = 125;
            this.labelRevenueFrom.Text = "Revenue From";
            // 
            // dataGridViewRevenue
            // 
            this.dataGridViewRevenue.AllowUserToAddRows = false;
            this.dataGridViewRevenue.AllowUserToDeleteRows = false;
            this.dataGridViewRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRevenue.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRevenue.Location = new System.Drawing.Point(36, 258);
            this.dataGridViewRevenue.Name = "dataGridViewRevenue";
            this.dataGridViewRevenue.RowHeadersWidth = 51;
            this.dataGridViewRevenue.Size = new System.Drawing.Size(597, 229);
            this.dataGridViewRevenue.TabIndex = 124;
            // 
            // pictureBoxRevenue
            // 
            this.pictureBoxRevenue.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.revenue;
            this.pictureBoxRevenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxRevenue.Location = new System.Drawing.Point(194, 24);
            this.pictureBoxRevenue.Name = "pictureBoxRevenue";
            this.pictureBoxRevenue.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxRevenue.TabIndex = 134;
            this.pictureBoxRevenue.TabStop = false;
            // 
            // dateTimePickerRevenueFrom
            // 
            this.dateTimePickerRevenueFrom.Location = new System.Drawing.Point(123, 160);
            this.dateTimePickerRevenueFrom.Name = "dateTimePickerRevenueFrom";
            this.dateTimePickerRevenueFrom.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerRevenueFrom.TabIndex = 137;
            // 
            // dateTimePickerRevenueTo
            // 
            this.dateTimePickerRevenueTo.Location = new System.Drawing.Point(325, 160);
            this.dateTimePickerRevenueTo.Name = "dateTimePickerRevenueTo";
            this.dateTimePickerRevenueTo.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerRevenueTo.TabIndex = 138;
            // 
            // labelTotalRevenue
            // 
            this.labelTotalRevenue.AutoSize = true;
            this.labelTotalRevenue.Location = new System.Drawing.Point(281, 183);
            this.labelTotalRevenue.Name = "labelTotalRevenue";
            this.labelTotalRevenue.Size = new System.Drawing.Size(78, 13);
            this.labelTotalRevenue.TabIndex = 139;
            this.labelTotalRevenue.Text = "Total Revenue";
            // 
            // textBoxTotalRevenue
            // 
            this.textBoxTotalRevenue.Location = new System.Drawing.Point(270, 199);
            this.textBoxTotalRevenue.Name = "textBoxTotalRevenue";
            this.textBoxTotalRevenue.ReadOnly = true;
            this.textBoxTotalRevenue.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalRevenue.TabIndex = 140;
            this.textBoxTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdminRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.textBoxTotalRevenue);
            this.Controls.Add(this.labelTotalRevenue);
            this.Controls.Add(this.dateTimePickerRevenueTo);
            this.Controls.Add(this.dateTimePickerRevenueFrom);
            this.Controls.Add(this.labelRevenue);
            this.Controls.Add(this.buttonCalculateRevenue);
            this.Controls.Add(this.pictureBoxRevenue);
            this.Controls.Add(this.buttonAdminMakePDF);
            this.Controls.Add(this.labelRevenueTo);
            this.Controls.Add(this.labelRevenueFrom);
            this.Controls.Add(this.dataGridViewRevenue);
            this.Name = "AdminRevenue";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRevenue;
        private System.Windows.Forms.Button buttonCalculateRevenue;
        private System.Windows.Forms.PictureBox pictureBoxRevenue;
        private System.Windows.Forms.Button buttonAdminMakePDF;
        private System.Windows.Forms.Label labelRevenueTo;
        private System.Windows.Forms.Label labelRevenueFrom;
        private System.Windows.Forms.DataGridView dataGridViewRevenue;
        private System.Windows.Forms.DateTimePicker dateTimePickerRevenueFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerRevenueTo;
        private System.Windows.Forms.Label labelTotalRevenue;
        private System.Windows.Forms.TextBox textBoxTotalRevenue;
    }
}
