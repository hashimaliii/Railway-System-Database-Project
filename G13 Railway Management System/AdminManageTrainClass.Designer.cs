namespace G13_Railway_Management_System
{
    partial class AdminManageTrainClass
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
            this.labelManageTrainClass = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelClassName = new System.Windows.Forms.Label();
            this.pictureBoxManageTrainClass = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewManageTrainClass = new System.Windows.Forms.DataGridView();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.textBoxFareMultiplier = new System.Windows.Forms.TextBox();
            this.labelFareMultiplier = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManageTrainClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTrainClass)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManageTrainClass
            // 
            this.labelManageTrainClass.AutoSize = true;
            this.labelManageTrainClass.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageTrainClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelManageTrainClass.Location = new System.Drawing.Point(284, 50);
            this.labelManageTrainClass.Name = "labelManageTrainClass";
            this.labelManageTrainClass.Size = new System.Drawing.Size(245, 42);
            this.labelManageTrainClass.TabIndex = 152;
            this.labelManageTrainClass.Text = "Manage Train Class";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(166, 190);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 151;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.Location = new System.Drawing.Point(163, 148);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(63, 13);
            this.labelClassName.TabIndex = 148;
            this.labelClassName.Text = "Class Name";
            // 
            // pictureBoxManageTrainClass
            // 
            this.pictureBoxManageTrainClass.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.AssignTrainClass;
            this.pictureBoxManageTrainClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxManageTrainClass.Location = new System.Drawing.Point(138, 20);
            this.pictureBoxManageTrainClass.Name = "pictureBoxManageTrainClass";
            this.pictureBoxManageTrainClass.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxManageTrainClass.TabIndex = 147;
            this.pictureBoxManageTrainClass.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(448, 190);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 27);
            this.buttonDelete.TabIndex = 146;
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
            this.buttonAdd.Location = new System.Drawing.Point(354, 190);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 27);
            this.buttonAdd.TabIndex = 145;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewManageTrainClass
            // 
            this.dataGridViewManageTrainClass.AllowUserToAddRows = false;
            this.dataGridViewManageTrainClass.AllowUserToDeleteRows = false;
            this.dataGridViewManageTrainClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageTrainClass.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewManageTrainClass.Location = new System.Drawing.Point(36, 223);
            this.dataGridViewManageTrainClass.Name = "dataGridViewManageTrainClass";
            this.dataGridViewManageTrainClass.RowHeadersWidth = 51;
            this.dataGridViewManageTrainClass.Size = new System.Drawing.Size(597, 268);
            this.dataGridViewManageTrainClass.TabIndex = 142;
            this.dataGridViewManageTrainClass.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageTrainClass_CellContentDoubleClick);
            this.dataGridViewManageTrainClass.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewManageTrainClass_RowHeaderMouseDoubleClick);
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Location = new System.Drawing.Point(166, 164);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(200, 20);
            this.textBoxClassName.TabIndex = 153;
            // 
            // textBoxFareMultiplier
            // 
            this.textBoxFareMultiplier.Location = new System.Drawing.Point(372, 164);
            this.textBoxFareMultiplier.Name = "textBoxFareMultiplier";
            this.textBoxFareMultiplier.Size = new System.Drawing.Size(164, 20);
            this.textBoxFareMultiplier.TabIndex = 155;
            // 
            // labelFareMultiplier
            // 
            this.labelFareMultiplier.AutoSize = true;
            this.labelFareMultiplier.Location = new System.Drawing.Point(369, 148);
            this.labelFareMultiplier.Name = "labelFareMultiplier";
            this.labelFareMultiplier.Size = new System.Drawing.Size(72, 13);
            this.labelFareMultiplier.TabIndex = 154;
            this.labelFareMultiplier.Text = "Fare Multiplier";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(260, 190);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(88, 27);
            this.buttonUpdate.TabIndex = 156;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click_1);
            // 
            // AdminManageTrainClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxFareMultiplier);
            this.Controls.Add(this.labelFareMultiplier);
            this.Controls.Add(this.textBoxClassName);
            this.Controls.Add(this.labelManageTrainClass);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelClassName);
            this.Controls.Add(this.pictureBoxManageTrainClass);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewManageTrainClass);
            this.Name = "AdminManageTrainClass";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManageTrainClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageTrainClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelManageTrainClass;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.PictureBox pictureBoxManageTrainClass;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewManageTrainClass;
        private System.Windows.Forms.TextBox textBoxClassName;
        private System.Windows.Forms.TextBox textBoxFareMultiplier;
        private System.Windows.Forms.Label labelFareMultiplier;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
