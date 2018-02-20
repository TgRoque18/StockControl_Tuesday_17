using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl.Forms
{
    public partial class StockDetailsForm : Form
    {
        string name;
        int quantity = 0;
        bool active;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";

        public StockDetailsForm()
        {
            InitializeComponent();
        }
        public StockDetailsForm(int idStock)
        {
            InitializeComponent();
            lblId.Text = idStock.ToString();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {

            GetData();

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                //Conectar
                sqlConnect.Open();
                string sql = "INSERT INTO STOCK(QUANTITY, ACTIVE, NAME) VALUES (@quantity, @active, @name)";
                //string sql = "INSERT INTO CATEGORY(NAME, ACTIVE) VALUES (" 
                //    + this.tbxName.Text + "," + this.cbxActive.Checked + ")";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@quantity", quantity));
                cmd.Parameters.Add(new SqlParameter("@active", active));
                cmd.Parameters.Add(new SqlParameter("@name", name));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado com sucesso!");
                CleanData();
                
            }
            catch (Exception ex)
            {
                //Tratar exce��es
                MessageBox.Show("Erro ao adicionar categoria!" + ex.Message);
                CleanData();
            }
            finally
            {
                //Fechar
                sqlConnect.Close();

            }
        }
        void GetData()
        {
            name = tbxName.Text;
            quantity = Int32.Parse(tbxAmount.Text);
            active = cbxActive.Checked;
        }
        void CleanData()
        {
            tbxName.Text = "";
            tbxAmount.Text = "";
            cbxActive.Checked = false;
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblId.Text)) //-----
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    //Conectar
                    sqlConnect.Open();
                    string sql = "DELETE FROM STOCK WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", this.lblId.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Removido com sucesso!");

                    //LogHelper log = new LogHelper();
                    //log.Insert("User Remove");
                }
                catch (Exception ex)
                {
                    //Tratar exce��es
                    MessageBox.Show("Erro ao remover estoque!" + ex.Message);
                    //throw;

                    //LogHelper logBD = new LogHelper();
                    //logBD.PrintLog(Convert.ToString(ex));
                }
                finally
                {
                    //Fechar
                    sqlConnect.Close();
                }
            }
        }
    }
}
