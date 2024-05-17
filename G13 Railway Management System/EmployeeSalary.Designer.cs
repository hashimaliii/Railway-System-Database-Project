namespace G13_Railway_Management_System
{
    partial class EmployeeSalary
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
            this.labelSalaryRecord = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxTaskCount = new System.Windows.Forms.TextBox();
            this.labelTaskCount = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelSalaryYear = new System.Windows.Forms.Label();
            this.dataGridViewSalaryRecord = new System.Windows.Forms.DataGridView();
            this.pictureBoxFeedback = new System.Windows.Forms.PictureBox();
            this.labelPaidStatus = new System.Windows.Forms.Label();
            this.comboBoxPaidStatus = new System.Windows.Forms.ComboBox();
            this.textBoxSalaryYear = new System.Windows.Forms.TextBox();
            this.textBoxSalaryMonth = new System.Windows.Forms.TextBox();
            this.labelSalaryMonth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalaryRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSalaryRecord
            // 
            this.labelSalaryRecord.AutoSize = true;
            this.labelSalaryRecord.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalaryRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelSalaryRecord.Location = new System.Drawing.Point(310, 53);
            this.labelSalaryRecord.Name = "labelSalaryRecord";
            this.labelSalaryRecord.Size = new System.Drawing.Size(185, 42);
            this.labelSalaryRecord.TabIndex = 161;
            this.labelSalaryRecord.Text = "Salary Record";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(236, 170);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(152, 20);
            this.textBoxAmount.TabIndex = 159;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(287, 196);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 158;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxTaskCount
            // 
            this.textBoxTaskCount.Location = new System.Drawing.Point(394, 170);
            this.textBoxTaskCount.Name = "textBoxTaskCount";
            this.textBoxTaskCount.Size = new System.Drawing.Size(112, 20);
            this.textBoxTaskCount.TabIndex = 155;
            // 
            // labelTaskCount
            // 
            this.labelTaskCount.AutoSize = true;
            this.labelTaskCount.Location = new System.Drawing.Point(391, 154);
            this.labelTaskCount.Name = "labelTaskCount";
            this.labelTaskCount.Size = new System.Drawing.Size(85, 13);
            this.labelTaskCount.TabIndex = 154;
            this.labelTaskCount.Text = "Number Of Task";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(233, 153);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 150;
            this.labelAmount.Text = "Amount";
            // 
            // labelSalaryYear
            // 
            this.labelSalaryYear.AutoSize = true;
            this.labelSalaryYear.Location = new System.Drawing.Point(35, 154);
            this.labelSalaryYear.Name = "labelSalaryYear";
            this.labelSalaryYear.Size = new System.Drawing.Size(61, 13);
            this.labelSalaryYear.TabIndex = 148;
            this.labelSalaryYear.Text = "Salary Year";
            // 
            // dataGridViewSalaryRecord
            // 
            this.dataGridViewSalaryRecord.AllowUserToAddRows = false;
            this.dataGridViewSalaryRecord.AllowUserToDeleteRows = false;
            this.dataGridViewSalaryRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalaryRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSalaryRecord.Location = new System.Drawing.Point(38, 229);
            this.dataGridViewSalaryRecord.Name = "dataGridViewSalaryRecord";
            this.dataGridViewSalaryRecord.RowHeadersWidth = 51;
            this.dataGridViewSalaryRecord.Size = new System.Drawing.Size(597, 258);
            this.dataGridViewSalaryRecord.TabIndex = 145;
            this.dataGridViewSalaryRecord.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSalaryRecord_CellContentDoubleClick);
            this.dataGridViewSalaryRecord.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSalaryRecord_RowHeaderMouseDoubleClick);
            // 
            // pictureBoxFeedback
            // 
            this.pictureBoxFeedback.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.salary;
            this.pictureBoxFeedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFeedback.Location = new System.Drawing.Point(164, 23);
            this.pictureBoxFeedback.Name = "pictureBoxFeedback";
            this.pictureBoxFeedback.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxFeedback.TabIndex = 151;
            this.pictureBoxFeedback.TabStop = false;
            // 
            // labelPaidStatus
            // 
            this.labelPaidStatus.AutoSize = true;
            this.labelPaidStatus.Location = new System.Drawing.Point(509, 153);
            this.labelPaidStatus.Name = "labelPaidStatus";
            this.labelPaidStatus.Size = new System.Drawing.Size(61, 13);
            this.labelPaidStatus.TabIndex = 162;
            this.labelPaidStatus.Text = "Paid Status";
            // 
            // comboBoxPaidStatus
            // 
            this.comboBoxPaidStatus.FormattingEnabled = true;
            this.comboBoxPaidStatus.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.comboBoxPaidStatus.Location = new System.Drawing.Point(512, 170);
            this.comboBoxPaidStatus.Name = "comboBoxPaidStatus";
            this.comboBoxPaidStatus.Size = new System.Drawing.Size(123, 21);
            this.comboBoxPaidStatus.TabIndex = 163;
            // 
            // textBoxSalaryYear
            // 
            this.textBoxSalaryYear.Location = new System.Drawing.Point(38, 171);
            this.textBoxSalaryYear.MaxLength = 4;
            this.textBoxSalaryYear.Name = "textBoxSalaryYear";
            this.textBoxSalaryYear.Size = new System.Drawing.Size(92, 20);
            this.textBoxSalaryYear.TabIndex = 164;
            // 
            // textBoxSalaryMonth
            // 
            this.textBoxSalaryMonth.Location = new System.Drawing.Point(136, 170);
            this.textBoxSalaryMonth.MaxLength = 2;
            this.textBoxSalaryMonth.Name = "textBoxSalaryMonth";
            this.textBoxSalaryMonth.Size = new System.Drawing.Size(94, 20);
            this.textBoxSalaryMonth.TabIndex = 166;
            // 
            // labelSalaryMonth
            // 
            this.labelSalaryMonth.AutoSize = true;
            this.labelSalaryMonth.Location = new System.Drawing.Point(133, 153);
            this.labelSalaryMonth.Name = "labelSalaryMonth";
            this.labelSalaryMonth.Size = new System.Drawing.Size(69, 13);
            this.labelSalaryMonth.TabIndex = 165;
            this.labelSalaryMonth.Text = "Salary Month";
            // 
            // EmployeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.textBoxSalaryMonth);
            this.Controls.Add(this.labelSalaryMonth);
            this.Controls.Add(this.textBoxSalaryYear);
            this.Controls.Add(this.comboBoxPaidStatus);
            this.Controls.Add(this.labelPaidStatus);
            this.Controls.Add(this.labelSalaryRecord);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxTaskCount);
            this.Controls.Add(this.labelTaskCount);
            this.Controls.Add(this.pictureBoxFeedback);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelSalaryYear);
            this.Controls.Add(this.dataGridViewSalaryRecord);
            this.Name = "EmployeeSalary";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalaryRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSalaryRecord;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxTaskCount;
        private System.Windows.Forms.Label labelTaskCount;
        private System.Windows.Forms.PictureBox pictureBoxFeedback;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelSalaryYear;
        private System.Windows.Forms.DataGridView dataGridViewSalaryRecord;
        private System.Windows.Forms.Label labelPaidStatus;
        private System.Windows.Forms.ComboBox comboBoxPaidStatus;
        private System.Windows.Forms.TextBox textBoxSalaryYear;
        private System.Windows.Forms.TextBox textBoxSalaryMonth;
        private System.Windows.Forms.Label labelSalaryMonth;
    }
}
