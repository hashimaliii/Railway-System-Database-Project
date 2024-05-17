namespace G13_Railway_Management_System
{
    partial class PassengerDashboard
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
            this.labelWelcomePassenger = new System.Windows.Forms.Label();
            this.pictureBoxPassenger = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassenger)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcomePassenger
            // 
            this.labelWelcomePassenger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcomePassenger.AutoSize = true;
            this.labelWelcomePassenger.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomePassenger.Location = new System.Drawing.Point(210, 208);
            this.labelWelcomePassenger.Name = "labelWelcomePassenger";
            this.labelWelcomePassenger.Size = new System.Drawing.Size(229, 31);
            this.labelWelcomePassenger.TabIndex = 45;
            this.labelWelcomePassenger.Text = "Welcome Passenger";
            // 
            // pictureBoxPassenger
            // 
            this.pictureBoxPassenger.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.passenger;
            this.pictureBoxPassenger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPassenger.Location = new System.Drawing.Point(246, 78);
            this.pictureBoxPassenger.Name = "pictureBoxPassenger";
            this.pictureBoxPassenger.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxPassenger.TabIndex = 46;
            this.pictureBoxPassenger.TabStop = false;
            // 
            // PassengerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.pictureBoxPassenger);
            this.Controls.Add(this.labelWelcomePassenger);
            this.Name = "PassengerDashboard";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassenger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPassenger;
        private System.Windows.Forms.Label labelWelcomePassenger;
    }
}
