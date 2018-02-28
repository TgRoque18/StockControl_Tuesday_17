namespace StockControl
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pbxProduct = new System.Windows.Forms.PictureBox();
            this.pbxCategory = new System.Windows.Forms.PictureBox();
            this.pbxStock = new System.Windows.Forms.PictureBox();
            this.pbxLog = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxProduct
            // 
            this.pbxProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxProduct.BackgroundImage")));
            this.pbxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxProduct.Location = new System.Drawing.Point(21, 43);
            this.pbxProduct.Name = "pbxProduct";
            this.pbxProduct.Size = new System.Drawing.Size(47, 50);
            this.pbxProduct.TabIndex = 0;
            this.pbxProduct.TabStop = false;
            this.pbxProduct.Click += new System.EventHandler(this.pbxProduct_Click);
            // 
            // pbxCategory
            // 
            this.pbxCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxCategory.BackgroundImage")));
            this.pbxCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCategory.Location = new System.Drawing.Point(100, 43);
            this.pbxCategory.Name = "pbxCategory";
            this.pbxCategory.Size = new System.Drawing.Size(49, 50);
            this.pbxCategory.TabIndex = 1;
            this.pbxCategory.TabStop = false;
            this.pbxCategory.Click += new System.EventHandler(this.pbxCategory_Click_1);
            // 
            // pbxStock
            // 
            this.pbxStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxStock.BackgroundImage")));
            this.pbxStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStock.Location = new System.Drawing.Point(179, 43);
            this.pbxStock.Name = "pbxStock";
            this.pbxStock.Size = new System.Drawing.Size(51, 50);
            this.pbxStock.TabIndex = 2;
            this.pbxStock.TabStop = false;
            this.pbxStock.Click += new System.EventHandler(this.pbxStock_Click);
            // 
            // pbxLog
            // 
            this.pbxLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLog.BackgroundImage")));
            this.pbxLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLog.Location = new System.Drawing.Point(100, 137);
            this.pbxLog.Name = "pbxLog";
            this.pbxLog.Size = new System.Drawing.Size(51, 50);
            this.pbxLog.TabIndex = 5;
            this.pbxLog.TabStop = false;
            this.pbxLog.Click += new System.EventHandler(this.pbxLog_Click);
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxBack.BackgroundImage")));
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Location = new System.Drawing.Point(21, 216);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(32, 33);
            this.pbxBack.TabIndex = 6;
            this.pbxBack.TabStop = false;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(24, 96);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "Produto";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(99, 96);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Categoria";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(184, 96);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(46, 13);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Estoque";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(112, 190);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(25, 13);
            this.lblLog.TabIndex = 10;
            this.lblLog.Text = "Log";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 261);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.pbxLog);
            this.Controls.Add(this.pbxStock);
            this.Controls.Add(this.pbxCategory);
            this.Controls.Add(this.pbxProduct);
            this.Name = "Home";
            this.Text = "Controle de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxProduct;
        private System.Windows.Forms.PictureBox pbxCategory;
        private System.Windows.Forms.PictureBox pbxStock;
        private System.Windows.Forms.PictureBox pbxLog;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblLog;
    }
}