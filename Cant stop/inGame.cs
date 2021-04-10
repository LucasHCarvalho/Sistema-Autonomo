using CantStopServer;
using System;
using System.Windows.Forms;

namespace Cant_stop
{
    public partial class inGame : Form
    {
        public string dadosGlobal;
        public static int dado1, dado2, dado3, dado4;

        public inGame()
        {
            InitializeComponent();
            lblCor.Text = "Sua cor é: " + Lobby.cor;
        }

        public string somaDados(int dado1, int dado2)
        {
            string soma = (dado1 + dado2).ToString();
            if (soma == "10")
                soma = "A";
            else if (soma == "11")
                soma = "B";
            else if (soma == "12")
                soma = "C";

            return soma;
        }

        public void btnRolarDados_Click(object sender, EventArgs e)
        {
            dadosGlobal = Jogo.RolarDados(Lobby.IdJogador, Lobby.senhaJogador);
            dadosGlobal = dadosGlobal.Replace("\r", "");
            dadosGlobal = dadosGlobal.Replace("\n", "");
            Console.WriteLine(dadosGlobal);
            string verificaDado = dadosGlobal.Substring(0, 1);
            if (verificaDado == "E")
                MessageBox.Show(dadosGlobal, "Ação Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dado1 = Convert.ToInt32(dadosGlobal.Substring(1, 1));
                dado2 = Convert.ToInt32(dadosGlobal.Substring(3, 1));
                dado3 = Convert.ToInt32(dadosGlobal.Substring(5, 1));
                dado4 = Convert.ToInt32(dadosGlobal.Substring(7, 1));
                Console.WriteLine("{0}-{1}-{2}-{3}", dado1, dado2, dado3, dado4);
            }

            for (int i = 1; i <= 6; i++)
            {
                if (dado1 == i)
                {
                    picDado1.ImageLocation = @"..\..\Imagens\dado1.png";
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

        private void btnStop_Click(object sender, EventArgs e)
        {
            string paraTabuleiro = Jogo.Parar(Lobby.IdJogador, Lobby.senhaJogador);
            if (paraTabuleiro != "")
                MessageBox.Show(paraTabuleiro, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTabuleiro_Click(object sender, EventArgs e)
        {
            string verificaTabuleiro = Jogo.ExibirTabuleiro(Lobby.IdPartida);
            if (verificaTabuleiro == "")
                MessageBox.Show("Nenhuma jogada foi executada");
            else
            {
                verificaTabuleiro = verificaTabuleiro.Replace("\r", "");
                string[] linhas = verificaTabuleiro.Split('\n');
                MessageBox.Show(verificaTabuleiro);
                
                for (int i = 0; i < linhas.Length; i++)
                {
                    string[] posicoes = linhas[i].Split(',');
                    if(linhas[i] != "")
                    {
                        string coluna = posicoes[0];
                        MessageBox.Show(coluna);

                        string linha = posicoes[1];
                        MessageBox.Show(linha);

                        int column = Convert.ToInt32(coluna) - 2;
                        int row = 13 - Convert.ToInt32(coluna);

                        //pega o controle que esta na posicção da peça;
                        Control posicao = tableLayoutPanel1.GetControlFromPosition(column, row);
                    }                                      
                }
            }
        }

        private void btnDado1_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado1, dado2);
            string soma2 = somaDados(dado3, dado4);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (soma1 + soma2));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnD1d3_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado1, dado3);
            string soma2 = somaDados(dado2, dado4);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (soma1 + soma2));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnD1d4_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado1, dado4);
            string soma2 = somaDados(dado2, dado3);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (soma1 + soma2));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnD3d4_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado1, dado2);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (soma1 + "0"));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnD2d4_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado1, dado3);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", (soma1 + "0"));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnD2d3_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado1, dado4);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1423", (soma1 + "0"));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado3, dado4);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "3412", (soma1 + "0"));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado2, dado4);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2413", (soma1 + "0"));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado2, dado3);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2314", (soma1+"0"));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
