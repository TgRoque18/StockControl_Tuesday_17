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
    public partial class UserDetailsForm : Form
    {
        public UserDetailsForm()
        {
            InitializeComponent();
        }

      

        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserAllForms userAllForms = new UserAllForms();
            userAllForms.Show();
            this.Hide();
        }
    }
}
