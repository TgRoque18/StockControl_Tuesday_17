using StockControl.Class;
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

            lblId.Text = idStock.ToString(); //-------

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    //Conectar
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM STOCK WHERE ID = @id", sqlConnect);
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY WHERE ID = " + idCategory.ToString(), sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idStock));

                    Stock stock = new Stock(); //------

                    using (SqlDataReader reader = cmd.ExecuteReader()) //-----
                    {
                        while (reader.Read())
                        {
                            stock.Id = Int32.Parse(reader["ID"].ToString());
                            stock.Amount = Int32.Parse(reader["QUANTITY"].ToString());

                            if (Int32.Parse(reader["ACTIVE"].ToString()) == 0)
                            {
                                stock.Active = false;
                            }
                            else
                            {
                                stock.Active = true;
                            }
                               
                            stock.Name = reader["NAME"].ToString();
                            
                            

                        }
                    }

                    tbxName.Text = stock.Name;
                    cbxActive.Checked = stock.Active;
                    

                    //Busca o index baseado no Select
                    
                   

                    //Inicializa o dropDown com as informa��es do banco
                    

                }
                catch (Exception EX)
                {
                    //Tratar exce��es
                    throw;
                }
                finally
                {
                    //Fechar
                    sqlConnect.Close();
                }
            }

        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            StockAllForm stockAllForm = new StockAllForm();
            stockAllForm.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblId.Text)) //-----
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
            else
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    sqlConnect.Open();
                    string sql = "UPDATE STOCK SET QUANTITY = @quantity, ACTIVE = @active, NAME = @NAME WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", this.tbxName.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", this.cbxActive.Checked));
                    cmd.Parameters.Add(new SqlParameter("@quantity", this.tbxAmount));
                    cmd.Parameters.Add(new SqlParameter("@id", this.lblId.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Alterações salvas com sucesso!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao editar este estoque!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();

                    StockAllForm stockAllForm = new StockAllForm();
                    stockAllForm.Show();
                    this.Hide();
                }
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
