
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
            this.lblSenhaJogador = new System.Windows.Forms.Label();
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
            this.btnMostraLista.Location = new System.Drawing.Point(2, 281);
            this.btnMostraLista.Name = "btnMostraLista";
            this.btnMostraLista.Size = new System.Drawing.Size(128, 51);
            this.btnMostraLista.TabIndex = 0;
            this.btnMostraLista.Text = "Mostra Lista";
            this.btnMostraLista.UseVisualStyleBackColor = true;
            this.btnMostraLista.Click += new System.EventHandler(this.btnMostraLista_Click);
            // 
            // lstListarPartidas
            // 
            this.lstListarPartidas.BackColor = System.Drawing.SystemColors.Menu;
            this.lstListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListarPartidas.ItemHeight = 17;
            this.lstListarPartidas.Location = new System.Drawing.Point(2, 6);
            this.lstListarPartidas.Name = "lstListarPartidas";
            this.lstListarPartidas.Size = new System.Drawing.Size(278, 242);
            this.lstListarPartidas.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(543, 234);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(85, 46);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar na Partida";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(347, 231);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(86, 49);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar Partida";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnListaJogadores
            // 
            this.btnListaJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaJogadores.Location = new System.Drawing.Point(692, 6);
            this.btnListaJogadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListaJogadores.Name = "btnListaJogadores";
            this.btnListaJogadores.Size = new System.Drawing.Size(83, 49);
            this.btnListaJogadores.TabIndex = 5;
            this.btnListaJogadores.Text = "Listar Jogadores";
            this.btnListaJogadores.UseVisualStyleBackColor = true;
            this.btnListaJogadores.Click += new System.EventHandler(this.btnListaJogadores_Click);
            // 
            // txtCriarPartida
            // 
            this.txtCriarPartida.Location = new System.Drawing.Point(306, 143);
            this.txtCriarPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCriarPartida.Name = "txtCriarPartida";
            this.txtCriarPartida.Size = new System.Drawing.Size(179, 20);
            this.txtCriarPartida.TabIndex = 6;
            // 
            // lblCriarPartida
            // 
            this.lblCriarPartida.AutoSize = true;
            this.lblCriarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarPartida.Location = new System.Drawing.Point(305, 121);
            this.lblCriarPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCriarPartida.Name = "lblCriarPartida";
            this.lblCriarPartida.Size = new System.Drawing.Size(192, 18);
            this.lblCriarPartida.TabIndex = 7;
            this.lblCriarPartida.Text = "Digite o nome da partida";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSenhaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPartida.Location = new System.Drawing.Point(303, 182);
            this.lblSenhaPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(194, 18);
            this.lblSenhaPartida.TabIndex = 8;
            this.lblSenhaPartida.Text = "Digite a senha da partida";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(306, 208);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(175, 20);
            this.txtSenhaPartida.TabIndex = 9;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.Location = new System.Drawing.Point(577, 121);
            this.lblNomeJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(130, 18);
            this.lblNomeJogador.TabIndex = 10;
            this.lblNomeJogador.Text = "Digite seu nome";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(550, 143);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(176, 20);
            this.txtNomeJogador.TabIndex = 11;
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogador.Location = new System.Drawing.Point(557, 182);
            this.lblSenhaJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(194, 18);
            this.lblSenhaJogador.TabIndex = 12;
            this.lblSenhaJogador.Text = "Digite a senha da partida";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(550, 208);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(176, 20);
            this.txtSenha.TabIndex = 13;
            // 
            // lstListaJogadores
            // 
            this.lstListaJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaJogadores.FormattingEnabled = true;
            this.lstListaJogadores.ItemHeight = 17;
            this.lstListaJogadores.Location = new System.Drawing.Point(779, 6);
            this.lstListaJogadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstListaJogadores.Name = "lstListaJogadores";
            this.lstListaJogadores.Size = new System.Drawing.Size(170, 55);
            this.lstListaJogadores.TabIndex = 14;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVersao.Location = new System.Drawing.Point(-2, 390);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(59, 17);
            this.lblVersao.TabIndex = 15;
            this.lblVersao.Text = "Versão\r\n";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.Location = new System.Drawing.Point(640, 234);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(86, 46);
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
            this.lblTratativaErro.Location = new System.Drawing.Point(540, 340);
            this.lblTratativaErro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTratativaErro.Name = "lblTratativaErro";
            this.lblTratativaErro.Size = new System.Drawing.Size(0, 18);
            this.lblTratativaErro.TabIndex = 18;
            // 
            // lblCriarErro
            // 
            this.lblCriarErro.AutoSize = true;
            this.lblCriarErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarErro.Location = new System.Drawing.Point(371, 344);
            this.lblCriarErro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCriarErro.Name = "lblCriarErro";
            this.lblCriarErro.Size = new System.Drawing.Size(0, 17);
            this.lblCriarErro.TabIndex = 19;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(957, 405);
            this.Controls.Add(this.lblCriarErro);
            this.Controls.Add(this.lblTratativaErro);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lstListaJogadores);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenhaJogador);
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
            this.Name = "Lobby";
            this.Text = "Lobby Can\'t Stop";
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
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ListBox lstListaJogadores;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblTratativaErro;
        private System.Windows.Forms.Label lblCriarErro;
    }
}

