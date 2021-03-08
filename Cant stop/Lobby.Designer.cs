
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostraLista
            // 
            this.btnMostraLista.Location = new System.Drawing.Point(12, 12);
            this.btnMostraLista.Name = "btnMostraLista";
            this.btnMostraLista.Size = new System.Drawing.Size(128, 51);
            this.btnMostraLista.TabIndex = 0;
            this.btnMostraLista.Text = "Mostra Lista";
            this.btnMostraLista.UseVisualStyleBackColor = true;
            this.btnMostraLista.Click += new System.EventHandler(this.btnMostraLista_Click);
            // 
            // lstListarPartidas
            // 
            this.lstListarPartidas.BackColor = System.Drawing.SystemColors.Window;
            this.lstListarPartidas.Location = new System.Drawing.Point(240, 12);
            this.lstListarPartidas.Name = "lstListarPartidas";
            this.lstListarPartidas.Size = new System.Drawing.Size(177, 199);
            this.lstListarPartidas.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFechar.Location = new System.Drawing.Point(12, 160);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(128, 51);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 348);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lstListarPartidas);
            this.Controls.Add(this.btnMostraLista);
            this.Name = "Lobby";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostraLista;
        private System.Windows.Forms.ListBox lstListarPartidas;
        private System.Windows.Forms.Button btnFechar;
    }
}

