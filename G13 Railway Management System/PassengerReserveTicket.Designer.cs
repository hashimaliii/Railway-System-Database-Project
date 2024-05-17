namespace G13_Railway_Management_System
{
    partial class PassengerReserveTicket
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
            this.labelReserveSeat = new System.Windows.Forms.Label();
            this.pictureBoxReserveSeat = new System.Windows.Forms.PictureBox();
            this.comboBoxClassType = new System.Windows.Forms.ComboBox();
            this.labelClassType = new System.Windows.Forms.Label();
            this.comboBoxSeatNo = new System.Windows.Forms.ComboBox();
            this.labelSeatNo = new System.Windows.Forms.Label();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxFare = new System.Windows.Forms.TextBox();
            this.labelFare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReserveSeat)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReserveSeat
            // 
            this.labelReserveSeat.AutoSize = true;
            this.labelReserveSeat.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReserveSeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelReserveSeat.Location = new System.Drawing.Point(312, 72);
            this.labelReserveSeat.Name = "labelReserveSeat";
            this.labelReserveSeat.Size = new System.Drawing.Size(174, 42);
            this.labelReserveSeat.TabIndex = 156;
            this.labelReserveSeat.Text = "Reserve Seat";
            // 
            // pictureBoxReserveSeat
            // 
            this.pictureBoxReserveSeat.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.trainseat;
            this.pictureBoxReserveSeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxReserveSeat.Location = new System.Drawing.Point(166, 42);
            this.pictureBoxReserveSeat.Name = "pictureBoxReserveSeat";
            this.pictureBoxReserveSeat.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxReserveSeat.TabIndex = 155;
            this.pictureBoxReserveSeat.TabStop = false;
            // 
            // comboBoxClassType
            // 
            this.comboBoxClassType.FormattingEnabled = true;
            this.comboBoxClassType.Location = new System.Drawing.Point(283, 244);
            this.comboBoxClassType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxClassType.Name = "comboBoxClassType";
            this.comboBoxClassType.Size = new System.Drawing.Size(110, 21);
            this.comboBoxClassType.TabIndex = 169;
            this.comboBoxClassType.SelectedIndexChanged += new System.EventHandler(this.comboBoxClassType_SelectedIndexChanged);
            // 
            // labelClassType
            // 
            this.labelClassType.AutoSize = true;
            this.labelClassType.Location = new System.Drawing.Point(281, 228);
            this.labelClassType.Name = "labelClassType";
            this.labelClassType.Size = new System.Drawing.Size(59, 13);
            this.labelClassType.TabIndex = 168;
            this.labelClassType.Text = "Class Type";
            // 
            // comboBoxSeatNo
            // 
            this.comboBoxSeatNo.FormattingEnabled = true;
            this.comboBoxSeatNo.Location = new System.Drawing.Point(167, 244);
            this.comboBoxSeatNo.Name = "comboBoxSeatNo";
            this.comboBoxSeatNo.Size = new System.Drawing.Size(110, 21);
            this.comboBoxSeatNo.TabIndex = 167;
            // 
            // labelSeatNo
            // 
            this.labelSeatNo.AutoSize = true;
            this.labelSeatNo.Location = new System.Drawing.Point(164, 228);
            this.labelSeatNo.Name = "labelSeatNo";
            this.labelSeatNo.Size = new System.Drawing.Size(46, 13);
            this.labelSeatNo.TabIndex = 166;
            this.labelSeatNo.Text = "Seat No";
            // 
            // buttonBook
            // 
            this.buttonBook.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBook.Location = new System.Drawing.Point(293, 270);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(88, 27);
            this.buttonBook.TabIndex = 170;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = false;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Location = new System.Drawing.Point(17, 42);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(88, 27);
            this.buttonBack.TabIndex = 172;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxFare
            // 
            this.textBoxFare.Location = new System.Drawing.Point(397, 245);
            this.textBoxFare.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFare.Name = "textBoxFare";
            this.textBoxFare.ReadOnly = true;
            this.textBoxFare.Size = new System.Drawing.Size(110, 20);
            this.textBoxFare.TabIndex = 173;
            // 
            // labelFare
            // 
            this.labelFare.AutoSize = true;
            this.labelFare.Location = new System.Drawing.Point(394, 228);
            this.labelFare.Name = "labelFare";
            this.labelFare.Size = new System.Drawing.Size(28, 13);
            this.labelFare.TabIndex = 174;
            this.labelFare.Text = "Fare";
            // 
            // PassengerReserveseTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.labelFare);
            this.Controls.Add(this.textBoxFare);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.comboBoxClassType);
            this.Controls.Add(this.labelClassType);
            this.Controls.Add(this.comboBoxSeatNo);
            this.Controls.Add(this.labelSeatNo);
            this.Controls.Add(this.labelReserveSeat);
            this.Controls.Add(this.pictureBoxReserveSeat);
            this.Name = "PassengerReserveseTicket";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReserveSeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReserveSeat;
        private System.Windows.Forms.PictureBox pictureBoxReserveSeat;
        private System.Windows.Forms.ComboBox comboBoxClassType;
        private System.Windows.Forms.Label labelClassType;
        private System.Windows.Forms.ComboBox comboBoxSeatNo;
        private System.Windows.Forms.Label labelSeatNo;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxFare;
        private System.Windows.Forms.Label labelFare;
    }
}
