﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl.Forms
{
    public partial class ProductDetailsForm : Form
    {
        public ProductDetailsForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            ProductAllForm productAllForm = new ProductAllForm();
            productAllForm.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {

        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
