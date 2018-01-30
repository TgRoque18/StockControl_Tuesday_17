using System;
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
    public partial class StockAllForm : Form
    {
        public StockAllForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Hide();
       }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            StockDetailsForm stockDetailsForm = new StockDetailsForm();
            stockDetailsForm.Show();
            this.Hide();
        }
    }
}
