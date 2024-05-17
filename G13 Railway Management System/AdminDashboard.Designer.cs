namespace G13_Railway_Management_System
{
    partial class AdminDashboard
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
            this.labelWelcomeAdmin = new System.Windows.Forms.Label();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcomeAdmin
            // 
            this.labelWelcomeAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcomeAdmin.AutoSize = true;
            this.labelWelcomeAdmin.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeAdmin.Location = new System.Drawing.Point(224, 208);
            this.labelWelcomeAdmin.Name = "labelWelcomeAdmin";
            this.labelWelcomeAdmin.Size = new System.Drawing.Size(187, 31);
            this.labelWelcomeAdmin.TabIndex = 40;
            this.labelWelcomeAdmin.Text = "Welcome Admin";
            // 
            // pictureBoxAdmin
            // 
            this.pictureBoxAdmin.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.admin;
            this.pictureBoxAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAdmin.Location = new System.Drawing.Point(246, 78);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxAdmin.TabIndex = 44;
            this.pictureBoxAdmin.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.pictureBoxAdmin);
            this.Controls.Add(this.labelWelcomeAdmin);
            this.Name = "AdminDashboard";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcomeAdmin;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
    }
}
