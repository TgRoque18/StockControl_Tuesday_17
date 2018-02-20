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
    public partial class UserDetailsForm : Form
    {
        string name;
        string email;
        string password;
        string confirm;
        string profile;
        bool active;

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";

        public UserDetailsForm()
        {
            InitializeComponent();
        }

        public UserDetailsForm(int idUser)
        {
            InitializeComponent();
            lblId.Text = idUser.ToString();

        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserAllForms userAllForms = new UserAllForms();
            userAllForms.Show();
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
                string sql = "INSERT INTO USER(NAME, PASSWORD, EMAIL, ACTIVE) VALUES (@name, @password, @email, @active)";
                //string sql = "INSERT INTO CATEGORY(NAME, ACTIVE) VALUES (" 
                //    + this.tbxName.Text + "," + this.cbxActive.Checked + ")";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@password", password));
                cmd.Parameters.Add(new SqlParameter("@email", email));
                cmd.Parameters.Add(new SqlParameter("@active", active));

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
            email = tbxEmail.Text;
            password = tbxPassword.Text;
            confirm = tbxConfirm.Text;
            profile = tbxProfile.Text;
            active = cbxActive.Checked;
        }
        void CleanData()
        {
            tbxName.Text = "";
            tbxEmail.Text = "";
            tbxPassword.Text = "";
            tbxConfirm.Text = "";
            tbxProfile.Text = "";
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
                    string sql = "DELETE FROM USER WHERE ID = @id";

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
                    MessageBox.Show("Erro ao remover usuário!" + ex.Message);
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
