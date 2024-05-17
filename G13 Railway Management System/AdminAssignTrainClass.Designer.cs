namespace G13_Railway_Management_System
{
    partial class AdminAssignTrainClass
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
            this.labelAssignTrainClass = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSeatCapacity = new System.Windows.Forms.TextBox();
            this.labelSeatCapacity = new System.Windows.Forms.Label();
            this.labelClassName = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTrainName = new System.Windows.Forms.TextBox();
            this.labelTrainName = new System.Windows.Forms.Label();
            this.dataGridViewAssignTrainClass = new System.Windows.Forms.DataGridView();
            this.pictureBoxAssignTrainClass = new System.Windows.Forms.PictureBox();
            this.comboBoxClassName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignTrainClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAssignTrainClass)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAssignTrainClass
            // 
            this.labelAssignTrainClass.AutoSize = true;
            this.labelAssignTrainClass.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssignTrainClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelAssignTrainClass.Location = new System.Drawing.Point(290, 49);
            this.labelAssignTrainClass.Name = "labelAssignTrainClass";
            this.labelAssignTrainClass.Size = new System.Drawing.Size(231, 42);
            this.labelAssignTrainClass.TabIndex = 140;
            this.labelAssignTrainClass.Text = "Assign Train Class";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(194, 198);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 139;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSeatCapacity
            // 
            this.textBoxSeatCapacity.Location = new System.Drawing.Point(411, 172);
            this.textBoxSeatCapacity.Name = "textBoxSeatCapacity";
            this.textBoxSeatCapacity.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeatCapacity.TabIndex = 136;
            // 
            // labelSeatCapacity
            // 
            this.labelSeatCapacity.AutoSize = true;
            this.labelSeatCapacity.Location = new System.Drawing.Point(408, 156);
            this.labelSeatCapacity.Name = "labelSeatCapacity";
            this.labelSeatCapacity.Size = new System.Drawing.Size(73, 13);
            this.labelSeatCapacity.TabIndex = 135;
            this.labelSeatCapacity.Text = "Seat Capacity";
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.Location = new System.Drawing.Point(242, 157);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(63, 13);
            this.labelClassName.TabIndex = 132;
            this.labelClassName.Text = "Class Name";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(382, 198);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 27);
            this.buttonDelete.TabIndex = 130;
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
            this.buttonAdd.Location = new System.Drawing.Point(288, 198);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 27);
            this.buttonAdd.TabIndex = 129;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTrainName
            // 
            this.textBoxTrainName.Location = new System.Drawing.Point(139, 172);
            this.textBoxTrainName.Name = "textBoxTrainName";
            this.textBoxTrainName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrainName.TabIndex = 125;
            // 
            // labelTrainName
            // 
            this.labelTrainName.AutoSize = true;
            this.labelTrainName.Location = new System.Drawing.Point(136, 156);
            this.labelTrainName.Name = "labelTrainName";
            this.labelTrainName.Size = new System.Drawing.Size(62, 13);
            this.labelTrainName.TabIndex = 124;
            this.labelTrainName.Text = "Train Name";
            // 
            // dataGridViewAssignTrainClass
            // 
            this.dataGridViewAssignTrainClass.AllowUserToAddRows = false;
            this.dataGridViewAssignTrainClass.AllowUserToDeleteRows = false;
            this.dataGridViewAssignTrainClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignTrainClass.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAssignTrainClass.Location = new System.Drawing.Point(38, 231);
            this.dataGridViewAssignTrainClass.Name = "dataGridViewAssignTrainClass";
            this.dataGridViewAssignTrainClass.RowHeadersWidth = 51;
            this.dataGridViewAssignTrainClass.Size = new System.Drawing.Size(597, 259);
            this.dataGridViewAssignTrainClass.TabIndex = 123;
            this.dataGridViewAssignTrainClass.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAssignTrainClass_CellContentDoubleClick);
            this.dataGridViewAssignTrainClass.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAssignTrainClass_RowHeaderMouseDoubleClick);
            // 
            // pictureBoxAssignTrainClass
            // 
            this.pictureBoxAssignTrainClass.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.AssignTrainClass;
            this.pictureBoxAssignTrainClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAssignTrainClass.Location = new System.Drawing.Point(144, 19);
            this.pictureBoxAssignTrainClass.Name = "pictureBoxAssignTrainClass";
            this.pictureBoxAssignTrainClass.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxAssignTrainClass.TabIndex = 131;
            this.pictureBoxAssignTrainClass.TabStop = false;
            // 
            // comboBoxClassName
            // 
            this.comboBoxClassName.FormattingEnabled = true;
            this.comboBoxClassName.Location = new System.Drawing.Point(245, 171);
            this.comboBoxClassName.Name = "comboBoxClassName";
            this.comboBoxClassName.Size = new System.Drawing.Size(160, 21);
            this.comboBoxClassName.TabIndex = 141;
            // 
            // AdminAssignTrainClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.comboBoxClassName);
            this.Controls.Add(this.labelAssignTrainClass);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSeatCapacity);
            this.Controls.Add(this.labelSeatCapacity);
            this.Controls.Add(this.labelClassName);
            this.Controls.Add(this.pictureBoxAssignTrainClass);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxTrainName);
            this.Controls.Add(this.labelTrainName);
            this.Controls.Add(this.dataGridViewAssignTrainClass);
            this.Name = "AdminAssignTrainClass";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignTrainClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAssignTrainClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAssignTrainClass;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSeatCapacity;
        private System.Windows.Forms.Label labelSeatCapacity;
        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.PictureBox pictureBoxAssignTrainClass;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTrainName;
        private System.Windows.Forms.Label labelTrainName;
        private System.Windows.Forms.DataGridView dataGridViewAssignTrainClass;
        private System.Windows.Forms.ComboBox comboBoxClassName;
    }
}
