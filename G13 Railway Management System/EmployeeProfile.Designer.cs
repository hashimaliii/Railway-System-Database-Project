namespace G13_Railway_Management_System
{
    partial class EmployeeProfile
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
            this.textBoxEmployeeAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmployeecnic = new System.Windows.Forms.TextBox();
            this.textBoxEmployeePhonenumber = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeLastname = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeFirstname = new System.Windows.Forms.TextBox();
            this.buttonEmployeeSave = new System.Windows.Forms.Button();
            this.textBoxEmployeePassword = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeEmail = new System.Windows.Forms.TextBox();
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
            // textBoxEmployeeAddress
            // 
            this.textBoxEmployeeAddress.Location = new System.Drawing.Point(288, 227);
            this.textBoxEmployeeAddress.Multiline = true;
            this.textBoxEmployeeAddress.Name = "textBoxEmployeeAddress";
            this.textBoxEmployeeAddress.Size = new System.Drawing.Size(248, 20);
            this.textBoxEmployeeAddress.TabIndex = 68;
            // 
            // textBoxEmployeecnic
            // 
            this.textBoxEmployeecnic.Location = new System.Drawing.Point(288, 188);
            this.textBoxEmployeecnic.Name = "textBoxEmployeecnic";
            this.textBoxEmployeecnic.Size = new System.Drawing.Size(248, 20);
            this.textBoxEmployeecnic.TabIndex = 67;
            // 
            // textBoxEmployeePhonenumber
            // 
            this.textBoxEmployeePhonenumber.Location = new System.Drawing.Point(288, 149);
            this.textBoxEmployeePhonenumber.Name = "textBoxEmployeePhonenumber";
            this.textBoxEmployeePhonenumber.Size = new System.Drawing.Size(248, 20);
            this.textBoxEmployeePhonenumber.TabIndex = 66;
            // 
            // textBoxEmployeeLastname
            // 
            this.textBoxEmployeeLastname.Location = new System.Drawing.Point(414, 71);
            this.textBoxEmployeeLastname.Name = "textBoxEmployeeLastname";
            this.textBoxEmployeeLastname.Size = new System.Drawing.Size(122, 20);
            this.textBoxEmployeeLastname.TabIndex = 65;
            // 
            // textBoxEmployeeFirstname
            // 
            this.textBoxEmployeeFirstname.Location = new System.Drawing.Point(288, 71);
            this.textBoxEmployeeFirstname.Name = "textBoxEmployeeFirstname";
            this.textBoxEmployeeFirstname.Size = new System.Drawing.Size(120, 20);
            this.textBoxEmployeeFirstname.TabIndex = 64;
            // 
            // buttonEmployeeSave
            // 
            this.buttonEmployeeSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonEmployeeSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEmployeeSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEmployeeSave.Location = new System.Drawing.Point(380, 407);
            this.buttonEmployeeSave.Name = "buttonEmployeeSave";
            this.buttonEmployeeSave.Size = new System.Drawing.Size(89, 39);
            this.buttonEmployeeSave.TabIndex = 63;
            this.buttonEmployeeSave.Text = "Save";
            this.buttonEmployeeSave.UseVisualStyleBackColor = false;
            this.buttonEmployeeSave.Click += new System.EventHandler(this.buttonEmployeeSave_Click);
            // 
            // textBoxEmployeePassword
            // 
            this.textBoxEmployeePassword.Location = new System.Drawing.Point(288, 266);
            this.textBoxEmployeePassword.Name = "textBoxEmployeePassword";
            this.textBoxEmployeePassword.Size = new System.Drawing.Size(248, 20);
            this.textBoxEmployeePassword.TabIndex = 62;
            this.textBoxEmployeePassword.UseSystemPasswordChar = true;
            this.textBoxEmployeePassword.TextChanged += new System.EventHandler(this.textBoxEmployeePassword_TextChanged);
            // 
            // textBoxEmployeeEmail
            // 
            this.textBoxEmployeeEmail.Location = new System.Drawing.Point(288, 110);
            this.textBoxEmployeeEmail.Name = "textBoxEmployeeEmail";
            this.textBoxEmployeeEmail.Size = new System.Drawing.Size(248, 20);
            this.textBoxEmployeeEmail.TabIndex = 61;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxProfilePicture.Image = global::G13_Railway_Management_System.Properties.Resources.user;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(88, 133);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(89, 82);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 74;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // buttonChangeImage
            // 
            this.buttonChangeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChangeImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChangeImage.Location = new System.Drawing.Point(88, 221);
            this.buttonChangeImage.Name = "buttonChangeImage";
            this.buttonChangeImage.Size = new System.Drawing.Size(89, 39);
            this.buttonChangeImage.TabIndex = 73;
            this.buttonChangeImage.Text = "Change Image";
            this.buttonChangeImage.UseVisualStyleBackColor = false;
            this.buttonChangeImage.Click += new System.EventHandler(this.buttonChangeImage_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(411, 55);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 76;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(285, 55);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 75;
            this.labelFirstName.Text = "First Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(285, 94);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(73, 13);
            this.labelEmail.TabIndex = 77;
            this.labelEmail.Text = "Email Address";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(285, 133);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.labelPhoneNumber.TabIndex = 78;
            this.labelPhoneNumber.Text = "Phone number";
            // 
            // labelCNIC
            // 
            this.labelCNIC.AutoSize = true;
            this.labelCNIC.Location = new System.Drawing.Point(285, 172);
            this.labelCNIC.Name = "labelCNIC";
            this.labelCNIC.Size = new System.Drawing.Size(32, 13);
            this.labelCNIC.TabIndex = 79;
            this.labelCNIC.Text = "CNIC";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(285, 211);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 80;
            this.labelAddress.Text = "Address";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(285, 250);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 81;
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
            this.passwordCheckedListBox.Location = new System.Drawing.Point(288, 314);
            this.passwordCheckedListBox.Name = "passwordCheckedListBox";
            this.passwordCheckedListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.passwordCheckedListBox.Size = new System.Drawing.Size(120, 75);
            this.passwordCheckedListBox.TabIndex = 88;
            this.passwordCheckedListBox.ThreeDCheckBoxes = true;
            // 
            // passwordStrengthLabel
            // 
            this.passwordStrengthLabel.AutoSize = true;
            this.passwordStrengthLabel.Location = new System.Drawing.Point(285, 289);
            this.passwordStrengthLabel.Name = "passwordStrengthLabel";
            this.passwordStrengthLabel.Size = new System.Drawing.Size(60, 13);
            this.passwordStrengthLabel.TabIndex = 87;
            this.passwordStrengthLabel.Text = "Very Weak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 86;
            // 
            // EmployeeProfile
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
            this.Controls.Add(this.textBoxEmployeeAddress);
            this.Controls.Add(this.textBoxEmployeecnic);
            this.Controls.Add(this.textBoxEmployeePhonenumber);
            this.Controls.Add(this.textBoxEmployeeLastname);
            this.Controls.Add(this.textBoxEmployeeFirstname);
            this.Controls.Add(this.buttonEmployeeSave);
            this.Controls.Add(this.textBoxEmployeePassword);
            this.Controls.Add(this.textBoxEmployeeEmail);
            this.Name = "EmployeeProfile";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmployeeAddress;
        private System.Windows.Forms.TextBox textBoxEmployeecnic;
        private System.Windows.Forms.TextBox textBoxEmployeePhonenumber;
        private System.Windows.Forms.TextBox textBoxEmployeeLastname;
        private System.Windows.Forms.TextBox textBoxEmployeeFirstname;
        private System.Windows.Forms.Button buttonEmployeeSave;
        private System.Windows.Forms.TextBox textBoxEmployeePassword;
        private System.Windows.Forms.TextBox textBoxEmployeeEmail;
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
