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
            lblCor.Text = "Sua cor é: " + Lobby.cor;
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
            btnD1d2.Text = (dado1 + dado2).ToString() + " " + (dado3 + dado4).ToString();
            btnD1d3.Text = (dado1 + dado3).ToString() + " " + (dado2 + dado4).ToString();
            btnD1d4.Text = (dado1 + dado4).ToString() + " " + (dado3 + dado2).ToString();

            btnD3d4.Text = (dado1 + dado2).ToString();
            btnD2d4.Text = (dado1 + dado3).ToString();
            btnD2d3.Text = (dado1 + dado4).ToString();

            button1.Text = (dado3 + dado4).ToString();
            button2.Text = (dado2 + dado4).ToString();
            button3.Text = (dado3 + dado2).ToString();

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string verificaVez = Jogo.VerificarVez(Lobby.IdPartida);
            MessageBox.Show(verificaVez);
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

        private void btnStop_Click(object sender, EventArgs e)
        {
            string paraTabuleiro = Jogo.Parar(Lobby.IdJogador, Lobby.senhaJogador);
        }

        private void btnTabuleiro_Click(object sender, EventArgs e)
        {
            string verificaTabuleiro = Jogo.ExibirTabuleiro(Lobby.IdPartida);
            if(verificaTabuleiro == "") {
                MessageBox.Show("Nenhuma jogada foi executada");
            } else { 
                verificaTabuleiro = verificaTabuleiro.Replace("\r", "");
                string[] linha = verificaTabuleiro.Split('\n');
                MessageBox.Show(verificaTabuleiro);
                ////int i = 72;
                /*for(int i = 0; i <= linha.Length; i++)
                {
                    string[] vetor = linha[i].Split(',');
                    int coluna = Convert.ToInt32(vetor[0]);
                    int linhas = Convert.ToInt32(vetor[1]);

                    tableLayoutPanel1.Controls.Add(picPecaVermelha, coluna, linhas);
                }*/
            }
        }

        private void btnDado1_Click(object sender, EventArgs e)
        {
            string somad1d2 = (dado1 + dado2).ToString();
            string somad3d4 = (dado3 + dado4).ToString();
            if (somad1d2 == "10") {
                somad1d2 = "A";
            }
            else if (somad1d2 == "11") { 
                somad1d2 = "B";
            }
            else if (somad1d2 == "12"){
                somad1d2 = "C";
            }
            if (somad3d4 == "10")
            {
                somad3d4 = "A";
            }
            else if (somad3d4 == "11")
            {
                somad3d4 = "B";
            }
            else if (somad3d4 == "12")
            {
                somad3d4 = "C";
            }

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (somad1d2+somad3d4));
            
            if (mover == "")
            {
                if (somad1d2 == "2" || somad3d4 == "2")
                {
                    if(pri && seg)
                    {
                        tableLayoutPanel1.Controls.Add(picPecaVermelha2, 0, 7);
                        pictureBox17.Visible = false;
                    }
                    else if (pri)
                    {
                        tableLayoutPanel1.Controls.Add(picPecaVermelha1, 0, 7);
                        pictureBox17.Visible = false;
                    }
                    else if (seg)
                    {
                        tableLayoutPanel1.Controls.Add(picPecaVermelha3, 0, 7);
                        pictureBox17.Visible = false;
                    }
                }
                if (somad1d2 == "3" || somad3d4 == "3")
                {
                    if (pri && seg)
                    {
                        tableLayoutPanel1.Controls.Add(picPecaVermelha2, 1, 8);
                        pictureBox2.Visible = false;
                    }
                    else if (pri)
                    {
                        tableLayoutPanel1.Controls.Add(picPecaVermelha2, 1, 8);
                        pictureBox2.Visible = false;
                    }
                    else if (seg)
                    {
                        tableLayoutPanel1.Controls.Add(picPecaVermelha2, 1, 8);
                        pictureBox2.Visible = false;
                    }
                }
                if (somad1d2 == "4" || somad3d4 == "4")
                {
                    if (pri && seg)
                    {
                        tableLayoutPanel1.Controls.Add(picPecaVermelha2, 2, 9);
                        pictureBox3.Visible = false;
                    }
                    else if (pri)
                    {
                        tableLayoutPanel1.Controls.Add(picPecaVermelha2, 2, 9);
                        pictureBox3.Visible = false;
                    }
                    else if (seg)
                    {
                        tableLayoutPanel1.Controls.Add(picPecaVermelha2, 2, 9);
                        pictureBox3.Visible = false;
                    }
                }
                if (somad1d2 == "5" || somad3d4 == "5")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 3, 10);
                    pictureBox1.Visible = false;
                }
                if (somad1d2 == "6" || somad3d4 == "6")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 4, 11);
                    pictureBox6.Visible = false;
                }
                if (somad1d2 == "7" || somad3d4 == "7")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 5, 12);
                    pictureBox10.Visible = false;
                }
                if (somad1d2 == "8" || somad3d4 == "8")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 6, 11);
                    pictureBox18.Visible = false;
                }
                if (somad1d2 == "9" || somad3d4 == "9")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 7, 10);
                    pictureBox5.Visible = false;
                }
                if (somad1d2 == "10" || somad3d4 == "10")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 8, 9);
                    pictureBox7.Visible = false;
                }
                if (somad1d2 == "11" || somad3d4 == "11")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 9, 8);
                    pictureBox4.Visible = false;
                }
                if (somad1d2 == "12" || somad3d4 == "12")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 10, 7);
                    pictureBox8.Visible = false;
                }
            }
            else {  
            MessageBox.Show(mover,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pnlCor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void lblCor_Click(object sender, EventArgs e)
        {

        }

        private void picDado1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {

        }

        private void btnD1d3_Click(object sender, EventArgs e)
        {
            string somad1d2 = (dado1 + dado3).ToString();
            string somad3d4 = (dado2 + dado4).ToString();
            if (somad1d2 == "10")
            {
                somad1d2 = "A";
            }
            else if (somad1d2 == "11")
            {
                somad1d2 = "B";
            }
            else if (somad1d2 == "12")
            {
                somad1d2 = "C";
            }
            if (somad3d4 == "10")
            {
                somad3d4 = "A";
            }
            else if (somad3d4 == "11")
            {
                somad3d4 = "B";
            }
            else if (somad3d4 == "12")
            {
                somad3d4 = "C";
            }

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", (somad1d2 + somad3d4));

            if (mover == "")
            {
                if (somad1d2 == "2" || somad3d4 == "2")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 0, 7);
                    pictureBox17.Visible = false;
                }
                if (somad1d2 == "3" || somad3d4 == "3")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 1, 8);
                    pictureBox2.Visible = false;
                }
                if (somad1d2 == "4" || somad3d4 == "4")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 2, 9);
                    pictureBox3.Visible = false;
                }
                if (somad1d2 == "5" || somad3d4 == "5")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 3, 10);
                    pictureBox1.Visible = false;
                }
                if (somad1d2 == "6" || somad3d4 == "6")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 4, 11);
                    pictureBox6.Visible = false;
                }
                if (somad1d2 == "7" || somad3d4 == "7")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 5, 12);
                    pictureBox10.Visible = false;
                }
                if (somad1d2 == "8" || somad3d4 == "8")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 6, 11);
                    pictureBox18.Visible = false;
                }
                if (somad1d2 == "9" || somad3d4 == "9")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 7, 10);
                    pictureBox5.Visible = false;
                }
                if (somad1d2 == "10" || somad3d4 == "10")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 8, 9);
                    pictureBox7.Visible = false;
                }
                if (somad1d2 == "11" || somad3d4 == "11")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 9, 8);
                    pictureBox4.Visible = false;
                }
                if (somad1d2 == "12" || somad3d4 == "12")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 10, 7);
                    pictureBox8.Visible = false;
                }
            }
            else
            {
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnD1d4_Click(object sender, EventArgs e)
        {
            string somad1d2 = (dado1 + dado4).ToString();
            string somad3d4 = (dado2 + dado3).ToString();
            if (somad1d2 == "10")
            {
                somad1d2 = "A";
            }
            else if (somad1d2 == "11")
            {
                somad1d2 = "B";
            }
            else if (somad1d2 == "12")
            {
                somad1d2 = "C";
            }
            if (somad3d4 == "10")
            {
                somad3d4 = "A";
            }
            else if (somad3d4 == "11")
            {
                somad3d4 = "B";
            }
            else if (somad3d4 == "12")
            {
                somad3d4 = "C";
            }

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1423", (somad1d2 + somad3d4));

            if (mover == "")
            {
                if (somad1d2 == "2" || somad3d4 == "2")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 0, 7);
                    pictureBox17.Visible = false;
                }
                if (somad1d2 == "3" || somad3d4 == "3")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 1, 8);
                    pictureBox2.Visible = false;
                }
                if (somad1d2 == "4" || somad3d4 == "4")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 2, 9);
                    pictureBox3.Visible = false;
                }
                if (somad1d2 == "5" || somad3d4 == "5")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 3, 10);
                    pictureBox1.Visible = false;
                }
                if (somad1d2 == "6" || somad3d4 == "6")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 4, 11);
                    pictureBox6.Visible = false;
                }
                if (somad1d2 == "7" || somad3d4 == "7")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 5, 12);
                    pictureBox10.Visible = false;
                }
                if (somad1d2 == "8" || somad3d4 == "8")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 6, 11);
                    pictureBox18.Visible = false;
                }
                if (somad1d2 == "9" || somad3d4 == "9")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 7, 10);
                    pictureBox5.Visible = false;
                }
                if (somad1d2 == "10" || somad3d4 == "10")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 8, 9);
                    pictureBox7.Visible = false;
                }
                if (somad1d2 == "11" || somad3d4 == "11")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 9, 8);
                    pictureBox4.Visible = false;
                }
                if (somad1d2 == "12" || somad3d4 == "12")
                {
                    tableLayoutPanel1.Controls.Add(picPecaVermelha2, 10, 7);
                    pictureBox8.Visible = false;
                }
            }
            else
            {
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnD3d4_Click(object sender, EventArgs e)
        {
            string somad1d2 = (dado1 + dado2).ToString();
            
            if (somad1d2 == "10")
            {
                somad1d2 = "A";
            }
            else if (somad1d2 == "11")
            {
                somad1d2 = "B";
            }
            else if (somad1d2 == "12")
            {
                somad1d2 = "C";
            }
            

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (somad1d2+"0"));

            if (mover == "")
            {
                
            }
            else
            {
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnD2d4_Click(object sender, EventArgs e)
        {
            string somad1d2 = (dado1 + dado3).ToString();

            if (somad1d2 == "10")
            {
                somad1d2 = "A";
            }
            else if (somad1d2 == "11")
            {
                somad1d2 = "B";
            }
            else if (somad1d2 == "12")
            {
                somad1d2 = "C";
            }


            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "130", somad1d2);

            if (mover == "")
            {
            }
            else
            {
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnD2d3_Click(object sender, EventArgs e)
        {
            string somad1d2 = (dado1 + dado4).ToString();

            if (somad1d2 == "10")
            {
                somad1d2 = "A";
            }
            else if (somad1d2 == "11")
            {
                somad1d2 = "B";
            }
            else if (somad1d2 == "12")
            {
                somad1d2 = "C";
            }


            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1400", somad1d2);

            if (mover == "")
            {

            }
            else
            {
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string somad1d2 = (dado3 + dado4).ToString();

            if (somad1d2 == "10")
            {
                somad1d2 = "A";
            }
            else if (somad1d2 == "11")
            {
                somad1d2 = "B";
            }
            else if (somad1d2 == "12")
            {
                somad1d2 = "C";
            }


            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "3400", somad1d2);

            if (mover == "")
            {

            }
            else
            {
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string somad1d2 = (dado2 + dado4).ToString();

            if (somad1d2 == "10")
            {
                somad1d2 = "A";
            }
            else if (somad1d2 == "11")
            {
                somad1d2 = "B";
            }
            else if (somad1d2 == "12")
            {
                somad1d2 = "C";
            }


            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2400", somad1d2);

            if (mover == "")
            {

            }
            else
            {
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string somad1d2 = (dado2 + dado3).ToString();

            if (somad1d2 == "10")
            {
                somad1d2 = "A";
            }
            else if (somad1d2 == "11")
            {
                somad1d2 = "B";
            }
            else if (somad1d2 == "12")
            {
                somad1d2 = "C";
            }


            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2300    ", somad1d2);

            if (mover == "")
            {

            }
            else
            {
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
