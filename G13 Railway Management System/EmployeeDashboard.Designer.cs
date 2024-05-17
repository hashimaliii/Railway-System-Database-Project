namespace G13_Railway_Management_System
{
    partial class EmployeeDashboard
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
            this.pictureBoxEmployee = new System.Windows.Forms.PictureBox();
            this.labelWelcomeEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.employee;
            this.pictureBoxEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxEmployee.Location = new System.Drawing.Point(246, 78);
            this.pictureBoxEmployee.Name = "pictureBoxEmployee";
            this.pictureBoxEmployee.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxEmployee.TabIndex = 46;
            this.pictureBoxEmployee.TabStop = false;
            // 
            // labelWelcomeEmployee
            // 
            this.labelWelcomeEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcomeEmployee.AutoSize = true;
            this.labelWelcomeEmployee.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeEmployee.Location = new System.Drawing.Point(212, 208);
            this.labelWelcomeEmployee.Name = "labelWelcomeEmployee";
            this.labelWelcomeEmployee.Size = new System.Drawing.Size(222, 31);
            this.labelWelcomeEmployee.TabIndex = 45;
            this.labelWelcomeEmployee.Text = "Welcome Employee";
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.pictureBoxEmployee);
            this.Controls.Add(this.labelWelcomeEmployee);
            this.Name = "EmployeeDashboard";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEmployee;
        private System.Windows.Forms.Label labelWelcomeEmployee;
    }
}
