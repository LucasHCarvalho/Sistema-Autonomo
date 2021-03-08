
namespace Cant_stop
{
    partial class Tabuleiro
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
            this.txtJogadores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtJogadores
            // 
            this.txtJogadores.Location = new System.Drawing.Point(173, 74);
            this.txtJogadores.Multiline = true;
            this.txtJogadores.Name = "txtJogadores";
            this.txtJogadores.Size = new System.Drawing.Size(181, 213);
            this.txtJogadores.TabIndex = 0;
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 399);
            this.Controls.Add(this.txtJogadores);
            this.Name = "Tabuleiro";
            this.Text = "Tabuleiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJogadores;
    }
}