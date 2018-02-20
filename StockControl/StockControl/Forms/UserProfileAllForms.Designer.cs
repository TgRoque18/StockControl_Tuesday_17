namespace StockControl.Forms
{
    partial class UserProfileAllForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileAllForms));
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.dgvUserProfile = new System.Windows.Forms.DataGridView();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxEdit
            // 
            this.pbxEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxEdit.BackgroundImage")));
            this.pbxEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxEdit.Location = new System.Drawing.Point(300, 273);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Size = new System.Drawing.Size(54, 50);
            this.pbxEdit.TabIndex = 16;
            this.pbxEdit.TabStop = false;
            this.pbxEdit.Click += new System.EventHandler(this.pbxEdit_Click);
            // 
            // pbxDelete
            // 
            this.pbxDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxDelete.BackgroundImage")));
            this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDelete.Location = new System.Drawing.Point(372, 273);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(53, 50);
            this.pbxDelete.TabIndex = 15;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
            // 
            // pbxAdd
            // 
            this.pbxAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxAdd.BackgroundImage")));
            this.pbxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxAdd.Location = new System.Drawing.Point(228, 273);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(50, 50);
            this.pbxAdd.TabIndex = 14;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxBack.BackgroundImage")));
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Location = new System.Drawing.Point(20, 275);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(51, 50);
            this.pbxBack.TabIndex = 13;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // dgvUserProfile
            // 
            this.dgvUserProfile.AllowUserToAddRows = false;
            this.dgvUserProfile.AllowUserToDeleteRows = false;
            this.dgvUserProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserProfile.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUserProfile.Location = new System.Drawing.Point(21, 77);
            this.dgvUserProfile.MultiSelect = false;
            this.dgvUserProfile.Name = "dgvUserProfile";
            this.dgvUserProfile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserProfile.Size = new System.Drawing.Size(333, 173);
            this.dgvUserProfile.TabIndex = 12;
            // 
            // pbxSearch
            // 
            this.pbxSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxSearch.BackgroundImage")));
            this.pbxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSearch.Location = new System.Drawing.Point(183, 32);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(20, 20);
            this.pbxSearch.TabIndex = 11;
            this.pbxSearch.TabStop = false;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(77, 32);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 10;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(18, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 13);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Pesquisar";
            // 
            // UserProfileAllForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 337);
            this.Controls.Add(this.pbxEdit);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.dgvUserProfile);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Name = "UserProfileAllForms";
            this.Text = "Perfil do Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxEdit;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.DataGridView dgvUserProfile;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}