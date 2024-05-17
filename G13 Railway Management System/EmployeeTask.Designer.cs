namespace G13_Railway_Management_System
{
    partial class EmployeeTask
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
            this.labelTask = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxTaskDescription = new System.Windows.Forms.TextBox();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.comboBoxTaskStatus = new System.Windows.Forms.ComboBox();
            this.pictureBoxToDo = new System.Windows.Forms.PictureBox();
            this.labelTaskStatus = new System.Windows.Forms.Label();
            this.textBoxTaskDueDate = new System.Windows.Forms.TextBox();
            this.labelTaskDueDate = new System.Windows.Forms.Label();
            this.labelTaskName = new System.Windows.Forms.Label();
            this.dataGridViewAdminEmployee = new System.Windows.Forms.DataGridView();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.buttonMarkAsComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelTask.Location = new System.Drawing.Point(335, 54);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(71, 42);
            this.labelTask.TabIndex = 141;
            this.labelTask.Text = "Task";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(230, 263);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 140;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxTaskDescription
            // 
            this.textBoxTaskDescription.Location = new System.Drawing.Point(38, 212);
            this.textBoxTaskDescription.Multiline = true;
            this.textBoxTaskDescription.Name = "textBoxTaskDescription";
            this.textBoxTaskDescription.Size = new System.Drawing.Size(594, 45);
            this.textBoxTaskDescription.TabIndex = 139;
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(35, 196);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(60, 13);
            this.labelTaskDescription.TabIndex = 138;
            this.labelTaskDescription.Text = "Description";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(478, 173);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(154, 20);
            this.textBoxAmount.TabIndex = 137;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(475, 157);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 136;
            this.labelAmount.Text = "Amount";
            // 
            // comboBoxTaskStatus
            // 
            this.comboBoxTaskStatus.FormattingEnabled = true;
            this.comboBoxTaskStatus.Items.AddRange(new object[] {
            "Completed",
            "Incomplete"});
            this.comboBoxTaskStatus.Location = new System.Drawing.Point(324, 172);
            this.comboBoxTaskStatus.Name = "comboBoxTaskStatus";
            this.comboBoxTaskStatus.Size = new System.Drawing.Size(148, 21);
            this.comboBoxTaskStatus.TabIndex = 135;
            // 
            // pictureBoxToDo
            // 
            this.pictureBoxToDo.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.todolist;
            this.pictureBoxToDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxToDo.Location = new System.Drawing.Point(190, 21);
            this.pictureBoxToDo.Name = "pictureBoxToDo";
            this.pictureBoxToDo.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxToDo.TabIndex = 132;
            this.pictureBoxToDo.TabStop = false;
            // 
            // labelTaskStatus
            // 
            this.labelTaskStatus.AutoSize = true;
            this.labelTaskStatus.Location = new System.Drawing.Point(321, 156);
            this.labelTaskStatus.Name = "labelTaskStatus";
            this.labelTaskStatus.Size = new System.Drawing.Size(64, 13);
            this.labelTaskStatus.TabIndex = 128;
            this.labelTaskStatus.Text = "Task Status";
            // 
            // textBoxTaskDueDate
            // 
            this.textBoxTaskDueDate.Location = new System.Drawing.Point(198, 173);
            this.textBoxTaskDueDate.Name = "textBoxTaskDueDate";
            this.textBoxTaskDueDate.Size = new System.Drawing.Size(120, 20);
            this.textBoxTaskDueDate.TabIndex = 127;
            // 
            // labelTaskDueDate
            // 
            this.labelTaskDueDate.AutoSize = true;
            this.labelTaskDueDate.Location = new System.Drawing.Point(195, 157);
            this.labelTaskDueDate.Name = "labelTaskDueDate";
            this.labelTaskDueDate.Size = new System.Drawing.Size(53, 13);
            this.labelTaskDueDate.TabIndex = 126;
            this.labelTaskDueDate.Text = "Due Date";
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Location = new System.Drawing.Point(33, 157);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(62, 13);
            this.labelTaskName.TabIndex = 124;
            this.labelTaskName.Text = "Task Name";
            // 
            // dataGridViewAdminEmployee
            // 
            this.dataGridViewAdminEmployee.AllowUserToAddRows = false;
            this.dataGridViewAdminEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewAdminEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAdminEmployee.Location = new System.Drawing.Point(38, 296);
            this.dataGridViewAdminEmployee.Name = "dataGridViewAdminEmployee";
            this.dataGridViewAdminEmployee.RowHeadersWidth = 51;
            this.dataGridViewAdminEmployee.Size = new System.Drawing.Size(597, 194);
            this.dataGridViewAdminEmployee.TabIndex = 123;
            this.dataGridViewAdminEmployee.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdminEmployee_CellContentDoubleClick);
            this.dataGridViewAdminEmployee.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAdminEmployee_RowHeaderMouseDoubleClick);
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(38, 173);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(154, 20);
            this.textBoxTaskName.TabIndex = 168;
            // 
            // buttonMarkAsComplete
            // 
            this.buttonMarkAsComplete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonMarkAsComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonMarkAsComplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMarkAsComplete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMarkAsComplete.Location = new System.Drawing.Point(324, 263);
            this.buttonMarkAsComplete.Name = "buttonMarkAsComplete";
            this.buttonMarkAsComplete.Size = new System.Drawing.Size(104, 27);
            this.buttonMarkAsComplete.TabIndex = 169;
            this.buttonMarkAsComplete.Text = "Mark As Complete";
            this.buttonMarkAsComplete.UseVisualStyleBackColor = false;
            this.buttonMarkAsComplete.Click += new System.EventHandler(this.buttonMarkAsComplete_Click);
            // 
            // EmployeeTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.buttonMarkAsComplete);
            this.Controls.Add(this.textBoxTaskName);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxTaskDescription);
            this.Controls.Add(this.labelTaskDescription);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.comboBoxTaskStatus);
            this.Controls.Add(this.pictureBoxToDo);
            this.Controls.Add(this.labelTaskStatus);
            this.Controls.Add(this.textBoxTaskDueDate);
            this.Controls.Add(this.labelTaskDueDate);
            this.Controls.Add(this.labelTaskName);
            this.Controls.Add(this.dataGridViewAdminEmployee);
            this.Name = "EmployeeTask";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxTaskDescription;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.ComboBox comboBoxTaskStatus;
        private System.Windows.Forms.PictureBox pictureBoxToDo;
        private System.Windows.Forms.Label labelTaskStatus;
        private System.Windows.Forms.TextBox textBoxTaskDueDate;
        private System.Windows.Forms.Label labelTaskDueDate;
        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.DataGridView dataGridViewAdminEmployee;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.Button buttonMarkAsComplete;
    }
}
