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
    public partial class UserAllForms : Form
    {
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";

        public UserAllForms()
        {
            InitializeComponent();
            ShowData();
            ResizeDataGridView();
        }

        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM USER", sqlConnect);
                // SqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvUser.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar. " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void ResizeDataGridView()
        {
            dgvUser.Columns["ID"].Visible = false;
            dgvUser.Columns["NAME"].HeaderText = "Nome";
            //dgvStock.Columns["ACTIVE"].HeaderText = "Ativo";
            //dgvStock.Columns["QUANTITY"].HeaderText = "Qtd";
            //dgvStock.Columns["FK_PRODUCT"].Visible = false;

            //foreach (DataGridViewColumn col in dgvStock.Columns)
            //{
            //    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            //}
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Hide();
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            UserDetailsForm userDatailsForm = new UserDetailsForm();
            userDatailsForm.Show();
            this.Hide();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

            int idUser = Int32.Parse(dgvUser.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                //Conectar
                sqlConnect.Open();
                string sql = "DELETE FROM CATEGORY WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idUser));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Removido com sucesso!");
            }
            catch (Exception ex)
            {
                //Tratar exce��es
                MessageBox.Show("Erro ao remover usuário!" + "\n\n" + ex.Message);
                throw;
            }
            finally
            {
                //Fechar
                sqlConnect.Close();
            }
        }
    }
}
