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
    public partial class UserDetailsForm : Form
    {
        string name;
        string email;
        string password;
        string confirm;
        string profile;
        bool active;
        List<UserProfile> userProfiles = new List<UserProfile>();

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";

        public UserDetailsForm()
        {
            InitializeComponent();
        }

        public UserDetailsForm(int idUser)
        {
            InitializeComponent();
            lblId.Text = idUser.ToString(); //-------

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    //Conectar
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE ID = @id", sqlConnect);
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY WHERE ID = " + idCategory.ToString(), sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idUser));

                    User user = new User(); //------

                    using (SqlDataReader reader = cmd.ExecuteReader()) //-----
                    {
                        while (reader.Read())
                        {
                            user.Id = Int32.Parse(reader["ID"].ToString());
                            user.Name = reader["NAME"].ToString();
                            user.Active = bool.Parse(reader["ACTIVE"].ToString());
                            user.Email = reader["EMAIL"].ToString();
                            user.Password = reader["PASSWORD"].ToString();
                            user.UserProfile = new UserProfile
                            {
                                Id = Int32.Parse(reader["FK_USER_PROFILE"].ToString())
                            };

                        }
                    }

                    tbxName.Text = user.Name;
                    cbxActive.Checked = user.Active;
                    tbxEmail.Text = user.Email;
                    tbxPassword.Text = user.Password;

                    //Busca o index baseado no Select
                    int indexCombo = 0;
                    if (user.UserProfile != null)
                    {
                        indexCombo = user.UserProfile.Id;
                    }

                    //Inicializa o dropDown com as informa��es do banco
                    InitializeComboBox(cmbUserProfile, indexCombo);

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

        private void InitializeComboBox(ComboBox cbxProfile, int indexCombo)
        {
            cbxProfile.Items.Add("Selecione.. ");
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                //Conectar
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM USER_PROFILE", sqlConnect);

                using (SqlDataReader reader = cmd.ExecuteReader()) //-----
                {
                    while (reader.Read())
                    {
                        cbxProfile.Items.Add(reader["NAME"].ToString());
                    }
                }

                cbxProfile.SelectedItem = cbxProfile.Items[indexCombo];
            }
            catch (Exception EX)
            {
                //Tratar exceções
                //throw;

                MessageBox.Show("Erro de acesso ao banco de dados");

                //LogHelper logBD = new LogHelper();
                //logBD.PrintLog(Convert.ToString(EX));
            }
            finally
            {
                //Fechar
                sqlConnect.Close();
            }
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserAllForms userAllForms = new UserAllForms();
            userAllForms.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(lblId.Text)) //-----
            {
                //Salvar

                SqlConnection sqlConnect = new SqlConnection(connectionString);
                try
                {
                    GetData();

                    //Conectar
                    sqlConnect.Open();
                    //COMENTARIOS THIAGO ROQUE
                    /*Quando a tabela do banco usa uma palavra reservada pelo SQL 
                     * neste caso USER, devemos colocar ela entre []
                     * EX:. [USER]
                     */
                    string sql = "INSERT INTO [USER](NAME, PASSWORD, EMAIL, ACTIVE, FK_USER_PROFILE) VALUES (@name, @password, @email, @active, @userProfile)";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@password", password));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@active", active));
                    //COMENTARIOS THIAGO ROQUE
                    /*Pegar sempre o item de outra tabela pelo ID,
                     * O Index representa a posição dele no banco
                     * EX:. quarto item, setimo item
                     * Fiz uma conversao implicita, ou seja coloco o tipo do item pra qual 
                     * eu quero converter antes do item
                     * EX:. (Int32)idade -> converte a variavel idade no tipo Int32
                     */
                    cmd.Parameters.Add(new SqlParameter("@userProfile", ((UserProfile)cmbUserProfile.SelectedItem).Id));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuário adicionado com sucesso!");
                    CleanData();
                }

                catch (Exception ex)
                {
                    //Tratar exceções
                    MessageBox.Show("Erro ao adicionar o usuário!" + ex.Message);
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
                    string sql = "UPDATE [USER] SET NAME = @name,PASSWORD = @password,EMAIL = @email,ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", this.tbxName.Text));
                    cmd.Parameters.Add(new SqlParameter("@password", this.tbxPassword.Text));
                    cmd.Parameters.Add(new SqlParameter("@email", this.tbxEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", this.cbxActive.Checked));
                    cmd.Parameters.Add(new SqlParameter("@id", this.lblId.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Altereções salvas com sucesso!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao editar este usuário!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }
            }

        }

        void GetData()
        {
            name = tbxName.Text;
            email = tbxEmail.Text;
            password = tbxPassword.Text;
            confirm = tbxConfirm.Text;
            profile = cmbUserProfile.Text;
            active = cbxActive.Checked;
        }

        void CleanData()
        {
            tbxName.Text = "";
            tbxEmail.Text = "";
            tbxPassword.Text = "";
            tbxConfirm.Text = "";
            cmbUserProfile.Text = "";
            cbxActive.Checked = false;

        }

        private void LoadComboBox()
        {

            SqlConnection cn = new SqlConnection(connectionString);

            try
            {

                cn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM USER_PROFILE", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UserProfile up = new UserProfile();
                    up.Id = Int32.Parse(reader["ID"].ToString());
                    up.Name = reader["NAME"].ToString();
                    up.Active = bool.Parse(reader["ACTIVE"].ToString());
                    userProfiles.Add(up);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar banco. " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            foreach (UserProfile p in userProfiles)
            {
                cmbUserProfile.Items.Add(p);
            }

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
