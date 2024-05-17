namespace G13_Railway_Management_System
{
    partial class AdminProfile
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
            this.textBoxAdminAddress = new System.Windows.Forms.TextBox();
            this.textBoxAdmincnic = new System.Windows.Forms.TextBox();
            this.textBoxAdminPhonenumber = new System.Windows.Forms.TextBox();
            this.textBoxAdminLastname = new System.Windows.Forms.TextBox();
            this.textBoxAdminFirstname = new System.Windows.Forms.TextBox();
            this.buttonAdminSave = new System.Windows.Forms.Button();
            this.textBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.textBoxAdminEmail = new System.Windows.Forms.TextBox();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.buttonChangeImage = new System.Windows.Forms.Button();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelCNIC = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.passwordCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.passwordStrengthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAdminAddress
            // 
            this.textBoxAdminAddress.Location = new System.Drawing.Point(313, 230);
            this.textBoxAdminAddress.Multiline = true;
            this.textBoxAdminAddress.Name = "textBoxAdminAddress";
            this.textBoxAdminAddress.Size = new System.Drawing.Size(248, 20);
            this.textBoxAdminAddress.TabIndex = 59;
            // 
            // textBoxAdmincnic
            // 
            this.textBoxAdmincnic.Location = new System.Drawing.Point(313, 191);
            this.textBoxAdmincnic.Name = "textBoxAdmincnic";
            this.textBoxAdmincnic.Size = new System.Drawing.Size(248, 20);
            this.textBoxAdmincnic.TabIndex = 58;
            // 
            // textBoxAdminPhonenumber
            // 
            this.textBoxAdminPhonenumber.Location = new System.Drawing.Point(313, 152);
            this.textBoxAdminPhonenumber.Name = "textBoxAdminPhonenumber";
            this.textBoxAdminPhonenumber.Size = new System.Drawing.Size(248, 20);
            this.textBoxAdminPhonenumber.TabIndex = 57;
            // 
            // textBoxAdminLastname
            // 
            this.textBoxAdminLastname.Location = new System.Drawing.Point(441, 74);
            this.textBoxAdminLastname.Name = "textBoxAdminLastname";
            this.textBoxAdminLastname.Size = new System.Drawing.Size(120, 20);
            this.textBoxAdminLastname.TabIndex = 56;
            // 
            // textBoxAdminFirstname
            // 
            this.textBoxAdminFirstname.Location = new System.Drawing.Point(313, 74);
            this.textBoxAdminFirstname.Name = "textBoxAdminFirstname";
            this.textBoxAdminFirstname.Size = new System.Drawing.Size(120, 20);
            this.textBoxAdminFirstname.TabIndex = 55;
            // 
            // buttonAdminSave
            // 
            this.buttonAdminSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonAdminSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdminSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdminSave.Location = new System.Drawing.Point(396, 398);
            this.buttonAdminSave.Name = "buttonAdminSave";
            this.buttonAdminSave.Size = new System.Drawing.Size(89, 39);
            this.buttonAdminSave.TabIndex = 54;
            this.buttonAdminSave.Text = "Save";
            this.buttonAdminSave.UseVisualStyleBackColor = false;
            this.buttonAdminSave.Click += new System.EventHandler(this.buttonAdminSave_Click);
            // 
            // textBoxAdminPassword
            // 
            this.textBoxAdminPassword.Location = new System.Drawing.Point(313, 269);
            this.textBoxAdminPassword.Name = "textBoxAdminPassword";
            this.textBoxAdminPassword.Size = new System.Drawing.Size(248, 20);
            this.textBoxAdminPassword.TabIndex = 53;
            this.textBoxAdminPassword.UseSystemPasswordChar = true;
            this.textBoxAdminPassword.TextChanged += new System.EventHandler(this.textBoxAdminPassword_TextChanged);
            // 
            // textBoxAdminEmail
            // 
            this.textBoxAdminEmail.Location = new System.Drawing.Point(313, 113);
            this.textBoxAdminEmail.Name = "textBoxAdminEmail";
            this.textBoxAdminEmail.Size = new System.Drawing.Size(248, 20);
            this.textBoxAdminEmail.TabIndex = 52;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxProfilePicture.Image = global::G13_Railway_Management_System.Properties.Resources.user;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(102, 119);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(89, 82);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 72;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // buttonChangeImage
            // 
            this.buttonChangeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChangeImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChangeImage.Location = new System.Drawing.Point(102, 207);
            this.buttonChangeImage.Name = "buttonChangeImage";
            this.buttonChangeImage.Size = new System.Drawing.Size(89, 39);
            this.buttonChangeImage.TabIndex = 71;
            this.buttonChangeImage.Text = "Change Image";
            this.buttonChangeImage.UseVisualStyleBackColor = false;
            this.buttonChangeImage.Click += new System.EventHandler(this.buttonChangeImage_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(436, 58);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 78;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(310, 58);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 77;
            this.labelFirstName.Text = "First Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(310, 97);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(73, 13);
            this.labelEmail.TabIndex = 79;
            this.labelEmail.Text = "Email Address";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(310, 136);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.labelPhoneNumber.TabIndex = 80;
            this.labelPhoneNumber.Text = "Phone number";
            // 
            // labelCNIC
            // 
            this.labelCNIC.AutoSize = true;
            this.labelCNIC.Location = new System.Drawing.Point(310, 175);
            this.labelCNIC.Name = "labelCNIC";
            this.labelCNIC.Size = new System.Drawing.Size(32, 13);
            this.labelCNIC.TabIndex = 81;
            this.labelCNIC.Text = "CNIC";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(310, 214);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 82;
            this.labelAddress.Text = "Address";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(310, 253);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 83;
            this.labelPassword.Text = "Password";
            // 
            // passwordCheckedListBox
            // 
            this.passwordCheckedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.passwordCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordCheckedListBox.FormattingEnabled = true;
            this.passwordCheckedListBox.Items.AddRange(new object[] {
            "Length >= 8",
            "Capital Letters",
            "Small Letters",
            "Numbers",
            "Special Characters"});
            this.passwordCheckedListBox.Location = new System.Drawing.Point(313, 317);
            this.passwordCheckedListBox.Name = "passwordCheckedListBox";
            this.passwordCheckedListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.passwordCheckedListBox.Size = new System.Drawing.Size(120, 75);
            this.passwordCheckedListBox.TabIndex = 91;
            this.passwordCheckedListBox.ThreeDCheckBoxes = true;
            // 
            // passwordStrengthLabel
            // 
            this.passwordStrengthLabel.AutoSize = true;
            this.passwordStrengthLabel.Location = new System.Drawing.Point(310, 292);
            this.passwordStrengthLabel.Name = "passwordStrengthLabel";
            this.passwordStrengthLabel.Size = new System.Drawing.Size(60, 13);
            this.passwordStrengthLabel.TabIndex = 90;
            this.passwordStrengthLabel.Text = "Very Weak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 89;
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.passwordCheckedListBox);
            this.Controls.Add(this.passwordStrengthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelCNIC);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.buttonChangeImage);
            this.Controls.Add(this.textBoxAdminAddress);
            this.Controls.Add(this.textBoxAdmincnic);
            this.Controls.Add(this.textBoxAdminPhonenumber);
            this.Controls.Add(this.textBoxAdminLastname);
            this.Controls.Add(this.textBoxAdminFirstname);
            this.Controls.Add(this.buttonAdminSave);
            this.Controls.Add(this.textBoxAdminPassword);
            this.Controls.Add(this.textBoxAdminEmail);
            this.Name = "AdminProfile";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAdminAddress;
        private System.Windows.Forms.TextBox textBoxAdmincnic;
        private System.Windows.Forms.TextBox textBoxAdminPhonenumber;
        private System.Windows.Forms.TextBox textBoxAdminLastname;
        private System.Windows.Forms.TextBox textBoxAdminFirstname;
        private System.Windows.Forms.Button buttonAdminSave;
        private System.Windows.Forms.TextBox textBoxAdminPassword;
        private System.Windows.Forms.TextBox textBoxAdminEmail;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Button buttonChangeImage;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelCNIC;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.CheckedListBox passwordCheckedListBox;
        private System.Windows.Forms.Label passwordStrengthLabel;
        private System.Windows.Forms.Label label1;
    }
}
