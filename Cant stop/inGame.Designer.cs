
namespace Cant_stop
{
    partial class inGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inGame));
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.btnPartidasJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstJogadores
            // 
            this.lstJogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 22;
            this.lstJogadores.Location = new System.Drawing.Point(167, 12);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(186, 176);
            this.lstJogadores.TabIndex = 0;
            this.lstJogadores.SelectedIndexChanged += new System.EventHandler(this.lstJogadores_SelectedIndexChanged);
            // 
            // btnPartidasJ
            // 
            this.btnPartidasJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidasJ.Location = new System.Drawing.Point(12, 12);
            this.btnPartidasJ.Name = "btnPartidasJ";
            this.btnPartidasJ.Size = new System.Drawing.Size(128, 96);
            this.btnPartidasJ.TabIndex = 1;
            this.btnPartidasJ.Text = "Mostrar Lista de Partidas";
            this.btnPartidasJ.UseVisualStyleBackColor = true;
            this.btnPartidasJ.Click += new System.EventHandler(this.btnPartidasJ_Click);
            // 
            // inGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPartidasJ);
            this.Controls.Add(this.lstJogadores);
            this.DoubleBuffered = true;
            this.Name = "inGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Button btnPartidasJ;
    }
}