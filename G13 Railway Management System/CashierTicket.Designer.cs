namespace G13_Railway_Management_System
{
    partial class CashierTicket
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
            this.labelSellSeat = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdminUpdate = new System.Windows.Forms.Button();
            this.labelTicketID = new System.Windows.Forms.Label();
            this.dataGridViewSeat = new System.Windows.Forms.DataGridView();
            this.pictureBoxTrainSeat = new System.Windows.Forms.PictureBox();
            this.labelSoldStatus = new System.Windows.Forms.Label();
            this.comboBoxSoldStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxTicketID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainSeat)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSellSeat
            // 
            this.labelSellSeat.AutoSize = true;
            this.labelSellSeat.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSellSeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelSellSeat.Location = new System.Drawing.Point(319, 52);
            this.labelSellSeat.Name = "labelSellSeat";
            this.labelSellSeat.Size = new System.Drawing.Size(119, 42);
            this.labelSellSeat.TabIndex = 175;
            this.labelSellSeat.Text = "Sell Seat";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(183, 195);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 172;
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
            this.buttonDelete.Location = new System.Drawing.Point(371, 195);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 27);
            this.buttonDelete.TabIndex = 167;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdminUpdate
            // 
            this.buttonAdminUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAdminUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonAdminUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdminUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdminUpdate.Location = new System.Drawing.Point(277, 195);
            this.buttonAdminUpdate.Name = "buttonAdminUpdate";
            this.buttonAdminUpdate.Size = new System.Drawing.Size(88, 27);
            this.buttonAdminUpdate.TabIndex = 165;
            this.buttonAdminUpdate.Text = "Update";
            this.buttonAdminUpdate.UseVisualStyleBackColor = false;
            this.buttonAdminUpdate.Click += new System.EventHandler(this.buttonAdminUpdate_Click);
            // 
            // labelTicketID
            // 
            this.labelTicketID.AutoSize = true;
            this.labelTicketID.Location = new System.Drawing.Point(180, 152);
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
            this.dataGridViewSeat.Location = new System.Drawing.Point(36, 228);
            this.dataGridViewSeat.Name = "dataGridViewSeat";
            this.dataGridViewSeat.RowHeadersWidth = 51;
            this.dataGridViewSeat.Size = new System.Drawing.Size(597, 260);
            this.dataGridViewSeat.TabIndex = 156;
            this.dataGridViewSeat.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeat_CellContentDoubleClick);
            this.dataGridViewSeat.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSeat_RowHeaderMouseDoubleClick);
            // 
            // pictureBoxTrainSeat
            // 
            this.pictureBoxTrainSeat.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.trainseat;
            this.pictureBoxTrainSeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTrainSeat.Location = new System.Drawing.Point(173, 22);
            this.pictureBoxTrainSeat.Name = "pictureBoxTrainSeat";
            this.pictureBoxTrainSeat.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxTrainSeat.TabIndex = 155;
            this.pictureBoxTrainSeat.TabStop = false;
            // 
            // labelSoldStatus
            // 
            this.labelSoldStatus.AutoSize = true;
            this.labelSoldStatus.Location = new System.Drawing.Point(319, 152);
            this.labelSoldStatus.Name = "labelSoldStatus";
            this.labelSoldStatus.Size = new System.Drawing.Size(61, 13);
            this.labelSoldStatus.TabIndex = 178;
            this.labelSoldStatus.Text = "Sold Status";
            // 
            // comboBoxSoldStatus
            // 
            this.comboBoxSoldStatus.FormattingEnabled = true;
            this.comboBoxSoldStatus.Items.AddRange(new object[] {
            "Sold",
            "Not Sold"});
            this.comboBoxSoldStatus.Location = new System.Drawing.Point(322, 168);
            this.comboBoxSoldStatus.Name = "comboBoxSoldStatus";
            this.comboBoxSoldStatus.Size = new System.Drawing.Size(137, 21);
            this.comboBoxSoldStatus.TabIndex = 179;
            // 
            // comboBoxTicketID
            // 
            this.comboBoxTicketID.FormattingEnabled = true;
            this.comboBoxTicketID.Location = new System.Drawing.Point(183, 168);
            this.comboBoxTicketID.Name = "comboBoxTicketID";
            this.comboBoxTicketID.Size = new System.Drawing.Size(133, 21);
            this.comboBoxTicketID.TabIndex = 180;
            // 
            // CashierTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.comboBoxTicketID);
            this.Controls.Add(this.comboBoxSoldStatus);
            this.Controls.Add(this.labelSoldStatus);
            this.Controls.Add(this.labelSellSeat);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdminUpdate);
            this.Controls.Add(this.labelTicketID);
            this.Controls.Add(this.dataGridViewSeat);
            this.Controls.Add(this.pictureBoxTrainSeat);
            this.Name = "CashierTicket";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainSeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSellSeat;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdminUpdate;
        private System.Windows.Forms.Label labelTicketID;
        private System.Windows.Forms.DataGridView dataGridViewSeat;
        private System.Windows.Forms.PictureBox pictureBoxTrainSeat;
        private System.Windows.Forms.Label labelSoldStatus;
        private System.Windows.Forms.ComboBox comboBoxSoldStatus;
        private System.Windows.Forms.ComboBox comboBoxTicketID;
    }
}
