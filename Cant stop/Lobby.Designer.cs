
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
            this.lstListarPartidas.BackColor = System.Drawing.SystemColors.Menu;
            this.lstListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListarPartidas.ItemHeight = 18;
            this.lstListarPartidas.Location = new System.Drawing.Point(3, 51);
            this.lstListarPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.lstListarPartidas.Name = "lstListarPartidas";
            this.lstListarPartidas.Size = new System.Drawing.Size(260, 418);
            this.lstListarPartidas.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(450, 213);
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
            this.btnCriar.Location = new System.Drawing.Point(581, 213);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(115, 60);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar Partida";
            this.btnCriar.UseVisualStyleBackColor = true;
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
            this.lblCriarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarPartida.Location = new System.Drawing.Point(458, 16);
            this.lblCriarPartida.Name = "lblCriarPartida";
            this.lblCriarPartida.Size = new System.Drawing.Size(238, 24);
            this.lblCriarPartida.TabIndex = 7;
            this.lblCriarPartida.Text = "Digite o nome da partida";
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.Location = new System.Drawing.Point(495, 74);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(162, 24);
            this.lblNomeJogador.TabIndex = 10;
            this.lblNomeJogador.Text = "Digite seu nome";
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
            this.lblSenhaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPartida.Location = new System.Drawing.Point(455, 139);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(241, 24);
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
            this.lstListaJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaJogadores.FormattingEnabled = true;
            this.lstListaJogadores.ItemHeight = 18;
            this.lstListaJogadores.Location = new System.Drawing.Point(823, 32);
            this.lstListaJogadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstListaJogadores.Name = "lstListaJogadores";
            this.lstListaJogadores.Size = new System.Drawing.Size(225, 184);
            this.lstListaJogadores.TabIndex = 14;
            this.lstListaJogadores.SelectedIndexChanged += new System.EventHandler(this.lstListaJogadores_SelectedIndexChanged);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVersao.Location = new System.Drawing.Point(-1, 473);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(68, 20);
            this.lblVersao.TabIndex = 15;
            this.lblVersao.Text = "Versão\r\n";
            // 
            // lblTratativaErro
            // 
            this.lblTratativaErro.AutoSize = true;
            this.lblTratativaErro.BackColor = System.Drawing.Color.Transparent;
            this.lblTratativaErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratativaErro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTratativaErro.Location = new System.Drawing.Point(507, 363);
            this.lblTratativaErro.Name = "lblTratativaErro";
            this.lblTratativaErro.Size = new System.Drawing.Size(0, 24);
            this.lblTratativaErro.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(835, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Jogadores: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Partidas: ";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.Location = new System.Drawing.Point(511, 277);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(115, 57);
            this.btnIniciarPartida.TabIndex = 17;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnMostraLista
            // 
            this.btnMostraLista.BackColor = System.Drawing.Color.Transparent;
            this.btnMostraLista.BackgroundImage = global::Cant_stop.Properties.Resources.refresh;
            this.btnMostraLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostraLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostraLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostraLista.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMostraLista.Location = new System.Drawing.Point(271, 59);
            this.btnMostraLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostraLista.Name = "btnMostraLista";
            this.btnMostraLista.Size = new System.Drawing.Size(45, 39);
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

