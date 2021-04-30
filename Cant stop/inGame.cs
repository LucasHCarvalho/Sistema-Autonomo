using CantStopServer;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Cant_stop
{
    public partial class inGame : Form
    {
        /*
            Variaveis
        */
        public string dadosGlobal;
        public static int dado1, dado2, dado3, dado4;
        public string cor;
        public static int optMovimento;
        public int Alpinista1 = 0;
        public int Alpinista2 = 0;
        public int Alpinista3 = 0;
        public static bool NossaVez = false;
        public string validaBouA;

        /*
            Funções
        */
        public inGame()
        {
            InitializeComponent();
            historicopartida();
            verificadordeTabuleiro();
            verificarvez();
        }
       
            /*
                Verifica se ganhou
            */
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
                    Console.WriteLine("Jogo Completo!");
                    return true;
                }
            }
            Console.WriteLine("Jogo Incompleto");
            return false;
        }

            /*
                Atualizações de Tela
            */
        private void verificarvez()
        {
            string verificaVez = Jogo.VerificarVez(Lobby.IdPartida);
            string lista = verificaVez.ToString();
            string[] itens = lista.Split(',');

            if (int.Parse(itens[1]) == int.Parse(Lobby.jogadorVermelho))
            {
                lblCor.ForeColor = System.Drawing.Color.Red;

                if(Lobby.nossoJogador == Lobby.nomeJVermelho)
                {
                    lblCor.Text = "É a sua vez!";
                    NossaVez = true;
                } 
                else 
                {
                    lblCor.Text = "É a vez do " + Lobby.nomeJVermelho + " de cor vermelha";
                    NossaVez = false;
                }
            }
            if (Lobby.jogadorAzul != null)
            {
                if (int.Parse(itens[1]) == int.Parse(Lobby.jogadorAzul))
                {
                    lblCor.ForeColor = System.Drawing.Color.Blue;
                    if (Lobby.nossoJogador == Lobby.nomeJAzul)
                    {
                        lblCor.Text = "É a sua vez!";
                        NossaVez = true;
                    }
                    else
                    {
                        lblCor.Text = "É a vez do " + Lobby.nomeJAzul + " de cor azul";
                        NossaVez = false;
                    }
                }
            }
            if (Lobby.jogadorVerde != null)
            {
                if (int.Parse(itens[1]) == int.Parse(Lobby.jogadorVerde))
                {
                    lblCor.ForeColor = System.Drawing.Color.YellowGreen;
                    if (Lobby.nossoJogador == Lobby.nomeJVerde)
                    {
                        lblCor.Text = "É a sua vez!";
                        NossaVez = true;
                    }
                    else
                    {
                        lblCor.Text = "É a vez do " + Lobby.nomeJVerde + " de cor verde";
                        NossaVez = false;
                    }
                }
            }
            if (Lobby.jogadorAmarelo != null)
            {
                if (int.Parse(itens[1]) == int.Parse(Lobby.jogadorAmarelo))
                {
                    lblCor.ForeColor = System.Drawing.Color.Yellow;
                    if (Lobby.nossoJogador == Lobby.nomeJAmarelo)
                    {
                        lblCor.Text = "É a sua vez!";
                        NossaVez = true;
                    }
                    else
                    {
                        lblCor.Text = "É a vez do " + Lobby.nomeJAmarelo + " de cor amarela";
                        NossaVez = false;
                    }
                    
                }
            }
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

                    int coluna = Convert.ToInt32(posicoes[0]) - 2;
                    int linha = 13 - Convert.ToInt32(posicoes[1]);
                    string player = posicoes[2];
                    validaBouA = posicoes[3];
                    validaAlpinista(player);

                    if (Alpinista3 == 0)
                    {
                        Alpinista3 = Convert.ToInt32(posicoes[0]);
                    }
                    else if (Alpinista2 == 0)
                    {
                        Alpinista2 = Convert.ToInt32(posicoes[0]);
                    }
                    else if (Alpinista1 == 0)
                    {
                        Alpinista1 = Convert.ToInt32(posicoes[0]);
                    }

                    Console.WriteLine("{0}", linhas[i]);
                    printaImagem(coluna, linha);
                }
            }
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
        public void acabaVez()
        {
            NossaVez = false;
            string paraTabuleiro = Jogo.Parar(Lobby.IdJogador, Lobby.senhaJogador);
            Console.WriteLine(paraTabuleiro);
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

            /*
                Movimentos
            */
        public void move2OP1()
        {
            //somad1d2 + d3d4
            string soma1 = somaDados(dado1, dado2);
            string soma2 = somaDados(dado3, dado4);
            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (soma1 + soma2));

            if (mover != "") 
            {
                move2OP2();
            }
        }
        public void move2OP2()
        {
            //soma d1d3 + d2d4
            string soma1 = somaDados(dado1, dado3);
            string soma2 = somaDados(dado2, dado4);

            string mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", (soma1 + soma2));

            if (mover != "") 
            {
                move2OP3();
            }
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

            /*
                Timer
            */
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
            if(jogoCompleto()) 
            {
                timerTabuleiro.Enabled = false;
            }
            if (timerTabuleiro.Enabled)
            {
                verificadordeTabuleiro();
            }
        }
        private void timerVerificaVez_Tick(object sender, EventArgs e)
        {
            if (jogoCompleto())
            {
                timerVerificaVez.Enabled = false;
            }

            if (timerVerificaVez.Enabled) 
            { 
                verificarvez();  
                
                if (NossaVez)
                {
                    rolardados();
                    move2OP1();
                    rolardados();
                    move2OP1();
                    acabaVez();
                }   
            }
        }

            /*
                Logicas
            */
        public void printaImagem(int coluna, int linha)
        {
            Control posicao = tableLayoutPanel1.GetControlFromPosition(coluna, linha);
            PictureBox pictureBox = new PictureBox();
            posicao.Controls.Add(pictureBox);

            if (cor.Contains("vermelho"))
            {
                pictureBox.Location = new Point(0, 0);
            }
            if (cor.Contains("azul"))
            {
                pictureBox.Location = new Point(28, 0);
            } 
            if (cor.Contains("verde"))
            {
                pictureBox.Location = new Point(0, 24);
            } 
            if (cor.Contains("amarelo"))
            {
                pictureBox.Location = new Point(28, 24);
            }

            pictureBox.Width = 29;
            pictureBox.Height = 23;
            pictureBox.BackgroundImage = new Bitmap(@"..\..\Imagens\jogador" + cor + ".png");
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void validaAlpinista(string player)
        {
            if (int.Parse(player) == int.Parse(Lobby.jogadorVermelho))
            {
                cor = "vermelho"+validaBouA;
            }
            else if (int.Parse(player) == int.Parse(Lobby.jogadorAzul))
            {
                cor = "azul"+validaBouA; 
            }
            else if (int.Parse(player) == int.Parse(Lobby.jogadorVerde))
            {
                cor = "verde"+validaBouA; 
            }
            else if (int.Parse(player) == int.Parse(Lobby.jogadorAmarelo))
            {
                cor = "amarelo"+validaBouA;
            }
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
        public void rolardados()
        {
            dadosGlobal = Jogo.RolarDados(Lobby.IdJogador, Lobby.senhaJogador);

            dadosGlobal = dadosGlobal.Replace("\r", "");
            dadosGlobal = dadosGlobal.Replace("\n", "");

            Console.WriteLine(dadosGlobal);

            if (dadosGlobal.Substring(0, 1) != "E")
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
        }

    }
} 
