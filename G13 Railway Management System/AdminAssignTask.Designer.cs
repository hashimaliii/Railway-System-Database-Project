namespace G13_Railway_Management_System
{
    partial class AdminAssignTask
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.labelTaskName = new System.Windows.Forms.Label();
            this.dataGridViewAdminEmployee = new System.Windows.Forms.DataGridView();
            this.pictureBoxToDo = new System.Windows.Forms.PictureBox();
            this.textBoxEmployeeCNIC = new System.Windows.Forms.TextBox();
            this.labelEmployeeCNIC = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTask = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToDo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(377, 195);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 27);
            this.buttonDelete.TabIndex = 112;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(283, 195);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 27);
            this.buttonAdd.TabIndex = 111;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(330, 169);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(155, 20);
            this.textBoxTaskName.TabIndex = 107;
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Location = new System.Drawing.Point(327, 153);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(59, 13);
            this.labelTaskName.TabIndex = 106;
            this.labelTaskName.Text = "TaskName";
            // 
            // dataGridViewAdminEmployee
            // 
            this.dataGridViewAdminEmployee.AllowUserToAddRows = false;
            this.dataGridViewAdminEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewAdminEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAdminEmployee.Location = new System.Drawing.Point(36, 228);
            this.dataGridViewAdminEmployee.Name = "dataGridViewAdminEmployee";
            this.dataGridViewAdminEmployee.RowHeadersWidth = 51;
            this.dataGridViewAdminEmployee.Size = new System.Drawing.Size(597, 259);
            this.dataGridViewAdminEmployee.TabIndex = 103;
            this.dataGridViewAdminEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdminEmployee_CellContentClick);
            this.dataGridViewAdminEmployee.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAdminEmployee_RowHeaderMouseDoubleClick);
            // 
            // pictureBoxToDo
            // 
            this.pictureBoxToDo.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.todolist;
            this.pictureBoxToDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxToDo.Location = new System.Drawing.Point(178, 18);
            this.pictureBoxToDo.Name = "pictureBoxToDo";
            this.pictureBoxToDo.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxToDo.TabIndex = 113;
            this.pictureBoxToDo.TabStop = false;
            // 
            // textBoxEmployeeCNIC
            // 
            this.textBoxEmployeeCNIC.Location = new System.Drawing.Point(167, 169);
            this.textBoxEmployeeCNIC.Name = "textBoxEmployeeCNIC";
            this.textBoxEmployeeCNIC.Size = new System.Drawing.Size(157, 20);
            this.textBoxEmployeeCNIC.TabIndex = 115;
            // 
            // labelEmployeeCNIC
            // 
            this.labelEmployeeCNIC.AutoSize = true;
            this.labelEmployeeCNIC.Location = new System.Drawing.Point(164, 153);
            this.labelEmployeeCNIC.Name = "labelEmployeeCNIC";
            this.labelEmployeeCNIC.Size = new System.Drawing.Size(81, 13);
            this.labelEmployeeCNIC.TabIndex = 114;
            this.labelEmployeeCNIC.Text = "Employee CNIC";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(189, 195);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 121;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelTask.Location = new System.Drawing.Point(323, 51);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(154, 42);
            this.labelTask.TabIndex = 122;
            this.labelTask.Text = "Assign Task";
            // 
            // AdminAssignTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxEmployeeCNIC);
            this.Controls.Add(this.labelEmployeeCNIC);
            this.Controls.Add(this.pictureBoxToDo);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxTaskName);
            this.Controls.Add(this.labelTaskName);
            this.Controls.Add(this.dataGridViewAdminEmployee);
            this.Name = "AdminAssignTask";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxToDo;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.DataGridView dataGridViewAdminEmployee;
        private System.Windows.Forms.TextBox textBoxEmployeeCNIC;
        private System.Windows.Forms.Label labelEmployeeCNIC;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelTask;
    }
}
