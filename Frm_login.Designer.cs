namespace ProjetoCSharp_BaseDados
{
    partial class Frm_login
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
            System.Windows.Forms.Button button1;
            this.lbl_senha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new ProjetoCSharp_BaseDados.RoundedPanel();
            this.txt_utilizador = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_erro = new System.Windows.Forms.Label();
            this.chk_mostrarSenha = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedPanel2 = new ProjetoCSharp_BaseDados.RoundedPanel();
            button1 = new System.Windows.Forms.Button();
            this.roundedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.BackgroundImage = global::ProjetoCSharp_BaseDados.Properties.Resources.sair;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.SystemColors.Control;
            button1.Location = new System.Drawing.Point(256, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(34, 33);
            button1.TabIndex = 10;
            button1.TabStop = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_senha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(3, 179);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(0, 13);
            this.lbl_senha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(52, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ProjetoCSharp_BaseDados.Properties.Resources._10859171;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(127, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 42);
            this.panel2.TabIndex = 11;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.roundedPanel1.Location = new System.Drawing.Point(34, 62);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(241, 311);
            this.roundedPanel1.TabIndex = 12;
            // 
            // txt_utilizador
            // 
            this.txt_utilizador.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_utilizador.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_utilizador.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_utilizador.Location = new System.Drawing.Point(64, 91);
            this.txt_utilizador.Name = "txt_utilizador";
            this.txt_utilizador.ShortcutsEnabled = false;
            this.txt_utilizador.Size = new System.Drawing.Size(135, 22);
            this.txt_utilizador.TabIndex = 0;
            this.txt_utilizador.TextChanged += new System.EventHandler(this.txt_utilizador_TextChanged_1);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_login.Location = new System.Drawing.Point(49, 191);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(126, 43);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_senha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_senha.Location = new System.Drawing.Point(64, 145);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(102, 22);
            this.txt_senha.TabIndex = 1;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // lbl_erro
            // 
            this.lbl_erro.AutoSize = true;
            this.lbl_erro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_erro.Location = new System.Drawing.Point(33, 237);
            this.lbl_erro.Name = "lbl_erro";
            this.lbl_erro.Size = new System.Drawing.Size(114, 13);
            this.lbl_erro.TabIndex = 12;
            this.lbl_erro.Text = "Erro ao efetuar login";
            this.lbl_erro.Visible = false;
            // 
            // chk_mostrarSenha
            // 
            this.chk_mostrarSenha.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_mostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.chk_mostrarSenha.BackgroundImage = global::ProjetoCSharp_BaseDados.Properties.Resources.opcao_de_interface_de_olho_aberto_visivel;
            this.chk_mostrarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chk_mostrarSenha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_mostrarSenha.ForeColor = System.Drawing.Color.Transparent;
            this.chk_mostrarSenha.Location = new System.Drawing.Point(172, 145);
            this.chk_mostrarSenha.Name = "chk_mostrarSenha";
            this.chk_mostrarSenha.Size = new System.Drawing.Size(27, 22);
            this.chk_mostrarSenha.TabIndex = 11;
            this.chk_mostrarSenha.UseMnemonic = false;
            this.chk_mostrarSenha.UseVisualStyleBackColor = false;
            this.chk_mostrarSenha.CheckedChanged += new System.EventHandler(this.chk_mostrarSenha_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Senha";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackgroundImage = global::ProjetoCSharp_BaseDados.Properties.Resources._102643;
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(26, 142);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(32, 25);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Utilizador";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::ProjetoCSharp_BaseDados.Properties.Resources._123;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(34, 29);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.roundedPanel2.BorderRadius = 30;
            this.roundedPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundedPanel2.Controls.Add(this.flowLayoutPanel1);
            this.roundedPanel2.Controls.Add(this.label1);
            this.roundedPanel2.Controls.Add(this.label2);
            this.roundedPanel2.Controls.Add(this.flowLayoutPanel2);
            this.roundedPanel2.Controls.Add(this.label3);
            this.roundedPanel2.Controls.Add(this.chk_mostrarSenha);
            this.roundedPanel2.Controls.Add(this.lbl_erro);
            this.roundedPanel2.Controls.Add(this.txt_senha);
            this.roundedPanel2.Controls.Add(this.btn_login);
            this.roundedPanel2.Controls.Add(this.txt_utilizador);
            this.roundedPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.roundedPanel2.Location = new System.Drawing.Point(45, 62);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(230, 298);
            this.roundedPanel2.TabIndex = 15;
            // 
            // Frm_login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.BackgroundImage = global::ProjetoCSharp_BaseDados.Properties.Resources.Captura_de_ecrã_2026_02_28_195026;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(304, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(button1);
            this.Controls.Add(this.lbl_senha);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private RoundedPanel roundedPanel1;
        public System.Windows.Forms.TextBox txt_utilizador;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_erro;
        private System.Windows.Forms.CheckBox chk_mostrarSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RoundedPanel roundedPanel2;
    }
}