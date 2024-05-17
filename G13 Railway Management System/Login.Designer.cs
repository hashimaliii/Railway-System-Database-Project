namespace G13_Railway_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonLoginSignUp = new System.Windows.Forms.Button();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelForgetPassword = new System.Windows.Forms.Label();
            this.labelRailwaySystem = new System.Windows.Forms.Label();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.textBoxLoginUserName = new System.Windows.Forms.TextBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxTrainStation = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoginSignUp
            // 
            this.buttonLoginSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoginSignUp.Location = new System.Drawing.Point(422, 409);
            this.buttonLoginSignUp.Name = "buttonLoginSignUp";
            this.buttonLoginSignUp.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginSignUp.TabIndex = 42;
            this.buttonLoginSignUp.Text = "Sign up";
            this.buttonLoginSignUp.UseVisualStyleBackColor = true;
            this.buttonLoginSignUp.Click += new System.EventHandler(this.buttonLoginSignUp_Click);
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Location = new System.Drawing.Point(291, 414);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(125, 13);
            this.labelSignUp.TabIndex = 41;
            this.labelSignUp.Text = "Don\'t have an account? ";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(355, 352);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(89, 39);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelForgetPassword
            // 
            this.labelForgetPassword.AutoSize = true;
            this.labelForgetPassword.Location = new System.Drawing.Point(388, 330);
            this.labelForgetPassword.Name = "labelForgetPassword";
            this.labelForgetPassword.Size = new System.Drawing.Size(91, 13);
            this.labelForgetPassword.TabIndex = 40;
            this.labelForgetPassword.Text = "Forgot password?";
            this.labelForgetPassword.Visible = false;
            // 
            // labelRailwaySystem
            // 
            this.labelRailwaySystem.AutoSize = true;
            this.labelRailwaySystem.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRailwaySystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelRailwaySystem.Location = new System.Drawing.Point(269, 186);
            this.labelRailwaySystem.Name = "labelRailwaySystem";
            this.labelRailwaySystem.Size = new System.Drawing.Size(247, 42);
            this.labelRailwaySystem.TabIndex = 33;
            this.labelRailwaySystem.Text = "G13 Railway System";
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Location = new System.Drawing.Point(325, 301);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.Size = new System.Drawing.Size(157, 20);
            this.textBoxLoginPassword.TabIndex = 35;
            this.textBoxLoginPassword.Text = "Password";
            this.textBoxLoginPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLoginUserName
            // 
            this.textBoxLoginUserName.Location = new System.Drawing.Point(325, 258);
            this.textBoxLoginUserName.Name = "textBoxLoginUserName";
            this.textBoxLoginUserName.Size = new System.Drawing.Size(157, 20);
            this.textBoxLoginUserName.TabIndex = 34;
            this.textBoxLoginUserName.Text = "Email address";
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.password;
            this.pictureBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPassword.Location = new System.Drawing.Point(294, 301);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(25, 20);
            this.pictureBoxPassword.TabIndex = 39;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxTrainStation
            // 
            this.pictureBoxTrainStation.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.trainstation;
            this.pictureBoxTrainStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTrainStation.Location = new System.Drawing.Point(325, 62);
            this.pictureBoxTrainStation.Name = "pictureBoxTrainStation";
            this.pictureBoxTrainStation.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxTrainStation.TabIndex = 37;
            this.pictureBoxTrainStation.TabStop = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.user;
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUser.Location = new System.Drawing.Point(294, 258);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(25, 20);
            this.pictureBoxUser.TabIndex = 38;
            this.pictureBoxUser.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.buttonLoginSignUp);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelForgetPassword);
            this.Controls.Add(this.labelRailwaySystem);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.textBoxLoginPassword);
            this.Controls.Add(this.pictureBoxTrainStation);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.textBoxLoginUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginSignUp;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelForgetPassword;
        private System.Windows.Forms.Label labelRailwaySystem;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.PictureBox pictureBoxTrainStation;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.TextBox textBoxLoginUserName;
    }
}