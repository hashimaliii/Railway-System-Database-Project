namespace G13_Railway_Management_System
{
    partial class PassengerCustomerSupport
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
            this.labelCustomerSupport = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxTaskDescription = new System.Windows.Forms.TextBox();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.labelTrainScheduleID = new System.Windows.Forms.Label();
            this.dataGridViewFeedback = new System.Windows.Forms.DataGridView();
            this.pictureBoxCustomerSupport = new System.Windows.Forms.PictureBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxScheduleID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomerSupport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCustomerSupport
            // 
            this.labelCustomerSupport.AutoSize = true;
            this.labelCustomerSupport.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerSupport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelCustomerSupport.Location = new System.Drawing.Point(300, 53);
            this.labelCustomerSupport.Name = "labelCustomerSupport";
            this.labelCustomerSupport.Size = new System.Drawing.Size(233, 42);
            this.labelCustomerSupport.TabIndex = 161;
            this.labelCustomerSupport.Text = "Customer Support";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(260, 206);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 157;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxTaskDescription
            // 
            this.textBoxTaskDescription.Location = new System.Drawing.Point(250, 179);
            this.textBoxTaskDescription.Multiline = true;
            this.textBoxTaskDescription.Name = "textBoxTaskDescription";
            this.textBoxTaskDescription.Size = new System.Drawing.Size(385, 21);
            this.textBoxTaskDescription.TabIndex = 156;
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(247, 163);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(60, 13);
            this.labelTaskDescription.TabIndex = 155;
            this.labelTaskDescription.Text = "Description";
            // 
            // labelTrainScheduleID
            // 
            this.labelTrainScheduleID.AutoSize = true;
            this.labelTrainScheduleID.Location = new System.Drawing.Point(35, 163);
            this.labelTrainScheduleID.Name = "labelTrainScheduleID";
            this.labelTrainScheduleID.Size = new System.Drawing.Size(66, 13);
            this.labelTrainScheduleID.TabIndex = 149;
            this.labelTrainScheduleID.Text = "Schedule ID";
            // 
            // dataGridViewFeedback
            // 
            this.dataGridViewFeedback.AllowUserToAddRows = false;
            this.dataGridViewFeedback.AllowUserToDeleteRows = false;
            this.dataGridViewFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFeedback.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFeedback.Location = new System.Drawing.Point(38, 239);
            this.dataGridViewFeedback.Name = "dataGridViewFeedback";
            this.dataGridViewFeedback.RowHeadersWidth = 51;
            this.dataGridViewFeedback.Size = new System.Drawing.Size(597, 248);
            this.dataGridViewFeedback.TabIndex = 144;
            this.dataGridViewFeedback.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFeedback_CellContentDoubleClick);
            this.dataGridViewFeedback.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFeedback_RowHeaderMouseDoubleClick);
            // 
            // pictureBoxCustomerSupport
            // 
            this.pictureBoxCustomerSupport.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.feedback;
            this.pictureBoxCustomerSupport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCustomerSupport.Location = new System.Drawing.Point(154, 23);
            this.pictureBoxCustomerSupport.Name = "pictureBoxCustomerSupport";
            this.pictureBoxCustomerSupport.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxCustomerSupport.TabIndex = 150;
            this.pictureBoxCustomerSupport.TabStop = false;
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPost.Location = new System.Drawing.Point(354, 206);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(88, 27);
            this.buttonPost.TabIndex = 162;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(141, 163);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 159;
            this.labelType.Text = "Type";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Inquiry",
            "Complaint",
            "Feedback"});
            this.comboBoxType.Location = new System.Drawing.Point(144, 179);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxType.TabIndex = 163;
            // 
            // comboBoxScheduleID
            // 
            this.comboBoxScheduleID.FormattingEnabled = true;
            this.comboBoxScheduleID.Location = new System.Drawing.Point(38, 179);
            this.comboBoxScheduleID.Name = "comboBoxScheduleID";
            this.comboBoxScheduleID.Size = new System.Drawing.Size(100, 21);
            this.comboBoxScheduleID.TabIndex = 164;
            // 
            // PassengerCustomerSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.comboBoxScheduleID);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.labelCustomerSupport);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxTaskDescription);
            this.Controls.Add(this.labelTaskDescription);
            this.Controls.Add(this.pictureBoxCustomerSupport);
            this.Controls.Add(this.labelTrainScheduleID);
            this.Controls.Add(this.dataGridViewFeedback);
            this.Name = "PassengerCustomerSupport";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomerSupport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerSupport;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxTaskDescription;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.PictureBox pictureBoxCustomerSupport;
        private System.Windows.Forms.Label labelTrainScheduleID;
        private System.Windows.Forms.DataGridView dataGridViewFeedback;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxScheduleID;
    }
}
