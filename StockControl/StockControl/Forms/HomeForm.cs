using StockControl.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pbxUser_Click(object sender, EventArgs e)
        {
            UserAllForms userAllForms = new UserAllForms();
            userAllForms.Show();
            this.Hide();
        }

        private void pbxLog_Click(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm();
            logForm.Show();
            this.Hide();
        }

        private void pbxProduct_Click(object sender, EventArgs e)
        {
            ProductAllForm productAllForm = new ProductAllForm();
            productAllForm.Show();
            this.Hide();
        }

        private void pbxCategory_Click(object sender, EventArgs e)
        {
            CategoryAllForm categoryAllForm = new CategoryAllForm();
            categoryAllForm.Show();
            this.Hide();
        }
    }
}
