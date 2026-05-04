using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Mysqlx.Notice.Warning.Types;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjetoCSharp_BaseDados
{

    public partial class Frm_Menu : Form
    {
        MySqlConnection con; // Classe que estabelece conexão com o banco de dados
        MySqlCommand cmd; // classe capaz de criar contrutores de comando
        MySqlDataReader dr; // classe que le a resposta aos comandos feitos

        private Random random = new Random();

        List<Pergunta> perguntasPython = new List<Pergunta>();
        List<Pergunta> perguntasJava = new List<Pergunta>();
        List<Pergunta> perguntasCSharp = new List<Pergunta>();

        List<Pergunta> perguntasDoJogo;
        Dictionary<int, string> respostasUsuario = new Dictionary<int, string>();
        int indiceAtual = 0;

        string nomeUsuario;
        string nivelUser;

        
        public Frm_Menu(string user) // como parametro tu passou o nome do usuário da caixa de texto do login
        {
            InitializeComponent();
            nomeUsuario = user;
            //CarregarPerguntasDoBanco();

            lbl_data.Text = DateTime.Now.ToShortDateString();


        }


        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            perguntasPython = CarregarPerguntasDoBanco(1); // Python
            perguntasJava = CarregarPerguntasDoBanco(3);   // Java
            perguntasCSharp = CarregarPerguntasDoBanco(2); // C#

            lbl_bem_vindo.Text = "Bem-vindo " + nomeUsuario;

            string query = "Select * from login where lg_nome=@nome";

            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nomeUsuario);
                    con.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            string nivel = dr["nivel"].ToString();
                            lbl_nivel.Text = "Nível - " + nivel;

                            // 🔹 Aqui escondemos a aba se não for admin
                            if (nivel.ToLower() != "admin")
                            {
                                tab_questoes.TabPages.Remove(tab3);
                            }
                        }
                        else
                        {
                            lbl_nivel.Text = "Não encontrado";
                        }
                    }
                }
            }

            atualizar();

            int idUsuario = ObterIdUsuario(nomeUsuario);
            MostrarResultadosDoUsuario(idUsuario);
            CarregarGrafico(idUsuario);
            LoadUserResultsChart(idUsuario);
        }

        


        private List<Pergunta> CarregarPerguntasDoBanco(int idMateria)
        {
            List<Pergunta> perguntas = new List<Pergunta>();

            string query = "SELECT enunciado, altA, altB, altC, altD, correta FROM perguntas WHERE id_materia=@idMateria";

            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@idMateria", idMateria);

                con.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Pergunta p = new Pergunta
                        {
                            Enunciado = dr["enunciado"].ToString(),
                            Alternativas = new List<string>
                    {
                        dr["altA"].ToString(),
                        dr["altB"].ToString(),
                        dr["altC"].ToString(),
                        dr["altD"].ToString()
                    },
                            AltCorreta = dr["correta"].ToString()
                        };

                        perguntas.Add(p);
                    }
                }
            }

            return perguntas;

        }


        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            List<Pergunta> comeco;
            if (cb_escolha.Text == "Python")
            {
                comeco = perguntasPython;
            }
            else if (cb_escolha.Text == "Java")
            {
                comeco = perguntasJava;
            }
            else if (cb_escolha.Text == "C#")
            {
                comeco = perguntasCSharp;

            }
            else
            {
                MessageBox.Show("Escolha uma linguagem!");
                return;
            }

            EmbaralharLista(comeco);

            perguntasDoJogo = comeco.Take(10).ToList();

            respostasUsuario.Clear();
            indiceAtual = 0;

            MostrarPergunta();
        }
        private void MostrarPergunta()
        {

            if (indiceAtual < 0 || indiceAtual >= perguntasDoJogo.Count)
                return;
            Pergunta perguntaAtual = perguntasDoJogo[indiceAtual];

            txt_pergunta.Text = perguntaAtual.Enunciado;



            List<string> alternativas = new List<string>(perguntaAtual.Alternativas);

            EmbaralharLista(alternativas);

            txt_a.Text = alternativas[0];
            txt_b.Text = alternativas[1];
            txt_c.Text = alternativas[2];
            txt_d.Text = alternativas[3];

            if (respostasUsuario.ContainsKey(indiceAtual))
            { }
        }

        private void EmbaralharLista<T>(List<T> lista)
        {
            int n = lista.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T valor = lista[k];
                lista[k] = lista[n];
                lista[n] = valor;
            }
        }

        private void FinalizarPerguntas()
        {

            int acertos = 0;

            for (int i = 0; i < perguntasDoJogo.Count; i++)
            {
                if (respostasUsuario.ContainsKey(i))
                {
                    if (respostasUsuario[i] == perguntasDoJogo[i].AltCorreta)
                    {
                        acertos++;
                    }
                }
            }

            int erros = perguntasDoJogo.Count - acertos;
            MessageBox.Show($"Acertos: {acertos}\nErros: {erros}");

            // Aqui só chamamos os métodos separados
            int idUsuario = ObterIdUsuario(nomeUsuario);
            InserirResultadoNoBanco(idUsuario, cb_escolha.Text, acertos, erros);
            MostrarResultadosDoUsuario(idUsuario);
            CarregarGrafico(idUsuario);
            LoadUserResultsChart(idUsuario);


        }

        private int ObterIdUsuario(string nome)
        {
            int id = 0;
            string query = "SELECT id FROM login WHERE lg_nome=@nome";

            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                con.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        id = Convert.ToInt32(dr["id"]);
                    }
                }
            }

            return id;
        }

        private void MostrarResultadosDoUsuario(int idUsuario)
        {
            string query = "SELECT r.id, u.lg_nome, r.linguagem, r.acertos, r.erros, r.data_prova " +
                           "FROM resultados r " +
                           "INNER JOIN login u ON r.id_usuario = u.id " +
                           "WHERE r.id_usuario=@idUsuario";

            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    dataGridViewResultados.DataSource = dt;
                    MessageBox.Show("Você ainda não realizou nenhum teste.");
                }
                else
                {
                    dataGridViewResultados.DataSource = dt;
                }
            }
        }


        private void InserirResultadoNoBanco(int idUsuario, string linguagem, int acertos, int erros)
        {
            string query = "INSERT INTO resultados (id_usuario, linguagem, acertos, erros, data_prova) " +
                           "VALUES (@idUsuario, @linguagem, @acertos, @erros, NOW())";

            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@linguagem", linguagem);
                cmd.Parameters.AddWithValue("@acertos", acertos);
                cmd.Parameters.AddWithValue("@erros", erros);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }




        private void btn_flecha_seguinte_Click(object sender, EventArgs e)
        {
            if (indiceAtual < perguntasDoJogo.Count - 1)
            {
                cb_a.Checked = false;
                cb_b.Checked = false;
                cb_c.Checked = false;
                cb_d.Checked = false;
                indiceAtual++;
                MostrarPergunta();
            }
            else
            {
                FinalizarPerguntas();
            }

        }

        private void btn_flecha_volta_Click(object sender, EventArgs e)
        {
            if (indiceAtual > 0)
            {
                indiceAtual--;
                MostrarPergunta();
            }
            else
            {
                MessageBox.Show("Está é a primeira pergunta.Não é possível voltar", "Atenção!", MessageBoxButtons.OK);
            }
        }

        private void cb_a_CheckedChanged_1(object sender, EventArgs e)
        {
            respostasUsuario[indiceAtual] = txt_a.Text;
        }

        private void cb_b_CheckedChanged_1(object sender, EventArgs e)
        {
            respostasUsuario[indiceAtual] = txt_b.Text;
        }

        private void cb_c_CheckedChanged_1(object sender, EventArgs e)
        {
            respostasUsuario[indiceAtual] = txt_c.Text;
        }

        private void cb_d_CheckedChanged_1(object sender, EventArgs e)
        {
            respostasUsuario[indiceAtual] = txt_d.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja sair da aplicação", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

















        private void atualizar()
        {
            string query = "SELECT * FROM login";

            try
            {
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    con.Open();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }




        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txt_id.Text) ||
                !int.TryParse(txt_id.Text, out id))
            {
                MessageBox.Show("Por favor, insira um ID válido (apenas números).");
                return; // interrompe o método se for inválido
            }

            string query = "DELETE FROM login WHERE id = @id";

            try
            {
                using (MySqlConnection con = new MySqlConnection(
                    ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // 3️⃣ Usamos a variável id já validada
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();

                    int result = cmd.ExecuteNonQuery();

                    if (result == 0)
                    {
                        MessageBox.Show("Nenhum registro encontrado com esse ID.");
                    }
                    else
                    {
                        MessageBox.Show("Registro eliminado com sucesso!");
                        atualizar(); // atualiza o DataGrid
                        txt_id.Clear(); // limpa o campo
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar: " + ex.Message);
            }
        }



        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_id.Text) || !int.TryParse(txt_id.Text, out int id))
            {
                MessageBox.Show("Insira um ID válido.");
                return;
            }

            if (cb_nivel.SelectedItem == null)
            {
                MessageBox.Show("Selecione um nível.");
                return;
            }

            string query = "UPDATE login SET lg_nome=@nome, lg_pass=@pass, nivel=@nivel WHERE id=@id";

            try
            {
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
                    cmd.Parameters.AddWithValue("@nivel", cb_nivel.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result == 0)
                        MessageBox.Show("ID não encontrado.");
                    else
                    {
                        MessageBox.Show("Registro atualizado!");
                        atualizar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }





        private void btn_inserir_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_nome.Text) ||
                string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                MessageBox.Show("Preencha nome e password.");
                return;
            }

            if (cb_nivel.SelectedItem == null)
            {
                MessageBox.Show("Selecione um nível.");
                return;
            }

            string query = "INSERT INTO login (lg_nome, lg_pass, nivel) VALUES (@nome, @pass, @nivel)";

            try
            {
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
                    cmd.Parameters.AddWithValue("@nivel", cb_nivel.SelectedItem.ToString());

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro inserido com sucesso!");
                    atualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir: " + ex.Message);
            }
        }




        private void btn_Ver_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Visible = true;



            string query = "select * from login;";

            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings
                ["minhaConnectionApp"].ConnectionString))

            using (MySqlCommand cmd = new MySqlCommand(query, con))
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tab_questoes_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tab = sender as TabControl;

            bool selecionado = (e.Index == tab.SelectedIndex);

            Color fundo = selecionado
                ? Color.FromArgb(44, 62, 80)   // aba ativa
                : Color.FromArgb(230, 235, 240); // abas normais

            using (SolidBrush br = new SolidBrush(fundo))
            {
                e.Graphics.FillRectangle(br, e.Bounds);
            }

            string texto = tab.TabPages[e.Index].Text;

            Color corTexto = selecionado ? Color.White : Color.Black;

            TextRenderer.DrawText(
                e.Graphics,
                texto,
                new Font("Segoe UI", 10, FontStyle.Bold),
                e.Bounds,
                corTexto,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter
            );
        }


        private void CarregarGrafico(int idUsuario)
        {
            string query = @"SELECT linguagem, SUM(acertos) as totalAcertos
                             FROM resultados
                             WHERE id_usuario = @idUsuario
                             GROUP BY linguagem";

            using (MySqlConnection con = new MySqlConnection(
                ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                con.Open();

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    chartResultados.Series.Clear();
                    chartResultados.Series.Add("Acertos");
                    chartResultados.Series["Acertos"].ChartType = SeriesChartType.Column;

                    while (dr.Read())
                    {
                        string linguagem = dr["linguagem"].ToString();
                        int totalAcertos = Convert.ToInt32(dr["totalAcertos"]);

                        chartResultados.Series["Acertos"]
                            .Points.AddXY(linguagem, totalAcertos);
                    }
                }
            }
        }
        private void LoadUserResultsChart(int userId)
        {
                string query = @"SELECT linguagem, SUM(acertos) AS totalAcertos
                             FROM resultados
                             WHERE id_usuario = @userId
                             GROUP BY linguagem";

            using (MySqlConnection con = new MySqlConnection(
                ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@userId", userId);

                con.Open();

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    chartResultados.Series.Clear();
                    chartResultados.ChartAreas.Clear();

                    chartResultados.ChartAreas.Add(new ChartArea());

                    Series series = new Series("Correct Answers");
                    series.ChartType = SeriesChartType.Column;
                    series.IsValueShownAsLabel = true;
                    series["PointWidth"] = "0.6";

                    chartResultados.Series.Add(series);

                    while (dr.Read())
                    {
                        string linguagem = dr["linguagem"].ToString();
                        int totalAcertos = Convert.ToInt32(dr["totalAcertos"]);

                        series.Points.AddXY(linguagem, totalAcertos);
                    }

                    // Ajuste automático do eixo Y
                    chartResultados.ChartAreas[0].AxisY.Minimum = 0;
                    chartResultados.ChartAreas[0].AxisY.Interval = 1;
                }
            }
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {
            roundedPanel1.BackColor = Color.FromArgb(200, 221, 227, 234);
        }
    }
}



