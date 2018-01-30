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
    public partial class UserProfileDetailsForms : Form
    {
        public UserProfileDetailsForms()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserProfileAllForms userProfileAllForms = new UserProfileAllForms();
            userProfileAllForms.Show();
            this.Hide();

        }
    }
}
