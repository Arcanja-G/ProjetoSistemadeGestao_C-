using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoCSharp_BaseDados
{
    public partial class Frm_login : Form
    {
        MySqlConnection con; //
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Frm_login()
        {
            InitializeComponent();
            string minhaConString = ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ToString();
            con = new MySqlConnection(minhaConString);
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
          
            try
            {
                string user = txt_utilizador.Text;
                string pwd = txt_senha.Text;

                //string query = "Select * from login where lg_nome= @user and lg_pass = @pass";
                string query = "SELECT * FROM login WHERE lg_nome = '" + user + "' AND lg_pass = '" + pwd + "'";

                if (user == "admin" && pwd == "123456")
                {
                    MessageBox.Show("Login efetuado!");
                }

                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        /*cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@pass", pwd);*/

                        con.Open();

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {

                            if (dr.Read())
                            {
                                // Login correto
                                MessageBox.Show("Login efetuado com sucesso!\n" + "Bem vindo " + dr[1],
                                    "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Frm_Menu menu = new Frm_Menu(user);
                                menu.Show();
                                this.Hide();

                                // Garante que a mensagem de erro some quando login é correto
                                lbl_erro.Visible = false;
                            }
                            else
                            {
                                // Se usuário + senha não existir no banco
                                lbl_erro.Text = "Usuário ou senha inválidos!";
                                lbl_erro.Visible = true;        // deixa visível

                                // Limpa os campos e coloca foco no usuário
                                txt_utilizador.Clear();
                                txt_senha.Clear();
                                txt_utilizador.Focus();
                            }
                            if (!dr.HasRows) // aqui entra a verificação que você quer
                            {
                                lbl_erro.Text = "Utilizador ou senha inválidos!";
                                lbl_erro.Visible = true;
                                txt_utilizador.Focus();
                                return;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chk_mostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mostrarSenha.Checked)
            {
                txt_senha.UseSystemPasswordChar = false;
            } else
            {
                txt_senha.UseSystemPasswordChar = true;
            }
        }

        private void txt_utilizador_TextChanged_1(object sender, EventArgs e)
        {
            lbl_erro.Visible = false;
        }

       /* private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Text = "";
        }*/

   
    }
}


            
            