namespace StockControl.Forms
{
    partial class UserDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetailsForm));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxConfirm = new System.Windows.Forms.TextBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbUserProfile = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(48, 78);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(48, 115);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Senha:";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(12, 150);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(101, 13);
            this.lblConfirm.TabIndex = 3;
            this.lblConfirm.Text = "Confirmação senha:";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(48, 185);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(33, 13);
            this.lblProfile.TabIndex = 4;
            this.lblProfile.Text = "Perfil:";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(48, 217);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(34, 13);
            this.lblActive.TabIndex = 5;
            this.lblActive.Text = "Ativo:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(119, 37);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 6;
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.Location = new System.Drawing.Point(89, 217);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(15, 14);
            this.cbxActive.TabIndex = 7;
            this.cbxActive.UseVisualStyleBackColor = true;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(119, 71);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxEmail.TabIndex = 8;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(119, 108);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 9;
            // 
            // tbxConfirm
            // 
            this.tbxConfirm.Location = new System.Drawing.Point(119, 143);
            this.tbxConfirm.Name = "tbxConfirm";
            this.tbxConfirm.Size = new System.Drawing.Size(100, 20);
            this.tbxConfirm.TabIndex = 10;
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxBack.BackgroundImage")));
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Location = new System.Drawing.Point(15, 320);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(54, 50);
            this.pbxBack.TabIndex = 12;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // pbxSave
            // 
            this.pbxSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxSave.BackgroundImage")));
            this.pbxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSave.Location = new System.Drawing.Point(312, 320);
            this.pbxSave.Name = "pbxSave";
            this.pbxSave.Size = new System.Drawing.Size(54, 50);
            this.pbxSave.TabIndex = 13;
            this.pbxSave.TabStop = false;
            this.pbxSave.Click += new System.EventHandler(this.pbxSave_Click);
            // 
            // pbxDelete
            // 
            this.pbxDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxDelete.BackgroundImage")));
            this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDelete.Location = new System.Drawing.Point(392, 320);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(58, 50);
            this.pbxDelete.TabIndex = 14;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Nome:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Visible = false;
            // 
            // cmbUserProfile
            // 
            this.cmbUserProfile.FormattingEnabled = true;
            this.cmbUserProfile.Location = new System.Drawing.Point(119, 182);
            this.cmbUserProfile.Name = "cmbUserProfile";
            this.cmbUserProfile.Size = new System.Drawing.Size(100, 21);
            this.cmbUserProfile.TabIndex = 18;
            // 
            // UserDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 394);
            this.Controls.Add(this.cmbUserProfile);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbxSave);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.tbxConfirm);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.cbxActive);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Name = "UserDetailsForm";
            this.Text = "Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.CheckBox cbxActive;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxConfirm;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxSave;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbUserProfile;
    }
}