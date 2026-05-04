namespace ProjetoCSharp_BaseDados
{
    partial class Frm_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.Button button1;
            this.tab_questoes = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_d = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_b = new System.Windows.Forms.RadioButton();
            this.cb_c = new System.Windows.Forms.RadioButton();
            this.cb_a = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_flecha_seguinte = new System.Windows.Forms.Button();
            this.btn_flecha_volta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_pergunta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_escolha = new System.Windows.Forms.ComboBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.chartResultados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_Ver = new System.Windows.Forms.Button();
            this.cb_nivel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.roundedPanel1 = new ProjetoCSharp_BaseDados.RoundedPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_bem_vindo = new System.Windows.Forms.Label();
            this.lbl_nivel = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            this.tab_questoes.SuspendLayout();
            this.tab1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.tab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_questoes
            // 
            this.tab_questoes.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tab_questoes.Controls.Add(this.tab1);
            this.tab_questoes.Controls.Add(this.tab2);
            this.tab_questoes.Controls.Add(this.tab3);
            this.tab_questoes.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tab_questoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_questoes.ItemSize = new System.Drawing.Size(351, 40);
            this.tab_questoes.Location = new System.Drawing.Point(38, 117);
            this.tab_questoes.Multiline = true;
            this.tab_questoes.Name = "tab_questoes";
            this.tab_questoes.SelectedIndex = 0;
            this.tab_questoes.Size = new System.Drawing.Size(1084, 480);
            this.tab_questoes.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_questoes.TabIndex = 2;
            this.tab_questoes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tab_questoes_DrawItem);
            // 
            // tab1
            // 
            this.tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.tab1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab1.Controls.Add(this.btn_iniciar);
            this.tab1.Controls.Add(this.panel1);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.cb_escolha);
            this.tab1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.tab1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab1.Location = new System.Drawing.Point(4, 44);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1076, 432);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Questões de estudo";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_iniciar.Location = new System.Drawing.Point(367, 21);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 29);
            this.btn_iniciar.TabIndex = 6;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.cb_d);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.cb_b);
            this.panel1.Controls.Add(this.cb_c);
            this.panel1.Controls.Add(this.cb_a);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_flecha_seguinte);
            this.panel1.Controls.Add(this.btn_flecha_volta);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_d);
            this.panel1.Controls.Add(this.txt_c);
            this.panel1.Controls.Add(this.txt_b);
            this.panel1.Controls.Add(this.txt_a);
            this.panel1.Controls.Add(this.txt_pergunta);
            this.panel1.Location = new System.Drawing.Point(16, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 361);
            this.panel1.TabIndex = 5;
            // 
            // cb_d
            // 
            this.cb_d.AutoSize = true;
            this.cb_d.Location = new System.Drawing.Point(941, 238);
            this.cb_d.Name = "cb_d";
            this.cb_d.Size = new System.Drawing.Size(14, 13);
            this.cb_d.TabIndex = 19;
            this.cb_d.TabStop = true;
            this.cb_d.UseVisualStyleBackColor = true;
            this.cb_d.CheckedChanged += new System.EventHandler(this.cb_d_CheckedChanged_1);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::ProjetoCSharp_BaseDados.Properties.Resources.png_transparent_computer_icons_the_book_thief_book_angle_rectangle_curriculum;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(975, 302);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(62, 56);
            this.panel4.TabIndex = 13;
            // 
            // cb_b
            // 
            this.cb_b.AutoSize = true;
            this.cb_b.Location = new System.Drawing.Point(941, 146);
            this.cb_b.Name = "cb_b";
            this.cb_b.Size = new System.Drawing.Size(14, 13);
            this.cb_b.TabIndex = 18;
            this.cb_b.TabStop = true;
            this.cb_b.UseVisualStyleBackColor = true;
            this.cb_b.CheckedChanged += new System.EventHandler(this.cb_b_CheckedChanged_1);
            // 
            // cb_c
            // 
            this.cb_c.AutoSize = true;
            this.cb_c.Location = new System.Drawing.Point(941, 191);
            this.cb_c.Name = "cb_c";
            this.cb_c.Size = new System.Drawing.Size(14, 13);
            this.cb_c.TabIndex = 17;
            this.cb_c.TabStop = true;
            this.cb_c.UseVisualStyleBackColor = true;
            this.cb_c.CheckedChanged += new System.EventHandler(this.cb_c_CheckedChanged_1);
            // 
            // cb_a
            // 
            this.cb_a.AutoSize = true;
            this.cb_a.Location = new System.Drawing.Point(941, 103);
            this.cb_a.Name = "cb_a";
            this.cb_a.Size = new System.Drawing.Size(14, 13);
            this.cb_a.TabIndex = 16;
            this.cb_a.TabStop = true;
            this.cb_a.UseVisualStyleBackColor = true;
            this.cb_a.CheckedChanged += new System.EventHandler(this.cb_a_CheckedChanged_1);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ProjetoCSharp_BaseDados.Properties.Resources.images;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 361);
            this.panel2.TabIndex = 15;
            // 
            // btn_flecha_seguinte
            // 
            this.btn_flecha_seguinte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_flecha_seguinte.Location = new System.Drawing.Point(680, 273);
            this.btn_flecha_seguinte.Name = "btn_flecha_seguinte";
            this.btn_flecha_seguinte.Size = new System.Drawing.Size(75, 23);
            this.btn_flecha_seguinte.TabIndex = 10;
            this.btn_flecha_seguinte.Text = ">";
            this.btn_flecha_seguinte.UseVisualStyleBackColor = true;
            this.btn_flecha_seguinte.Click += new System.EventHandler(this.btn_flecha_seguinte_Click);
            // 
            // btn_flecha_volta
            // 
            this.btn_flecha_volta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_flecha_volta.Location = new System.Drawing.Point(599, 273);
            this.btn_flecha_volta.Name = "btn_flecha_volta";
            this.btn_flecha_volta.Size = new System.Drawing.Size(75, 23);
            this.btn_flecha_volta.TabIndex = 9;
            this.btn_flecha_volta.Text = "<";
            this.btn_flecha_volta.UseVisualStyleBackColor = true;
            this.btn_flecha_volta.Click += new System.EventHandler(this.btn_flecha_volta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(348, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "D )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(348, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "C )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(348, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "B )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(348, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "A )";
            // 
            // txt_d
            // 
            this.txt_d.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txt_d.Enabled = false;
            this.txt_d.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_d.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_d.Location = new System.Drawing.Point(371, 228);
            this.txt_d.Name = "txt_d";
            this.txt_d.ReadOnly = true;
            this.txt_d.Size = new System.Drawing.Size(552, 29);
            this.txt_d.TabIndex = 4;
            this.txt_d.WordWrap = false;
            // 
            // txt_c
            // 
            this.txt_c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txt_c.Enabled = false;
            this.txt_c.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_c.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_c.Location = new System.Drawing.Point(371, 186);
            this.txt_c.Name = "txt_c";
            this.txt_c.ReadOnly = true;
            this.txt_c.Size = new System.Drawing.Size(552, 29);
            this.txt_c.TabIndex = 3;
            this.txt_c.WordWrap = false;
            // 
            // txt_b
            // 
            this.txt_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txt_b.Enabled = false;
            this.txt_b.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_b.Location = new System.Drawing.Point(371, 141);
            this.txt_b.Name = "txt_b";
            this.txt_b.ReadOnly = true;
            this.txt_b.Size = new System.Drawing.Size(552, 29);
            this.txt_b.TabIndex = 2;
            this.txt_b.WordWrap = false;
            // 
            // txt_a
            // 
            this.txt_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txt_a.Enabled = false;
            this.txt_a.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_a.Location = new System.Drawing.Point(371, 102);
            this.txt_a.Name = "txt_a";
            this.txt_a.ReadOnly = true;
            this.txt_a.Size = new System.Drawing.Size(552, 29);
            this.txt_a.TabIndex = 1;
            this.txt_a.WordWrap = false;
            // 
            // txt_pergunta
            // 
            this.txt_pergunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.txt_pergunta.Enabled = false;
            this.txt_pergunta.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pergunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_pergunta.Location = new System.Drawing.Point(294, 40);
            this.txt_pergunta.Name = "txt_pergunta";
            this.txt_pergunta.ReadOnly = true;
            this.txt_pergunta.Size = new System.Drawing.Size(707, 29);
            this.txt_pergunta.TabIndex = 0;
            this.txt_pergunta.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha a matéria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_escolha
            // 
            this.cb_escolha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_escolha.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_escolha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cb_escolha.FormattingEnabled = true;
            this.cb_escolha.Items.AddRange(new object[] {
            "Python",
            "C#",
            "Java"});
            this.cb_escolha.Location = new System.Drawing.Point(227, 21);
            this.cb_escolha.Name = "cb_escolha";
            this.cb_escolha.Size = new System.Drawing.Size(121, 29);
            this.cb_escolha.TabIndex = 4;
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.tab2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab2.Controls.Add(this.label12);
            this.tab2.Controls.Add(this.chartResultados);
            this.tab2.Controls.Add(this.dataGridViewResultados);
            this.tab2.Location = new System.Drawing.Point(4, 44);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(1076, 432);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Resultados";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Variable Small", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label12.Location = new System.Drawing.Point(480, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 38);
            this.label12.TabIndex = 21;
            this.label12.Text = "Histórico";
            // 
            // chartResultados
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResultados.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResultados.Legends.Add(legend1);
            this.chartResultados.Location = new System.Drawing.Point(32, 121);
            this.chartResultados.Name = "chartResultados";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResultados.Series.Add(series1);
            this.chartResultados.Size = new System.Drawing.Size(379, 237);
            this.chartResultados.TabIndex = 1;
            this.chartResultados.Text = "chart1";
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Location = new System.Drawing.Point(447, 108);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.Size = new System.Drawing.Size(619, 293);
            this.dataGridViewResultados.TabIndex = 0;
            // 
            // tab3
            // 
            this.tab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.tab3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab3.Controls.Add(this.label9);
            this.tab3.Controls.Add(this.btn_eliminar);
            this.tab3.Controls.Add(this.btn_atualizar);
            this.tab3.Controls.Add(this.btn_inserir);
            this.tab3.Controls.Add(this.btn_Ver);
            this.tab3.Controls.Add(this.cb_nivel);
            this.tab3.Controls.Add(this.label10);
            this.tab3.Controls.Add(this.label8);
            this.tab3.Controls.Add(this.label7);
            this.tab3.Controls.Add(this.txt_pass);
            this.tab3.Controls.Add(this.txt_nome);
            this.tab3.Controls.Add(this.txt_id);
            this.tab3.Controls.Add(this.dataGridView1);
            this.tab3.Controls.Add(this.panel3);
            this.tab3.Location = new System.Drawing.Point(4, 44);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(1076, 432);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Gestão Utilizadores";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(578, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nível";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(814, 328);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(131, 32);
            this.btn_eliminar.TabIndex = 20;
            this.btn_eliminar.Text = "Eliminar user";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(814, 283);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(131, 32);
            this.btn_atualizar.TabIndex = 19;
            this.btn_atualizar.Text = "Atualizar User";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(814, 238);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(131, 32);
            this.btn_inserir.TabIndex = 18;
            this.btn_inserir.Text = "Inserir User";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_Ver
            // 
            this.btn_Ver.Location = new System.Drawing.Point(814, 198);
            this.btn_Ver.Name = "btn_Ver";
            this.btn_Ver.Size = new System.Drawing.Size(131, 32);
            this.btn_Ver.TabIndex = 17;
            this.btn_Ver.Text = "Ver Lista";
            this.btn_Ver.UseVisualStyleBackColor = true;
            this.btn_Ver.Click += new System.EventHandler(this.btn_Ver_Click);
            // 
            // cb_nivel
            // 
            this.cb_nivel.FormattingEnabled = true;
            this.cb_nivel.Items.AddRange(new object[] {
            "Administrador",
            "Aluno"});
            this.cb_nivel.Location = new System.Drawing.Point(585, 63);
            this.cb_nivel.Name = "cb_nivel";
            this.cb_nivel.Size = new System.Drawing.Size(108, 29);
            this.cb_nivel.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(578, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "ID";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(582, 123);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(111, 29);
            this.txt_pass.TabIndex = 4;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(381, 123);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 29);
            this.txt_nome.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(381, 63);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 29);
            this.txt_id.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ProjetoCSharp_BaseDados.Properties.Resources.Captura_de_ecrã_2026_02_24_230924;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 422);
            this.panel3.TabIndex = 16;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.roundedPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.Controls.Add(this.label6);
            this.roundedPanel1.Controls.Add(button1);
            this.roundedPanel1.Controls.Add(this.panel6);
            this.roundedPanel1.Controls.Add(this.label11);
            this.roundedPanel1.Controls.Add(this.lbl_data);
            this.roundedPanel1.Controls.Add(this.lbl_bem_vindo);
            this.roundedPanel1.Controls.Add(this.lbl_nivel);
            this.roundedPanel1.Location = new System.Drawing.Point(39, 12);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1080, 103);
            this.roundedPanel1.TabIndex = 21;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(144, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 36);
            this.label6.TabIndex = 3;
            this.label6.Text = "Apoio ";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.BackgroundImage = global::ProjetoCSharp_BaseDados.Properties.Resources.sair;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.ForeColor = System.Drawing.SystemColors.Control;
            button1.Location = new System.Drawing.Point(1025, 8);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(37, 38);
            button1.TabIndex = 11;
            button1.TabStop = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::ProjetoCSharp_BaseDados.Properties.Resources._2234794;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(42, 8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(96, 83);
            this.panel6.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(144, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 36);
            this.label11.TabIndex = 14;
            this.label11.Text = "ao Estudo";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.BackColor = System.Drawing.Color.Transparent;
            this.lbl_data.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.ForeColor = System.Drawing.Color.Black;
            this.lbl_data.Location = new System.Drawing.Point(499, 71);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(51, 20);
            this.lbl_data.TabIndex = 12;
            this.lbl_data.Text = "data";
            // 
            // lbl_bem_vindo
            // 
            this.lbl_bem_vindo.AutoSize = true;
            this.lbl_bem_vindo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bem_vindo.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bem_vindo.ForeColor = System.Drawing.Color.Black;
            this.lbl_bem_vindo.Location = new System.Drawing.Point(499, 30);
            this.lbl_bem_vindo.Name = "lbl_bem_vindo";
            this.lbl_bem_vindo.Size = new System.Drawing.Size(114, 20);
            this.lbl_bem_vindo.TabIndex = 0;
            this.lbl_bem_vindo.Text = "Bem vindo...";
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nivel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel.ForeColor = System.Drawing.Color.Black;
            this.lbl_nivel.Location = new System.Drawing.Point(499, 51);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(54, 20);
            this.lbl_nivel.TabIndex = 1;
            this.lbl_nivel.Text = "Nível";
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.BackgroundImage = global::ProjetoCSharp_BaseDados.Properties.Resources.Captura_de_ecrã_2026_02_28_195026;
            this.ClientSize = new System.Drawing.Size(1150, 621);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.tab_questoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Menu";
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.tab_questoes.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.tab3.ResumeLayout(false);
            this.tab3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_bem_vindo;
        private System.Windows.Forms.Label lbl_nivel;
        private System.Windows.Forms.TabControl tab_questoes;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.ComboBox cb_escolha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_pergunta;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_flecha_seguinte;
        private System.Windows.Forms.Button btn_flecha_volta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton cb_d;
        private System.Windows.Forms.RadioButton cb_b;
        private System.Windows.Forms.RadioButton cb_c;
        private System.Windows.Forms.RadioButton cb_a;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_nivel;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_Ver;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResultados;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label12;
        private RoundedPanel roundedPanel1;
    }
}