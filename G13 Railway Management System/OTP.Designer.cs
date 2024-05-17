namespace G13_Railway_Management_System
{
    partial class OTP
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTP));
            this.buttonChangeEmail = new System.Windows.Forms.Button();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.textBoxOTP = new System.Windows.Forms.TextBox();
            this.labelEnterOTP = new System.Windows.Forms.Label();
            this.pictureBoxTrainStation = new System.Windows.Forms.PictureBox();
            this.labelOTP = new System.Windows.Forms.Label();
            this.buttonSendOTP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainStation)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangeEmail
            // 
            this.buttonChangeEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChangeEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChangeEmail.Location = new System.Drawing.Point(103, 234);
            this.buttonChangeEmail.Name = "buttonChangeEmail";
            this.buttonChangeEmail.Size = new System.Drawing.Size(86, 25);
            this.buttonChangeEmail.TabIndex = 54;
            this.buttonChangeEmail.Text = "Change Email";
            this.buttonChangeEmail.UseVisualStyleBackColor = false;
            this.buttonChangeEmail.Click += new System.EventHandler(this.buttonChangeEmail_Click);
            // 
            // buttonVerify
            // 
            this.buttonVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonVerify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVerify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVerify.Location = new System.Drawing.Point(267, 234);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(67, 25);
            this.buttonVerify.TabIndex = 53;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.UseVisualStyleBackColor = false;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // textBoxOTP
            // 
            this.textBoxOTP.Location = new System.Drawing.Point(103, 208);
            this.textBoxOTP.Name = "textBoxOTP";
            this.textBoxOTP.Size = new System.Drawing.Size(231, 20);
            this.textBoxOTP.TabIndex = 55;
            // 
            // labelEnterOTP
            // 
            this.labelEnterOTP.AutoSize = true;
            this.labelEnterOTP.Location = new System.Drawing.Point(100, 192);
            this.labelEnterOTP.Name = "labelEnterOTP";
            this.labelEnterOTP.Size = new System.Drawing.Size(57, 13);
            this.labelEnterOTP.TabIndex = 56;
            this.labelEnterOTP.Text = "Enter OTP";
            // 
            // pictureBoxTrainStation
            // 
            this.pictureBoxTrainStation.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.trainstation;
            this.pictureBoxTrainStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTrainStation.Location = new System.Drawing.Point(123, 41);
            this.pictureBoxTrainStation.Name = "pictureBoxTrainStation";
            this.pictureBoxTrainStation.Size = new System.Drawing.Size(119, 105);
            this.pictureBoxTrainStation.TabIndex = 57;
            this.pictureBoxTrainStation.TabStop = false;
            // 
            // labelOTP
            // 
            this.labelOTP.AutoSize = true;
            this.labelOTP.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelOTP.Location = new System.Drawing.Point(248, 67);
            this.labelOTP.Name = "labelOTP";
            this.labelOTP.Size = new System.Drawing.Size(62, 42);
            this.labelOTP.TabIndex = 58;
            this.labelOTP.Text = "OTP";
            // 
            // buttonSendOTP
            // 
            this.buttonSendOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSendOTP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSendOTP.Location = new System.Drawing.Point(195, 234);
            this.buttonSendOTP.Name = "buttonSendOTP";
            this.buttonSendOTP.Size = new System.Drawing.Size(66, 25);
            this.buttonSendOTP.TabIndex = 59;
            this.buttonSendOTP.Text = "Send OTP";
            this.buttonSendOTP.UseVisualStyleBackColor = false;
            this.buttonSendOTP.Click += new System.EventHandler(this.buttonSendOTP_Click);
            // 
            // OTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(422, 320);
            this.Controls.Add(this.buttonSendOTP);
            this.Controls.Add(this.labelOTP);
            this.Controls.Add(this.pictureBoxTrainStation);
            this.Controls.Add(this.labelEnterOTP);
            this.Controls.Add(this.textBoxOTP);
            this.Controls.Add(this.buttonChangeEmail);
            this.Controls.Add(this.buttonVerify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OTP";
            this.Text = "OTP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainStation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeEmail;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.TextBox textBoxOTP;
        private System.Windows.Forms.Label labelEnterOTP;
        private System.Windows.Forms.PictureBox pictureBoxTrainStation;
        private System.Windows.Forms.Label labelOTP;
        private System.Windows.Forms.Button buttonSendOTP;
    }
}