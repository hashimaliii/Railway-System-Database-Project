namespace G13_Railway_Management_System
{
    partial class AdminManageTrain
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
            this.textBoxTrainName = new System.Windows.Forms.TextBox();
            this.labelTrainName = new System.Windows.Forms.Label();
            this.dataGridViewTrain = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTrain = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonChangeImage = new System.Windows.Forms.Button();
            this.pictureBoxTrainPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxTrain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrain)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(448, 331);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 27);
            this.buttonDelete.TabIndex = 101;
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
            this.buttonAdd.Location = new System.Drawing.Point(354, 331);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 27);
            this.buttonAdd.TabIndex = 100;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTrainName
            // 
            this.textBoxTrainName.Location = new System.Drawing.Point(222, 305);
            this.textBoxTrainName.Name = "textBoxTrainName";
            this.textBoxTrainName.Size = new System.Drawing.Size(242, 20);
            this.textBoxTrainName.TabIndex = 94;
            // 
            // labelTrainName
            // 
            this.labelTrainName.AutoSize = true;
            this.labelTrainName.Location = new System.Drawing.Point(219, 289);
            this.labelTrainName.Name = "labelTrainName";
            this.labelTrainName.Size = new System.Drawing.Size(35, 13);
            this.labelTrainName.TabIndex = 93;
            this.labelTrainName.Text = "Name";
            // 
            // dataGridViewTrain
            // 
            this.dataGridViewTrain.AllowUserToAddRows = false;
            this.dataGridViewTrain.AllowUserToDeleteRows = false;
            this.dataGridViewTrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTrain.Location = new System.Drawing.Point(36, 364);
            this.dataGridViewTrain.Name = "dataGridViewTrain";
            this.dataGridViewTrain.RowHeadersWidth = 51;
            this.dataGridViewTrain.Size = new System.Drawing.Size(597, 117);
            this.dataGridViewTrain.TabIndex = 90;
            this.dataGridViewTrain.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrain_CellContentDoubleClick);
            this.dataGridViewTrain.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTrain_RowHeaderMouseDoubleClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(166, 331);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 122;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelTrain
            // 
            this.labelTrain.AutoSize = true;
            this.labelTrain.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.labelTrain.Location = new System.Drawing.Point(351, 51);
            this.labelTrain.Name = "labelTrain";
            this.labelTrain.Size = new System.Drawing.Size(77, 42);
            this.labelTrain.TabIndex = 123;
            this.labelTrain.Text = "Train";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(260, 331);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(88, 27);
            this.buttonUpdate.TabIndex = 124;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonChangeImage
            // 
            this.buttonChangeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.buttonChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChangeImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChangeImage.Location = new System.Drawing.Point(292, 245);
            this.buttonChangeImage.Name = "buttonChangeImage";
            this.buttonChangeImage.Size = new System.Drawing.Size(89, 39);
            this.buttonChangeImage.TabIndex = 126;
            this.buttonChangeImage.Text = "Change Image";
            this.buttonChangeImage.UseVisualStyleBackColor = false;
            this.buttonChangeImage.Click += new System.EventHandler(this.buttonChangeImage_Click);
            // 
            // pictureBoxTrainPicture
            // 
            this.pictureBoxTrainPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTrainPicture.Image = global::G13_Railway_Management_System.Properties.Resources.train;
            this.pictureBoxTrainPicture.Location = new System.Drawing.Point(286, 152);
            this.pictureBoxTrainPicture.Name = "pictureBoxTrainPicture";
            this.pictureBoxTrainPicture.Size = new System.Drawing.Size(101, 87);
            this.pictureBoxTrainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTrainPicture.TabIndex = 125;
            this.pictureBoxTrainPicture.TabStop = false;
            // 
            // pictureBoxTrain
            // 
            this.pictureBoxTrain.BackgroundImage = global::G13_Railway_Management_System.Properties.Resources.trainstation;
            this.pictureBoxTrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTrain.Location = new System.Drawing.Point(205, 18);
            this.pictureBoxTrain.Name = "pictureBoxTrain";
            this.pictureBoxTrain.Size = new System.Drawing.Size(140, 105);
            this.pictureBoxTrain.TabIndex = 102;
            this.pictureBoxTrain.TabStop = false;
            // 
            // AdminManageTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.buttonChangeImage);
            this.Controls.Add(this.pictureBoxTrainPicture);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelTrain);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.pictureBoxTrain);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxTrainName);
            this.Controls.Add(this.labelTrainName);
            this.Controls.Add(this.dataGridViewTrain);
            this.Name = "AdminManageTrain";
            this.Size = new System.Drawing.Size(668, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTrainName;
        private System.Windows.Forms.Label labelTrainName;
        private System.Windows.Forms.DataGridView dataGridViewTrain;
        private System.Windows.Forms.PictureBox pictureBoxTrain;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelTrain;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.PictureBox pictureBoxTrainPicture;
        private System.Windows.Forms.Button buttonChangeImage;
    }
}
