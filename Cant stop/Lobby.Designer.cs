
namespace Cant_stop
{
    partial class Lobby
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostraLista = new System.Windows.Forms.Button();
            this.lstListarPartidas = new System.Windows.Forms.ListBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnListaJogadores = new System.Windows.Forms.Button();
            this.txtCriarPartida = new System.Windows.Forms.TextBox();
            this.lblCriarPartida = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lstListaJogadores = new System.Windows.Forms.ListBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblTratativaErro = new System.Windows.Forms.Label();
            this.lblCriarErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostraLista
            // 
            this.btnMostraLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostraLista.Location = new System.Drawing.Point(3, 346);
            this.btnMostraLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostraLista.Name = "btnMostraLista";
            this.btnMostraLista.Size = new System.Drawing.Size(171, 63);
            this.btnMostraLista.TabIndex = 0;
            this.btnMostraLista.Text = "Mostra Lista";
            this.btnMostraLista.UseVisualStyleBackColor = true;
            this.btnMostraLista.Click += new System.EventHandler(this.btnMostraLista_Click);
            // 
            // lstListarPartidas
            // 
            this.lstListarPartidas.BackColor = System.Drawing.SystemColors.Menu;
            this.lstListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListarPartidas.ItemHeight = 22;
            this.lstListarPartidas.Location = new System.Drawing.Point(3, 7);
            this.lstListarPartidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstListarPartidas.Name = "lstListarPartidas";
            this.lstListarPartidas.Size = new System.Drawing.Size(369, 312);
            this.lstListarPartidas.TabIndex = 1;
            this.lstListarPartidas.SelectedIndexChanged += new System.EventHandler(this.lstListarPartidas_SelectedIndexChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(724, 288);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(113, 57);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar na Partida";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(463, 284);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(115, 60);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar Partida";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnListaJogadores
            // 
            this.btnListaJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaJogadores.Location = new System.Drawing.Point(923, 7);
            this.btnListaJogadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListaJogadores.Name = "btnListaJogadores";
            this.btnListaJogadores.Size = new System.Drawing.Size(111, 60);
            this.btnListaJogadores.TabIndex = 5;
            this.btnListaJogadores.Text = "Listar Jogadores";
            this.btnListaJogadores.UseVisualStyleBackColor = true;
            this.btnListaJogadores.Click += new System.EventHandler(this.btnListaJogadores_Click);
            // 
            // txtCriarPartida
            // 
            this.txtCriarPartida.Location = new System.Drawing.Point(408, 176);
            this.txtCriarPartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCriarPartida.Name = "txtCriarPartida";
            this.txtCriarPartida.Size = new System.Drawing.Size(237, 22);
            this.txtCriarPartida.TabIndex = 6;
            this.txtCriarPartida.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCriarPartida
            // 
            this.lblCriarPartida.AutoSize = true;
            this.lblCriarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarPartida.Location = new System.Drawing.Point(407, 149);
            this.lblCriarPartida.Name = "lblCriarPartida";
            this.lblCriarPartida.Size = new System.Drawing.Size(238, 24);
            this.lblCriarPartida.TabIndex = 7;
            this.lblCriarPartida.Text = "Digite o nome da partida";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSenhaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPartida.Location = new System.Drawing.Point(404, 224);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(241, 24);
            this.lblSenhaPartida.TabIndex = 8;
            this.lblSenhaPartida.Text = "Digite a senha da partida";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(408, 256);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(232, 22);
            this.txtSenhaPartida.TabIndex = 9;
            this.txtSenhaPartida.TextChanged += new System.EventHandler(this.txtSenhaPartida_TextChanged);
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.Location = new System.Drawing.Point(769, 149);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(162, 24);
            this.lblNomeJogador.TabIndex = 10;
            this.lblNomeJogador.Text = "Digite seu nome";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(733, 176);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(233, 22);
            this.txtNomeJogador.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(743, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Digite a senha da partida";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(733, 256);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(233, 22);
            this.txtSenha.TabIndex = 13;
            // 
            // lstListaJogadores
            // 
            this.lstListaJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaJogadores.FormattingEnabled = true;
            this.lstListaJogadores.ItemHeight = 22;
            this.lstListaJogadores.Location = new System.Drawing.Point(1039, 7);
            this.lstListaJogadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstListaJogadores.Name = "lstListaJogadores";
            this.lstListaJogadores.Size = new System.Drawing.Size(225, 70);
            this.lstListaJogadores.TabIndex = 14;
            this.lstListaJogadores.SelectedIndexChanged += new System.EventHandler(this.lstListaJogadores_SelectedIndexChanged);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVersao.Location = new System.Drawing.Point(-3, 480);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(68, 20);
            this.lblVersao.TabIndex = 15;
            this.lblVersao.Text = "Versão\r\n";
            this.lblVersao.Click += new System.EventHandler(this.lblversao_Click);
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.Location = new System.Drawing.Point(853, 288);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(115, 57);
            this.btnIniciarPartida.TabIndex = 17;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblTratativaErro
            // 
            this.lblTratativaErro.AutoSize = true;
            this.lblTratativaErro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTratativaErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratativaErro.Location = new System.Drawing.Point(720, 418);
            this.lblTratativaErro.Name = "lblTratativaErro";
            this.lblTratativaErro.Size = new System.Drawing.Size(0, 24);
            this.lblTratativaErro.TabIndex = 18;
            this.lblTratativaErro.Click += new System.EventHandler(this.lblTratativaErro_Click);
            // 
            // lblCriarErro
            // 
            this.lblCriarErro.AutoSize = true;
            this.lblCriarErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarErro.Location = new System.Drawing.Point(495, 423);
            this.lblCriarErro.Name = "lblCriarErro";
            this.lblCriarErro.Size = new System.Drawing.Size(0, 20);
            this.lblCriarErro.TabIndex = 19;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1276, 498);
            this.Controls.Add(this.lblCriarErro);
            this.Controls.Add(this.lblTratativaErro);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lstListaJogadores);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.lblCriarPartida);
            this.Controls.Add(this.txtCriarPartida);
            this.Controls.Add(this.btnListaJogadores);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lstListarPartidas);
            this.Controls.Add(this.btnMostraLista);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Lobby";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostraLista;
        private System.Windows.Forms.ListBox lstListarPartidas;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnListaJogadores;
        private System.Windows.Forms.TextBox txtCriarPartida;
        private System.Windows.Forms.Label lblCriarPartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ListBox lstListaJogadores;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblTratativaErro;
        private System.Windows.Forms.Label lblCriarErro;
    }
}

