using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;

namespace Cant_stop
{
    public partial class inGame : Form
    {
        public string dadosGlobal;
        public static int dado1;
        public static int dado2;
        public static int dado3;
        public static int dado4;

        public inGame()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void btnRolarDados_Click(object sender, EventArgs e)
        {
            dadosGlobal = Jogo.RolarDados(Lobby.IdJogador, Lobby.senhaJogador);
            dadosGlobal = dadosGlobal.Replace("\r", "");
            dadosGlobal = dadosGlobal.Replace("\n", "");
            Console.WriteLine(dadosGlobal);
            string verificaDado = dadosGlobal.Substring(0, 1);
            if (verificaDado == "E")
            {
                MessageBox.Show(dadosGlobal, "Ação Incompleta",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dado1 = Convert.ToInt32(dadosGlobal.Substring(1, 1));
                dado2 = Convert.ToInt32(dadosGlobal.Substring(3, 1));
                dado3 = Convert.ToInt32(dadosGlobal.Substring(5, 1));
                dado4 = Convert.ToInt32(dadosGlobal.Substring(7, 1));
                Console.WriteLine("{0}-{1}-{2}-{3}", dado1, dado2, dado3, dado4);
            }

            for (int i = 1; i <= 6; i++) {
                if (dado1 == i)
                {
                    picDado1.ImageLocation = @"..\..\Imagens\dado" + i + ".jpg"; 
                    picDado1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                if (dado2 == i)
                {
                    picDado2.ImageLocation = @"..\..\Imagens\dado" + i + ".jpg";
                    picDado2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                if (dado3 == i)
                {
                    picDado3.ImageLocation = @"..\..\Imagens\dado" + i + ".jpg";
                    picDado3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                if (dado4 == i)
                {
                    picDado4.ImageLocation = @"..\..\Imagens\dado" + i + ".jpg";
                    picDado4.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string verificaVez = Jogo.VerificarVez(Lobby.IdPartida);
            MessageBox.Show(verificaVez);
            Console.WriteLine(verificaVez);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
