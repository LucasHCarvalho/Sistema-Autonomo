
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
            System.Windows.Forms.Button btnAtualizaJogador;
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
            this.pcVermelho = new System.Windows.Forms.PictureBox();
            this.pcAzul = new System.Windows.Forms.PictureBox();
            this.pcAmarelo = new System.Windows.Forms.PictureBox();
            this.pcVerde = new System.Windows.Forms.PictureBox();
            this.lblVermelho = new System.Windows.Forms.Label();
            this.lblAmarelo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblAzul = new System.Windows.Forms.Label();
            this.lstListarJogadores = new System.Windows.Forms.ListBox();
            btnAtualizaJogador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcVerde)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizaJogador
            // 
            btnAtualizaJogador.BackColor = System.Drawing.Color.Transparent;
            btnAtualizaJogador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizaJogador.BackgroundImage")));
            btnAtualizaJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnAtualizaJogador.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAtualizaJogador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAtualizaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAtualizaJogador.ForeColor = System.Drawing.Color.LightSeaGreen;
            btnAtualizaJogador.Location = new System.Drawing.Point(671, 6);
            btnAtualizaJogador.Name = "btnAtualizaJogador";
            btnAtualizaJogador.Size = new System.Drawing.Size(32, 26);
            btnAtualizaJogador.TabIndex = 22;
            btnAtualizaJogador.UseVisualStyleBackColor = false;
            btnAtualizaJogador.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstListarPartidas
            // 
            this.lstListarPartidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(124)))));
            this.lstListarPartidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstListarPartidas.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListarPartidas.ForeColor = System.Drawing.Color.IndianRed;
            this.lstListarPartidas.ItemHeight = 16;
            this.lstListarPartidas.Location = new System.Drawing.Point(6, 27);
            this.lstListarPartidas.Name = "lstListarPartidas";
            this.lstListarPartidas.Size = new System.Drawing.Size(249, 432);
            this.lstListarPartidas.TabIndex = 1;
            this.lstListarPartidas.SelectedIndexChanged += new System.EventHandler(this.lstListarPartidas_SelectedIndexChanged_2);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(124)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnEntrar.Location = new System.Drawing.Point(364, 214);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(112, 81);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar na Partida";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(124)))));
            this.btnCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriar.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnCriar.Location = new System.Drawing.Point(484, 214);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(112, 81);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar Partida";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtCriarPartida
            // 
            this.txtCriarPartida.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriarPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtCriarPartida.Location = new System.Drawing.Point(364, 72);
            this.txtCriarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.txtCriarPartida.Name = "txtCriarPartida";
            this.txtCriarPartida.Size = new System.Drawing.Size(234, 24);
            this.txtCriarPartida.TabIndex = 6;
            // 
            // lblCriarPartida
            // 
            this.lblCriarPartida.AutoSize = true;
            this.lblCriarPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblCriarPartida.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarPartida.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCriarPartida.Location = new System.Drawing.Point(394, 50);
            this.lblCriarPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCriarPartida.Name = "lblCriarPartida";
            this.lblCriarPartida.Size = new System.Drawing.Size(180, 17);
            this.lblCriarPartida.TabIndex = 7;
            this.lblCriarPartida.Text = "Digite o nome da partida";
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJogador.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNomeJogador.Location = new System.Drawing.Point(423, 96);
            this.lblNomeJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(122, 17);
            this.lblNomeJogador.TabIndex = 10;
            this.lblNomeJogador.Text = "Digite seu nome";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtNomeJogador.Location = new System.Drawing.Point(367, 116);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(230, 24);
            this.txtNomeJogador.TabIndex = 11;
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaPartida.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPartida.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSenhaPartida.Location = new System.Drawing.Point(394, 151);
            this.lblSenhaPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(181, 17);
            this.lblSenhaPartida.TabIndex = 12;
            this.lblSenhaPartida.Text = "Digite a senha da partida";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtSenhaPartida.Location = new System.Drawing.Point(367, 176);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(230, 24);
            this.txtSenhaPartida.TabIndex = 13;
            // 
            // lstListaJogadores
            // 
            this.lstListaJogadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(124)))));
            this.lstListaJogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstListaJogadores.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaJogadores.ForeColor = System.Drawing.Color.IndianRed;
            this.lstListaJogadores.FormattingEnabled = true;
            this.lstListaJogadores.ItemHeight = 20;
            this.lstListaJogadores.Location = new System.Drawing.Point(364, 13);
            this.lstListaJogadores.Margin = new System.Windows.Forms.Padding(2);
            this.lstListaJogadores.Name = "lstListaJogadores";
            this.lstListaJogadores.Size = new System.Drawing.Size(241, 20);
            this.lstListaJogadores.TabIndex = 14;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVersao.Location = new System.Drawing.Point(3, 488);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(56, 17);
            this.lblVersao.TabIndex = 15;
            this.lblVersao.Text = "Versão\r\n";
            // 
            // lblTratativaErro
            // 
            this.lblTratativaErro.AutoSize = true;
            this.lblTratativaErro.BackColor = System.Drawing.Color.Transparent;
            this.lblTratativaErro.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratativaErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.lblTratativaErro.Location = new System.Drawing.Point(415, 431);
            this.lblTratativaErro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTratativaErro.Name = "lblTratativaErro";
            this.lblTratativaErro.Size = new System.Drawing.Size(0, 17);
            this.lblTratativaErro.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(709, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Jogadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Partidas";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(124)))));
            this.btnIniciarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnIniciarPartida.Location = new System.Drawing.Point(426, 298);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(112, 81);
            this.btnIniciarPartida.TabIndex = 17;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click_1);
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
            this.btnMostraLista.Location = new System.Drawing.Point(261, 27);
            this.btnMostraLista.Name = "btnMostraLista";
            this.btnMostraLista.Size = new System.Drawing.Size(32, 26);
            this.btnMostraLista.TabIndex = 0;
            this.btnMostraLista.UseVisualStyleBackColor = false;
            this.btnMostraLista.Click += new System.EventHandler(this.btnMostraLista_Click);
            // 
            // pcVermelho
            // 
            this.pcVermelho.BackColor = System.Drawing.Color.Transparent;
            this.pcVermelho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcVermelho.BackgroundImage")));
            this.pcVermelho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcVermelho.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcVermelho.Location = new System.Drawing.Point(712, 44);
            this.pcVermelho.Margin = new System.Windows.Forms.Padding(2);
            this.pcVermelho.Name = "pcVermelho";
            this.pcVermelho.Size = new System.Drawing.Size(68, 71);
            this.pcVermelho.TabIndex = 26;
            this.pcVermelho.TabStop = false;
            this.pcVermelho.Visible = false;
            // 
            // pcAzul
            // 
            this.pcAzul.BackColor = System.Drawing.Color.Transparent;
            this.pcAzul.BackgroundImage = global::Cant_stop.Properties.Resources.jogadorazulA;
            this.pcAzul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcAzul.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcAzul.Location = new System.Drawing.Point(712, 151);
            this.pcAzul.Margin = new System.Windows.Forms.Padding(2);
            this.pcAzul.Name = "pcAzul";
            this.pcAzul.Size = new System.Drawing.Size(68, 71);
            this.pcAzul.TabIndex = 29;
            this.pcAzul.TabStop = false;
            this.pcAzul.Visible = false;
            // 
            // pcAmarelo
            // 
            this.pcAmarelo.BackColor = System.Drawing.Color.Transparent;
            this.pcAmarelo.BackgroundImage = global::Cant_stop.Properties.Resources.jogadoramareloA;
            this.pcAmarelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcAmarelo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcAmarelo.Location = new System.Drawing.Point(712, 369);
            this.pcAmarelo.Margin = new System.Windows.Forms.Padding(2);
            this.pcAmarelo.Name = "pcAmarelo";
            this.pcAmarelo.Size = new System.Drawing.Size(68, 71);
            this.pcAmarelo.TabIndex = 27;
            this.pcAmarelo.TabStop = false;
            this.pcAmarelo.Visible = false;
            // 
            // pcVerde
            // 
            this.pcVerde.BackColor = System.Drawing.Color.Transparent;
            this.pcVerde.BackgroundImage = global::Cant_stop.Properties.Resources.jogadorverdeA;
            this.pcVerde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcVerde.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcVerde.Location = new System.Drawing.Point(712, 258);
            this.pcVerde.Margin = new System.Windows.Forms.Padding(2);
            this.pcVerde.Name = "pcVerde";
            this.pcVerde.Size = new System.Drawing.Size(68, 71);
            this.pcVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcVerde.TabIndex = 28;
            this.pcVerde.TabStop = false;
            this.pcVerde.Visible = false;
            // 
            // lblVermelho
            // 
            this.lblVermelho.AutoSize = true;
            this.lblVermelho.BackColor = System.Drawing.Color.Transparent;
            this.lblVermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVermelho.ForeColor = System.Drawing.Color.Red;
            this.lblVermelho.Location = new System.Drawing.Point(717, 119);
            this.lblVermelho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVermelho.Name = "lblVermelho";
            this.lblVermelho.Size = new System.Drawing.Size(0, 20);
            this.lblVermelho.TabIndex = 30;
            // 
            // lblAmarelo
            // 
            this.lblAmarelo.AutoSize = true;
            this.lblAmarelo.BackColor = System.Drawing.Color.Transparent;
            this.lblAmarelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmarelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAmarelo.Location = new System.Drawing.Point(717, 442);
            this.lblAmarelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmarelo.Name = "lblAmarelo";
            this.lblAmarelo.Size = new System.Drawing.Size(0, 20);
            this.lblAmarelo.TabIndex = 31;
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.BackColor = System.Drawing.Color.Transparent;
            this.lblVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblVerde.Location = new System.Drawing.Point(717, 332);
            this.lblVerde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(0, 20);
            this.lblVerde.TabIndex = 32;
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.BackColor = System.Drawing.Color.Transparent;
            this.lblAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzul.ForeColor = System.Drawing.Color.Blue;
            this.lblAzul.Location = new System.Drawing.Point(717, 227);
            this.lblAzul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(0, 20);
            this.lblAzul.TabIndex = 33;
            // 
            // lstListarJogadores
            // 
            this.lstListarJogadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(124)))));
            this.lstListarJogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstListarJogadores.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListarJogadores.ForeColor = System.Drawing.Color.IndianRed;
            this.lstListarJogadores.FormattingEnabled = true;
            this.lstListarJogadores.ItemHeight = 20;
            this.lstListarJogadores.Location = new System.Drawing.Point(671, 488);
            this.lstListarJogadores.Margin = new System.Windows.Forms.Padding(2);
            this.lstListarJogadores.Name = "lstListarJogadores";
            this.lstListarJogadores.Size = new System.Drawing.Size(241, 20);
            this.lstListarJogadores.TabIndex = 14;
            this.lstListarJogadores.Visible = false;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = global::Cant_stop.Properties.Resources.salmonlobby;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 506);
            this.Controls.Add(this.lblAzul);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblAmarelo);
            this.Controls.Add(this.lblVermelho);
            this.Controls.Add(this.pcAzul);
            this.Controls.Add(this.pcVerde);
            this.Controls.Add(this.pcAmarelo);
            this.Controls.Add(this.pcVermelho);
            this.Controls.Add(btnAtualizaJogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTratativaErro);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lstListarJogadores);
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
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lobby";
            this.Text = "Lobby";
            ((System.ComponentModel.ISupportInitialize)(this.pcVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcVerde)).EndInit();
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
        private System.Windows.Forms.PictureBox pcVermelho;
        private System.Windows.Forms.PictureBox pcAzul;
        private System.Windows.Forms.PictureBox pcAmarelo;
        private System.Windows.Forms.PictureBox pcVerde;
        private System.Windows.Forms.Label lblVermelho;
        private System.Windows.Forms.Label lblAmarelo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.ListBox lstListarJogadores;
    }
}

