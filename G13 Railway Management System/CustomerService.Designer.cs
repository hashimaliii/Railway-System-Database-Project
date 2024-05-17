namespace G13_Railway_Management_System
{
    partial class CustomerService
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
            this.labelTrainScheduleID = new System.Windows.Forms.Label();
            this.dataGridViewCustomerService = new System.Windows.Forms.DataGridView();
            this.labelType = new System.Windows.Forms.Label();
            this.labelCustomerService = new System.Windows.Forms.Label();
            this.pictureBoxFeedback = new System.Windows.Forms.PictureBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.labelResponse = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.comboBoxScheduleID = new System.Windows.Forms.ComboBox();
            this.labelServiceID = new System.Windows.Forms.Label();
            this.buttonPending = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTrainScheduleID
            // 
            this.labelTrainScheduleID.AutoSize = true;
            this.labelTrainScheduleID.Location = new System.Drawing.Point(141, 157);
            this.labelTrainScheduleID.Name = "labelTrainScheduleID";
            this.labelTrainScheduleID.Size = new System.Drawing.Size(66, 13);
            this.labelTrainScheduleID.TabIndex = 127;
            this.labelTrainScheduleID.Text = "Schedule ID";
            // 
            // dataGridViewCustomerService
            // 
            this.dataGridViewCustomerService.AllowUserToAddRows = false;
            this.dataGridViewCustomerService.AllowUserToDeleteRows = false;
            this.dataGridViewCustomerService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerService.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCustomerService.Location = new System.Drawing.Point(38, 233);
            this.dataGridViewCustomerService.Name = "dataGridViewCustomerService";
            this.dataGridViewCustomerService.RowHeadersWidth = 51;
            this.dataGridViewCustomerService.Size = new System.Drawing.Size(597, 254);
            this.dataGridViewCustomerService.TabIndex = 122;
            this.dataGridViewCustomerService.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomerService_CellContentDoubleClick);
            this.dataGridViewCustomerService.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCustomerService_RowHeaderMouseDoubleClick);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(247, 157);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 141;
            this.labelType.Text = "Type";
            // 
            // labelCustomerService
            // 
            this.labelCustomerService.AutoSize = true;
            this.labelCustomerService.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelCustomerService.Location = new System.Drawing.Point(298, 53);
            this.labelCustomerService.Name = "labelCustomerService";
            this.labelCustomerService.Size = new System.Drawing.Size(229, 42);
            this.labelCustomerService.TabIndex = 143;
            this.labelCustomerService.Text = "Customer Service";
            // 
            // pictureBoxFeedback
            // 
            this.pictureBoxFeedback.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.feedback;
            this.pictureBoxFeedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFeedback.Location = new System.Drawing.Point(152, 23);
            this.pictureBoxFeedback.Name = "pictureBoxFeedback";
            this.pictureBoxFeedback.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxFeedback.TabIndex = 131;
            this.pictureBoxFeedback.TabStop = false;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Inquiry",
            "Complaint",
            "Feedback"});
            this.comboBoxType.Location = new System.Drawing.Point(250, 173);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxType.TabIndex = 144;
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(356, 171);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(279, 23);
            this.textBoxResponse.TabIndex = 171;
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Location = new System.Drawing.Point(353, 157);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(55, 13);
            this.labelResponse.TabIndex = 170;
            this.labelResponse.Text = "Response";
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPost.Location = new System.Drawing.Point(399, 200);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(88, 27);
            this.buttonPost.TabIndex = 169;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(305, 200);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 168;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(38, 173);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(100, 21);
            this.comboBoxID.TabIndex = 172;
            // 
            // comboBoxScheduleID
            // 
            this.comboBoxScheduleID.FormattingEnabled = true;
            this.comboBoxScheduleID.Location = new System.Drawing.Point(144, 173);
            this.comboBoxScheduleID.Name = "comboBoxScheduleID";
            this.comboBoxScheduleID.Size = new System.Drawing.Size(100, 21);
            this.comboBoxScheduleID.TabIndex = 173;
            // 
            // labelServiceID
            // 
            this.labelServiceID.AutoSize = true;
            this.labelServiceID.Location = new System.Drawing.Point(35, 157);
            this.labelServiceID.Name = "labelServiceID";
            this.labelServiceID.Size = new System.Drawing.Size(57, 13);
            this.labelServiceID.TabIndex = 174;
            this.labelServiceID.Text = "Service ID";
            // 
            // buttonPending
            // 
            this.buttonPending.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonPending.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPending.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPending.Location = new System.Drawing.Point(211, 200);
            this.buttonPending.Name = "buttonPending";
            this.buttonPending.Size = new System.Drawing.Size(88, 27);
            this.buttonPending.TabIndex = 175;
            this.buttonPending.Text = "Pending";
            this.buttonPending.UseVisualStyleBackColor = false;
            this.buttonPending.Click += new System.EventHandler(this.buttonPending_Click);
            // 
            // CustomerService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.buttonPending);
            this.Controls.Add(this.labelServiceID);
            this.Controls.Add(this.comboBoxScheduleID);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelCustomerService);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.pictureBoxFeedback);
            this.Controls.Add(this.labelTrainScheduleID);
            this.Controls.Add(this.dataGridViewCustomerService);
            this.Name = "CustomerService";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxFeedback;
        private System.Windows.Forms.Label labelTrainScheduleID;
        private System.Windows.Forms.DataGridView dataGridViewCustomerService;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelCustomerService;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.Label labelResponse;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.ComboBox comboBoxScheduleID;
        private System.Windows.Forms.Label labelServiceID;
        private System.Windows.Forms.Button buttonPending;
    }
}
