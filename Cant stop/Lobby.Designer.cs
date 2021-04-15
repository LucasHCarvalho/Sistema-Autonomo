
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            this.lstListarPartidas = new System.Windows.Forms.ListBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.txtCriarPartida = new System.Windows.Forms.TextBox();
            this.lblCriarPartida = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.lstListaJogadores = new System.Windows.Forms.ListBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblTratativaErro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.btnMostraLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListarPartidas
            // 
            this.lstListarPartidas.BackColor = System.Drawing.Color.DarkGray;
            this.lstListarPartidas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListarPartidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lstListarPartidas.ItemHeight = 22;
            this.lstListarPartidas.Location = new System.Drawing.Point(3, 25);
            this.lstListarPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.lstListarPartidas.Name = "lstListarPartidas";
            this.lstListarPartidas.Size = new System.Drawing.Size(279, 400);
            this.lstListarPartidas.TabIndex = 1;
            this.lstListarPartidas.SelectedIndexChanged += new System.EventHandler(this.lstListarPartidas_SelectedIndexChanged_2);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Turquoise;
            this.btnEntrar.Location = new System.Drawing.Point(450, 213);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(125, 85);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar na Partida";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.Transparent;
            this.btnCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.Color.Turquoise;
            this.btnCriar.Location = new System.Drawing.Point(581, 213);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(115, 85);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar Partida";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtCriarPartida
            // 
            this.txtCriarPartida.Location = new System.Drawing.Point(459, 43);
            this.txtCriarPartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCriarPartida.Name = "txtCriarPartida";
            this.txtCriarPartida.Size = new System.Drawing.Size(237, 22);
            this.txtCriarPartida.TabIndex = 6;
            // 
            // lblCriarPartida
            // 
            this.lblCriarPartida.AutoSize = true;
            this.lblCriarPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblCriarPartida.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarPartida.ForeColor = System.Drawing.Color.Blue;
            this.lblCriarPartida.Location = new System.Drawing.Point(466, 16);
            this.lblCriarPartida.Name = "lblCriarPartida";
            this.lblCriarPartida.Size = new System.Drawing.Size(237, 23);
            this.lblCriarPartida.TabIndex = 7;
            this.lblCriarPartida.Text = "Digite o nome da partida";
            this.lblCriarPartida.Click += new System.EventHandler(this.lblCriarPartida_Click);
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJogador.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.ForeColor = System.Drawing.Color.Blue;
            this.lblNomeJogador.Location = new System.Drawing.Point(499, 78);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(154, 23);
            this.lblNomeJogador.TabIndex = 10;
            this.lblNomeJogador.Text = "Digite seu nome";
            this.lblNomeJogador.Click += new System.EventHandler(this.lblNomeJogador_Click);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(459, 101);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(233, 22);
            this.txtNomeJogador.TabIndex = 11;
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaPartida.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPartida.ForeColor = System.Drawing.Color.Blue;
            this.lblSenhaPartida.Location = new System.Drawing.Point(455, 149);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(242, 23);
            this.lblSenhaPartida.TabIndex = 12;
            this.lblSenhaPartida.Text = "Digite a senha da partida";
            this.lblSenhaPartida.Click += new System.EventHandler(this.lblSenhaJogador_Click);
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(459, 174);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(237, 22);
            this.txtSenhaPartida.TabIndex = 13;
            this.txtSenhaPartida.TextChanged += new System.EventHandler(this.txtSenhaPartida_TextChanged_1);
            // 
            // lstListaJogadores
            // 
            this.lstListaJogadores.BackColor = System.Drawing.Color.Gainsboro;
            this.lstListaJogadores.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaJogadores.ForeColor = System.Drawing.Color.Indigo;
            this.lstListaJogadores.FormattingEnabled = true;
            this.lstListaJogadores.ItemHeight = 22;
            this.lstListaJogadores.Location = new System.Drawing.Point(823, 32);
            this.lstListaJogadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstListaJogadores.Name = "lstListaJogadores";
            this.lstListaJogadores.Size = new System.Drawing.Size(225, 180);
            this.lstListaJogadores.TabIndex = 14;
            this.lstListaJogadores.SelectedIndexChanged += new System.EventHandler(this.lstListaJogadores_SelectedIndexChanged);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVersao.Location = new System.Drawing.Point(-1, 470);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(68, 20);
            this.lblVersao.TabIndex = 15;
            this.lblVersao.Text = "Versão\r\n";
            // 
            // lblTratativaErro
            // 
            this.lblTratativaErro.AutoSize = true;
            this.lblTratativaErro.BackColor = System.Drawing.Color.Transparent;
            this.lblTratativaErro.Font = new System.Drawing.Font("Papyrus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratativaErro.ForeColor = System.Drawing.Color.Lime;
            this.lblTratativaErro.Location = new System.Drawing.Point(469, 405);
            this.lblTratativaErro.Name = "lblTratativaErro";
            this.lblTratativaErro.Size = new System.Drawing.Size(0, 30);
            this.lblTratativaErro.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(819, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Jogadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Partidas";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.Color.Turquoise;
            this.btnIniciarPartida.Location = new System.Drawing.Point(516, 302);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(132, 85);
            this.btnIniciarPartida.TabIndex = 17;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnMostraLista
            // 
            this.btnMostraLista.BackColor = System.Drawing.Color.Transparent;
            this.btnMostraLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostraLista.BackgroundImage")));
            this.btnMostraLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostraLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostraLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostraLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostraLista.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnMostraLista.Location = new System.Drawing.Point(290, 25);
            this.btnMostraLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostraLista.Name = "btnMostraLista";
            this.btnMostraLista.Size = new System.Drawing.Size(42, 32);
            this.btnMostraLista.TabIndex = 0;
            this.btnMostraLista.UseVisualStyleBackColor = false;
            this.btnMostraLista.Click += new System.EventHandler(this.btnMostraLista_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = global::Cant_stop.Properties.Resources.FundoLobby;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTratativaErro);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lstListaJogadores);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.lblCriarPartida);
            this.Controls.Add(this.txtCriarPartida);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lstListarPartidas);
            this.Controls.Add(this.btnMostraLista);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lobby";
            this.Text = "Lobby Can\'t Stop";
            this.Load += new System.EventHandler(this.Lobby_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostraLista;
        private System.Windows.Forms.ListBox lstListarPartidas;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox txtCriarPartida;
        private System.Windows.Forms.Label lblCriarPartida;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.ListBox lstListaJogadores;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblTratativaErro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

