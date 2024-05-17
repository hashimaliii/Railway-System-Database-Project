namespace G13_Railway_Management_System
{
    partial class AdminManageRoute
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
            this.labelTaskManageStation = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxRouteName = new System.Windows.Forms.TextBox();
            this.labelEmployeeRouteName = new System.Windows.Forms.Label();
            this.pictureBoxManageRoute = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewManageRoute = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManageRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTaskManageStation
            // 
            this.labelTaskManageStation.AutoSize = true;
            this.labelTaskManageStation.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskManageStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelTaskManageStation.Location = new System.Drawing.Point(317, 54);
            this.labelTaskManageStation.Name = "labelTaskManageStation";
            this.labelTaskManageStation.Size = new System.Drawing.Size(181, 42);
            this.labelTaskManageStation.TabIndex = 150;
            this.labelTaskManageStation.Text = "Manage Route";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(202, 194);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 149;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxRouteName
            // 
            this.textBoxRouteName.Location = new System.Drawing.Point(174, 168);
            this.textBoxRouteName.Name = "textBoxRouteName";
            this.textBoxRouteName.Size = new System.Drawing.Size(318, 20);
            this.textBoxRouteName.TabIndex = 148;
            // 
            // labelEmployeeRouteName
            // 
            this.labelEmployeeRouteName.AutoSize = true;
            this.labelEmployeeRouteName.Location = new System.Drawing.Point(169, 152);
            this.labelEmployeeRouteName.Name = "labelEmployeeRouteName";
            this.labelEmployeeRouteName.Size = new System.Drawing.Size(67, 13);
            this.labelEmployeeRouteName.TabIndex = 147;
            this.labelEmployeeRouteName.Text = "Route Name";
            // 
            // pictureBoxManageRoute
            // 
            this.pictureBoxManageRoute.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.train_station;
            this.pictureBoxManageRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxManageRoute.Location = new System.Drawing.Point(172, 21);
            this.pictureBoxManageRoute.Name = "pictureBoxManageRoute";
            this.pictureBoxManageRoute.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxManageRoute.TabIndex = 146;
            this.pictureBoxManageRoute.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(390, 194);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 27);
            this.buttonDelete.TabIndex = 145;
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
            this.buttonAdd.Location = new System.Drawing.Point(296, 194);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 27);
            this.buttonAdd.TabIndex = 144;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewManageRoute
            // 
            this.dataGridViewManageRoute.AllowUserToAddRows = false;
            this.dataGridViewManageRoute.AllowUserToDeleteRows = false;
            this.dataGridViewManageRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageRoute.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewManageRoute.Location = new System.Drawing.Point(36, 227);
            this.dataGridViewManageRoute.Name = "dataGridViewManageRoute";
            this.dataGridViewManageRoute.RowHeadersWidth = 51;
            this.dataGridViewManageRoute.Size = new System.Drawing.Size(597, 263);
            this.dataGridViewManageRoute.TabIndex = 143;
            this.dataGridViewManageRoute.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageRoute_CellContentDoubleClick);
            this.dataGridViewManageRoute.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewManageRoute_RowHeaderMouseDoubleClick);
            // 
            // AdminManageRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.labelTaskManageStation);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxRouteName);
            this.Controls.Add(this.labelEmployeeRouteName);
            this.Controls.Add(this.pictureBoxManageRoute);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewManageRoute);
            this.Name = "AdminManageRoute";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManageRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageRoute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTaskManageStation;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxRouteName;
        private System.Windows.Forms.Label labelEmployeeRouteName;
        private System.Windows.Forms.PictureBox pictureBoxManageRoute;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewManageRoute;
    }
}
