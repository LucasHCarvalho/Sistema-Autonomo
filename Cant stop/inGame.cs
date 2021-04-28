using CantStopServer;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Cant_stop
{
    public partial class inGame : Form
    {
        public string dadosGlobal;
        public static int dado1, dado2, dado3, dado4;
        public string cor;
        public static int optMovimento;
        public int Alpinista1 = 0;
        public int Alpinista2 = 0;
        public int Alpinista3 = 0;
        public static bool NossaVez = false;

        public inGame()
        {
            InitializeComponent();
            historicopartida();
            verificadordeTabuleiro();
            verificarvez();
            //numOP();
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

        /*public void numOP()
        {
            if (Alpinista3 == 0 || Alpinista2 == 0)
            {
                btnD1d4.Visible = false;
                btnD1d3.Visible = false;
                btnd2d4.Visible = false;
                btnD1d2.Visible = false;
                btnd3d4.Visible = false;
                btnd2d3.Visible = false;
            }else {
                if (somaDados(dado1, dado2) == || somaDados(dado1, dado2) == || somaDados(dado1, dado2) == ||
                    somaDados(dado1, dado2) == || somaDados(dado1, dado2) == || somaDados(dado1, dado2) ||== )
                {

                }
            }

        }*/

        public void rolardados()
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

            }

            for (int i = 1; i <= 6; i++)
            {
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
            btnD1d2d3d4.Text = (dado1 + dado2).ToString() + " e " + (dado3 + dado4).ToString();
            btnD1d3d2d4.Text = (dado1 + dado3).ToString() + " e " + (dado2 + dado4).ToString();
            btnD1d4d2d3.Text = (dado1 + dado4).ToString() + " e " + (dado3 + dado2).ToString();

            btnD1d2.Text = (dado1 + dado2).ToString();
            btnD1d3.Text = (dado1 + dado3).ToString();
            btnD1d4.Text = (dado1 + dado4).ToString();

            btnd2d3.Text = (dado3 + dado4).ToString();
            btnd2d4.Text = (dado2 + dado4).ToString();
            btnd3d4.Text = (dado3 + dado2).ToString();
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

            }

            for (int i = 1; i <= 6; i++)
            {
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
            btnD1d2d3d4.Text = (dado1 + dado2).ToString() + " e " + (dado3 + dado4).ToString();
            btnD1d3d2d4.Text = (dado1 + dado3).ToString() + " e " + (dado2 + dado4).ToString();
            btnD1d4d2d3.Text = (dado1 + dado4).ToString() + " e " + (dado3 + dado2).ToString();

            btnD1d2.Text = (dado1 + dado2).ToString();
            btnD1d3.Text = (dado1 + dado3).ToString();
            btnD1d4.Text = (dado1 + dado4).ToString();

            btnd2d3.Text = (dado3 + dado4).ToString();
            btnd2d4.Text = (dado2 + dado4).ToString();
            btnd3d4.Text = (dado3 + dado2).ToString();
        }

        public bool jogoCompleto()
        {
           string retorno = Jogo.ListarPartidas("E");
            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');
            for (int i = 0; i < linha.Length- 1; i++)
            {
                string[] partidaide = linha[i].Split(',');
                if(Convert.ToInt32(partidaide[0]) == Lobby.IdPartida)
                {
                    Console.WriteLine("Jogo COmpleto!");
                    return true;
                }
            }
            Console.WriteLine("Jogo Incompleto");
            return false;
        }
        private void verificarvez()
        {
            string verificaVez = Jogo.VerificarVez(Lobby.IdPartida);
            string lista = verificaVez.ToString();
            string[] itens = lista.Split(',');
            if (int.Parse(itens[1]) == int.Parse(Lobby.jogadorVermelho))
            {
                lblCor.ForeColor = System.Drawing.Color.Red;
                btnRolarDados.ForeColor = System.Drawing.Color.Red;
                btnStop.ForeColor = System.Drawing.Color.Red;
                if(Lobby.nossoJogador == Lobby.nomeJVermelho)
                {
                    lblCor.Text = "É a sua vez!";
                    NossaVez = true;
                } else {
                lblCor.Text = "É a vez do " + Lobby.nomeJVermelho + " de cor vermelha";
                    NossaVez = false;
                }
            }
            else if (int.Parse(itens[1]) == int.Parse(Lobby.jogadorAzul))
            {
                lblCor.ForeColor = System.Drawing.Color.Blue;
                btnRolarDados.ForeColor = System.Drawing.Color.Blue;
                btnStop.ForeColor = System.Drawing.Color.Blue;
                if (Lobby.nossoJogador == Lobby.nomeJAzul)
                {
                    lblCor.Text = "É a sua vez!";
                    NossaVez = true;
                }
                else { 
                lblCor.Text = "É a vez do " + Lobby.nomeJAzul + " de cor azul";
                    NossaVez = false;
                }
            }
            else if (int.Parse(itens[1]) == int.Parse(Lobby.jogadorVerde))
            {
                lblCor.ForeColor = System.Drawing.Color.YellowGreen;
                btnRolarDados.ForeColor = System.Drawing.Color.YellowGreen;
                btnStop.ForeColor = System.Drawing.Color.YellowGreen;
                if (Lobby.nossoJogador == Lobby.nomeJVerde)
                {
                    lblCor.Text = "É a sua vez!";
                    NossaVez = true;
                }
                else { 
                lblCor.Text = "É a vez do " + Lobby.nomeJVerde + " de cor verde";
                    NossaVez = false;
                }
            }
            else
            {
                lblCor.ForeColor = System.Drawing.Color.Yellow;
                btnRolarDados.ForeColor = System.Drawing.Color.Yellow;
                btnStop.ForeColor = System.Drawing.Color.Yellow;
                if (Lobby.nossoJogador == Lobby.nomeJAmarelo)
                {
                    lblCor.Text = "É a sua vez!";
                    NossaVez = true;
                }
                lblCor.Text = "É a vez do " + Lobby.nomeJAmarelo + " de cor amarela";
                    NossaVez = false;
            }

        }

        public void acabaVez()
        {
            string paraTabuleiro = Jogo.Parar(Lobby.IdJogador, Lobby.senhaJogador);
            if (paraTabuleiro != "")
                MessageBox.Show(paraTabuleiro, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            string paraTabuleiro = Jogo.Parar(Lobby.IdJogador, Lobby.senhaJogador);
            if (paraTabuleiro != "")
                MessageBox.Show(paraTabuleiro, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void verificadordeTabuleiro()
        {
            limpaTela();
                string verificaTabuleiro = Jogo.ExibirTabuleiro(Lobby.IdPartida);
                verificaTabuleiro = verificaTabuleiro.Replace("\r", "");
                string[] linhas = verificaTabuleiro.Split('\n');

                for (int i = 0; i < linhas.Length; i++)
                {
                    if (linhas[i] != "")
                    {
                        
                        string[] posicoes = linhas[i].Split(',');
                        string coluna = posicoes[0];
                        string linha = posicoes[1];
                        string player = posicoes[2];
                        string cor = validaAlpinista(player, posicoes);
                        int column = Convert.ToInt32(coluna) - 2;
                        int row = 13 - Convert.ToInt32(linha);
                    if (Alpinista3 == 0) {
                        Alpinista3 = Convert.ToInt32(posicoes[0]);
                    }else if(Alpinista2 == 0) 
                    {
                        Alpinista2 = Convert.ToInt32(posicoes[0]);
                    }
                    else if(Alpinista1 == 0)
                    {
                        Alpinista1 = Convert.ToInt32(posicoes[0]);
                    }
                    Console.WriteLine("{0}", linhas[i]);

                        /*pega o controle que esta na posicção da peça;
                        Control posicao = tableLayoutPanel1.GetControlFromPosition(column, row);
                        Image myimage = new Bitmap(@"..\..\Imagens\jogador" + cor + ".png");
                        posicao.BackgroundImage = myimage;
                        posicao.BackgroundImageLayout = ImageLayout.Stretch;*/
                        printaImagem(column, row, cor);
                    }
                }         
        }
        private void btnTabuleiro_Click(object sender, EventArgs e)
        {
            
        }
        public void move2OP1()
        {
            //somad1d2 + d3d4
            string soma1 = somaDados(dado1, dado2);
            string soma2 = somaDados(dado3, dado4);
            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (soma1 + soma2));

            if (mover != "") {
                move2OP2();
            }
        }

        private void btnDado1_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado1, dado2);
            string soma2 = somaDados(dado3, dado4);
            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (soma1 + soma2));

            if (mover != "")
                MessageBox.Show(mover, "Movimento invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void move2OP2()
        {
            //soma d1d3 + d2d4
            string soma1 = somaDados(dado1, dado3);
            string soma2 = somaDados(dado2, dado4);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", (soma1 + soma2));

            if (mover != "") {
                move2OP3();
            }
        }
        private void btnD1d3_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado1, dado3);
            string soma2 = somaDados(dado2, dado4);
 
            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", (soma1 + soma2));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void move2OP3()
        {
            //soma d1d4 + d2d3
            string soma1 = somaDados(dado1, dado4);
            string soma2 = somaDados(dado2, dado3);
            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1423", (soma1 + soma2));

            if (mover != "")
            {
                move1OP1();
            }
            
        }
        private void btnD1d4_Click(object sender, EventArgs e)
        {

            string soma1 = somaDados(dado1, dado4);
            string soma2 = somaDados(dado2, dado3);
            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1423", (soma1 + soma2));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void move1OP4()
        {
            //soma d1 + d2
            string soma1 = somaDados(dado1, dado2);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (soma1 + "0"));

            if (mover != "")
            {
                move1OP5();
            }
        }
        private void btnD3d4_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado1, dado2);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (soma1 + "0"));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void move1OP2()
        {
            //soma d1 + d3
            string soma1 = somaDados(dado1, dado3);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", (soma1 + "0"));

            if (mover != "")
            {
                move1OP3();
            }
                
        }
        private void btnD2d4_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado1, dado3);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", (soma1 + "0"));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void move1OP1()
        {
            //soma d1 + d4
            string soma1 = somaDados(dado1, dado4);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1423", (soma1 + "0"));

            if (mover != "")
            {
                move1OP2();
            }
        }
        private void btnD2d3_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado1, dado4);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1423", (soma1 + "0"));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void move1OP5()
        {
            //soma d3 + d4
            string soma1 = somaDados(dado3, dado4);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "3412", (soma1 + "0"));

            if (mover != "")
            {
                move1OP6();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado3, dado4);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "3412", (soma1 + "0"));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void move1OP3()
        {
            //soma d2 + d4
            string soma1 = somaDados(dado2, dado4);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2413", (soma1 + "0"));

            if (mover != "")
            {
                move1OP4();
            }
                
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado2, dado4);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2413", (soma1 + "0"));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        public void move1OP6()
        {
            //soma d2 + d3

            string soma1 = somaDados(dado2, dado3);
            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2314", (soma1 + "0"));

            if (mover != "")
            {
                acabaVez();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string soma1 = somaDados(dado2, dado3);
            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2314", (soma1+"0"));

            if (mover != "")
                MessageBox.Show(mover, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lstHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void historicopartida()
        {
            string retorno = Jogo.ExibirHistorico(Lobby.IdPartida);
            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');
            lstHistorico.Items.Clear();
            for (int i = 0; i < linha.Length; i++)
            {
                lstHistorico.Items.Add(linha[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (jogoCompleto() == false) { 
                historicopartida();
            }
            else
            {
                timerHistorico.Enabled = false;
            }
        }

        private void timerTabuleiro_Tick(object sender, EventArgs e)
        {

            if(jogoCompleto() == true) {
                timerTabuleiro.Enabled = false;
            }
            if (timerTabuleiro.Enabled == true)
            {
                verificadordeTabuleiro();
            }
        }

        private void timerVerificaVez_Tick(object sender, EventArgs e)
        {
            if (jogoCompleto() == true)
            {
                timerVerificaVez.Enabled = false;
                verificadordeTabuleiro();
            }
                if (timerVerificaVez.Enabled == true) { 
                        verificarvez();
                for(int i = 0; i < 4; i++) {         
                    if (NossaVez == true)
                        {
                        rolardados();
                        move2OP1();
                        verificadordeTabuleiro();
                         }
                    }
                acabaVez();
            }
        }

        private void inGame_Load(object sender, EventArgs e)
        {

        }

        private void picDado2_Click(object sender, EventArgs e)
        {

        }

        private void picDado3_Click(object sender, EventArgs e)
        {

        }

        private void lblNoPlay_Click(object sender, EventArgs e)
        {

        }

        public void limpaTela()
        {
            for (int i = 0; i <= 12; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Control posicao = tableLayoutPanel1.GetControlFromPosition(j, i);
                    if (posicao != null)
                    {
                        posicao.Controls.Clear();
                    }
                }
            }
        }

        public void printaImagem(int coluna, int linha, string cor)
        {
            
            Control posicao = tableLayoutPanel1.GetControlFromPosition(coluna, linha);
            if (cor.Contains("vermelho"))
            {
                PictureBox pictureBox = new PictureBox();
                posicao.Controls.Add(pictureBox);
                pictureBox.Location = new Point(0, 0);
                pictureBox.Width = 29;
                pictureBox.Height = 23;
                pictureBox.BackgroundImage = new Bitmap(@"..\..\Imagens\jogador" + cor + ".png");
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            } else if (cor.Contains("azul"))
            {
                PictureBox pictureBox = new PictureBox();
                posicao.Controls.Add(pictureBox);
                pictureBox.Location = new Point(28, 0);
                pictureBox.Width = 29;
                pictureBox.Height = 23;
                pictureBox.BackgroundImage = new Bitmap(@"..\..\Imagens\jogador" + cor + ".png");
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            } else if (cor.Contains("verde"))
            {
                PictureBox pictureBox = new PictureBox();
                posicao.Controls.Add(pictureBox);
                pictureBox.Location = new Point(0, 24);
                pictureBox.Width = 29;
                pictureBox.Height = 23;
                pictureBox.BackgroundImage = new Bitmap(@"..\..\Imagens\jogador" + cor + ".png");
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            } else if (cor.Contains("amarelo"))
            {
                PictureBox pictureBox = new PictureBox();
                posicao.Controls.Add(pictureBox);
                pictureBox.Location = new Point(28, 24);
                pictureBox.Width = 29;
                pictureBox.Height = 23;
                pictureBox.BackgroundImage = new Bitmap(@"..\..\Imagens\jogador" + cor + ".png");
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        public string validaAlpinista(string player, string[] posicoes)
        {

            string validaAlpinista = posicoes[3];

            if (player == Lobby.jogadorVermelho)
            {
                cor = "vermelho"+validaAlpinista;
            }
            else if (player == Lobby.jogadorAzul)
            {
                cor = "azul"+validaAlpinista; 
            }
            else if (player == Lobby.jogadorVerde)
            {
                cor = "verde"+validaAlpinista; 
            }
            else if (player == Lobby.jogadorAmarelo)
            {
                cor = "amarelo"+validaAlpinista;
            }

            return cor;
        }
    }
} 
