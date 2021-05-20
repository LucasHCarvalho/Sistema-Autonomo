using CantStopServer;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

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
        public int pontos = 0;
        public int alpinista = 3;
        
        List<Trilhas> trilhas = new List<Trilhas>();
        /*
            Funções
        */
        public inGame()
        {
            InitializeComponent();
            carregaTrilhas();
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
            for (int i = 0; i < linha.Length - 1; i++)
            {
                string[] partidaide = linha[i].Split(',');
                if (Convert.ToInt32(partidaide[0]) == Lobby.IdPartida)
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
                lstHistorico.ForeColor = Color.Red;
                if (Lobby.nossoJogador == Lobby.nomeJVermelho)
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
                    lstHistorico.ForeColor = Color.Blue;
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
                    lstHistorico.ForeColor = Color.YellowGreen;
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
                    lstHistorico.ForeColor = Color.Orange;
                    lblCor.ForeColor = System.Drawing.Color.Orange;
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
            pontos = 0;
            alpinista = 3;
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
                if (i <= 36)
                    lstHistorico.Items.Add(linha[i]);
            }
        }

        /*
            Movimentos
        */

        public string move2OP1()
        {
            //somad1d2 + d3d4
            string soma1 = somaDados(dado1, dado2);
            string soma2 = somaDados(dado3, dado4);
            string trilhas = (soma1 + soma2);

            return trilhas;
        }
        public string move2OP2()
        {
            //soma d1d3 + d2d4
            string soma1 = somaDados(dado1, dado3);
            string soma2 = somaDados(dado2, dado4);
            string trilhas = (soma1 + soma2);

            return trilhas;
        }
        public string move2OP3()
        {
            //soma d1d4 + d2d3
            string soma1 = somaDados(dado1, dado4);
            string soma2 = somaDados(dado2, dado3);
            string trilhas = (soma1 + soma2);

            return trilhas;
        }

        public string move1OP1()
        {
            //soma d1 + d4
            string soma1 = somaDados(dado1, dado4);

            return soma1;
        }
        public string move1OP2()
        {
            //soma d1 + d3
            string soma1 = somaDados(dado1, dado3);

            return soma1;
        }
        public string move1OP3()
        {
            //soma d2 + d4
            string soma1 = somaDados(dado2, dado4);

            return soma1;
        }
        public string move1OP4()
        {
            //soma d1 + d2
            string soma1 = somaDados(dado1, dado2);

            return soma1;
        }
        public string move1OP5()
        {
            //soma d3 + d4
            string soma1 = somaDados(dado3, dado4);

            return soma1;
        }
        public string move1OP6()
        {
            //soma d2 + d3
            string soma1 = somaDados(dado2, dado3);

            return soma1;
        }
        public void movimenta2()
        {
            string opcao1 = move2OP1();
            string opcao2 = move2OP2();
            string opcao3 = move2OP3();
            string mover;
            int pontos1 = 0, pontos2 = 0, pontos3 = 0;

            foreach (Trilhas trilha in trilhas)
            {
                if (trilha.Id == opcao1.Substring(0, 1))
                {
                    pontos1 += trilha.PontosSemAlpinista;
                }

                if (trilha.Id == opcao1.Substring(1, 1))
                {
                    pontos1 += trilha.PontosSemAlpinista;
                }

                if (trilha.Id == opcao2.Substring(0, 1))
                {
                    pontos2 += trilha.PontosSemAlpinista;
                }

                if (trilha.Id == opcao2.Substring(1, 1))
                {
                    pontos2 += trilha.PontosSemAlpinista;
                }

                if (trilha.Id == opcao3.Substring(0, 1))
                {
                    pontos3 += trilha.PontosSemAlpinista;
                }

                if (trilha.Id == opcao3.Substring(1, 1))
                {
                    pontos3 += trilha.PontosSemAlpinista;
                }

            }

            if (pontos1 >= pontos2 && pontos1 >= pontos3)
            {
                pontos += pontos1;
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", opcao1);

            }

            else if (pontos2 >= pontos1 && pontos2 >= pontos3)
            {
                pontos += pontos2;
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", opcao2);

            }

            else
            {
                pontos += pontos3;
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1423", opcao3);

            }

            if (mover != "")
            {

                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", opcao1);

                if (mover != "")
                {

                    mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", opcao2);

                    if (mover != "")
                    {
                        mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1423", opcao3);

                        if (mover != "")
                        {
                            movimenta1();
                        }
                        else
                        {
                            pontos += pontos3;


                        }

                    }
                    else
                    {
                        pontos += pontos2;

                    }
                }
                else
                {
                    pontos += pontos1;

                }
                Console.WriteLine(mover);
            }
        }

        public void movimenta1()
        {
            alpinista -= 1;
            string opcao1 = move1OP1();
            string opcao2 = move1OP2();
            string opcao3 = move1OP3();
            string opcao4 = move1OP4();
            string opcao5 = move1OP5();
            string opcao6 = move1OP6();
            string mover;
            int pontos1 = 0, pontos2 = 0, pontos3 = 0, pontos4 = 0, pontos5 = 0, pontos6 = 0;

            foreach (Trilhas trilha in trilhas)
            {
                if (trilha.Id == opcao1)
                {
                    pontos1 += trilha.PontosSemAlpinista;
                }

                if (trilha.Id == opcao2)
                {
                    pontos2 += trilha.PontosSemAlpinista;
                }

                if (trilha.Id == opcao3)
                {
                    pontos3 += trilha.PontosSemAlpinista;
                }

                if (trilha.Id == opcao4)
                {
                    pontos4 += trilha.PontosSemAlpinista;
                }

                if (trilha.Id == opcao5)
                {
                    pontos5 += trilha.PontosSemAlpinista;
                }

                if (trilha.Id == opcao6)
                {
                    pontos6 += trilha.PontosSemAlpinista;
                }
            }


            if (pontos1 >= pontos2 && pontos1 >= pontos3 && pontos1 >= pontos4 && pontos1 >= pontos5 && pontos1 >= pontos6)
            {
                pontos += pontos1;
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1423", (opcao1 + "0"));
            }

            else if (pontos2 >= pontos1 && pontos2 >= pontos3 && pontos2 >= pontos4 && pontos2 >= pontos5 && pontos2 >= pontos6)
            {
                pontos += pontos2;
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", (opcao2 + "0"));
            }

            else if (pontos3 >= pontos1 && pontos3 >= pontos2 && pontos3 >= pontos4 && pontos3 >= pontos5 && pontos3 >= pontos6)
            {
                pontos += pontos3;
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2413", (opcao3 + "0"));

            }

            else if (pontos4 >= pontos1 && pontos4 >= pontos2 && pontos4 >= pontos3 && pontos4 >= pontos5 && pontos4 >= pontos6)
            {
                pontos += pontos4;
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (opcao4 + "0"));
            }

            else if (pontos5 >= pontos1 && pontos5 >= pontos2 && pontos5 >= pontos3 && pontos5 >= pontos4 && pontos5 >= pontos6)
            {
                pontos += pontos5;
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "3412", (opcao5 + "0"));
            }

            else
            {
                pontos += pontos6;
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2314", (opcao6 + "0"));
            }


            if (mover != "")
            {

                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1423", (opcao1 + "0"));

                if (mover != "")
                {

                    mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", (opcao2 + "0"));

                    if (mover != "")
                    {

                        mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2413", (opcao3 + "0"));

                        if (mover != "")
                        {

                            mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (opcao4 + "0"));

                            if (mover != "")
                            {

                                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "3412", (opcao5 + "0"));

                                if (mover != "")
                                {
                                    pontos += pontos6;
                                    mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2314", (opcao6 + "0"));
                                }
                                else
                                {
                                    Console.WriteLine("erro");
                                }
                            }
                            else
                            {
                                pontos += pontos4;
                            }
                        }
                        else
                        {
                            pontos += pontos3;
                        }

                    }
                    else
                    {
                        pontos += pontos2;
                    }
                }
                else
                {
                    pontos += pontos1;
                }
            }
            Console.WriteLine(mover);
        }

        public void movimentaAlpinista()
        {

        }

        /*
            Timer
        */
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (jogoCompleto() == false)
            {
                historicopartida();
            }
            else
            {
                timerHistorico.Enabled = false;
            }
        }
        private void timerTabuleiro_Tick(object sender, EventArgs e)
        {
            if (jogoCompleto())
            {
                verificadordeTabuleiro();
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
                    if (pontos <= 36)
                    {
                        rolardados();
                        movimenta2();
                    }
                    else
                    {
                        acabaVez();
                    }
                }

                if(!NossaVez)
                {
                    pontos = 0;
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
                pictureBox.Location = new Point(25, 0);
            }
            if (cor.Contains("verde"))
            {
                pictureBox.Location = new Point(0, 22);
            }
            if (cor.Contains("amarelo"))
            {
                pictureBox.Location = new Point(25, 22);
            }

            pictureBox.Width = 20;
            pictureBox.Height = 20;
            pictureBox.BackgroundImage = new Bitmap(@"..\..\Imagens\jogador" + cor + ".png");
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void lstHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void validaAlpinista(string player)
        {
            if (int.Parse(player) == int.Parse(Lobby.jogadorVermelho))
            {
                cor = "vermelho" + validaBouA;
            }
            else if (int.Parse(player) == int.Parse(Lobby.jogadorAzul))
            {
                cor = "azul" + validaBouA;
            }
            else if (int.Parse(player) == int.Parse(Lobby.jogadorVerde))
            {
                cor = "verde" + validaBouA;
            }
            else if (int.Parse(player) == int.Parse(Lobby.jogadorAmarelo))
            {
                cor = "amarelo" + validaBouA;
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
        }

        public void carregaTrilhas()
        {
            trilhas.Add(new Trilhas("2", 3, 12, 6));
            trilhas.Add(new Trilhas("3", 5, 10, 5));
            trilhas.Add(new Trilhas("4", 7, 8, 4));
            trilhas.Add(new Trilhas("5", 9, 6, 3));
            trilhas.Add(new Trilhas("6", 11, 4, 2));
            trilhas.Add(new Trilhas("7", 13, 2, 1));
            trilhas.Add(new Trilhas("8", 11, 4, 2));
            trilhas.Add(new Trilhas("9", 9, 6, 3));
            trilhas.Add(new Trilhas("A", 7, 8, 4));
            trilhas.Add(new Trilhas("B", 5, 10, 5));
            trilhas.Add(new Trilhas("C", 3, 12, 6));
        }
    }

}
