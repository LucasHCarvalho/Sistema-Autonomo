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
        public int dado1, dado2, dado3, dado4;
        public string cor;
        public string Alpinista1 = "N", Alpinista2 = "N", Alpinista3 = "N";
        public bool NossaVez = false;
        public string validaBouA;
        public int pontos = 0, alpinista = 3, trilhasDominadas = 0, trilhasConquistadas = 0;

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
            //Verifica se o jogo já está completo e retorna a resposta.

            string retorno = Jogo.ListarPartidas("E");
            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');

            //Lista partidas, se alguma partida finalizada for a nossa, ele retorna jogo completo.
            for (int i = 0; i < linha.Length - 1; i++)
            {
                string[] partidaide = linha[i].Split(',');
                if (Convert.ToInt32(partidaide[0]) == Lobby.IdPartida)
                    return true;
            }
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

            //Verifica de quem é a vez, mudando o texto de quem for a vez, e as cores das letras.
            //Caso seja a vez do nosso jogador retorna Nossa vez.

            //Verifica se existe o jogador, caso sim verifica a cor.
            if(lista.Substring(0,4) != "ERRO")
            {
                if (int.Parse(itens[1]) == int.Parse(Lobby.jogadorVermelho))
                {
                    lstHistorico.ForeColor = Color.Red;
                    lblCor.ForeColor = System.Drawing.Color.Red;
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
        }
        private void verificadordeTabuleiro()
        {
            //Atualiza os movimentos, limpando a tela e adicionando novamente a posição atual.
            limpaTela();

            string verificaTabuleiro = Jogo.ExibirTabuleiro(Lobby.IdPartida);
            verificaTabuleiro = verificaTabuleiro.Replace("\r", "");
            string[] linhas = verificaTabuleiro.Split('\n');
            alpinista = 3;
            trilhasDominadas = 0;
            trilhasConquistadas = 0;

            for (int i = 0; i < linhas.Length; i++)
            {
                if (linhas[i] != "")
                {
                    //Guarda os dados de cada linha do retorno do tabuleiro.
                    string[] posicoes = linhas[i].Split(',');

                    int coluna = Convert.ToInt32(posicoes[0]) - 2;
                    int linha = 13 - Convert.ToInt32(posicoes[1]);
                    string player = posicoes[2];
                    validaBouA = posicoes[3];
                    validaAlpinista(player);

                    if (NossaVez)
                    {
                        //Atualiza os alpinistas e as trilhas.
                        contaAlpinista(coluna);
                        atualizaTrilhas(player, coluna, Convert.ToInt32(posicoes[1]), validaBouA);
                    }                   

                    //Desenha na tela os jogadores.
                    printaImagem(coluna, linha);
                }
            }
        }
        public void limpaTela()
        {
            //Apaga tudo o que foi posicionado nos painéis do Grid.
            for (int i = 0; i <= 12; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Control posicao = tableLayoutPanel1.GetControlFromPosition(j, i);
                    if (posicao != null)
                        posicao.Controls.Clear();
                }
            }
        }
        public void acabaVez()
        {
            //Volta os valores dos pontos e finaliza a jogada.

            pontos = 0;
            alpinista = 3;
            trilhasDominadas = 0;
            trilhasConquistadas = 0;
            NossaVez = false;
            string paraTabuleiro = Jogo.Parar(Lobby.IdJogador, Lobby.senhaJogador);
            //Console.WriteLine(paraTabuleiro);
        }
        public void historicopartida()
        {
            //Demonstra o histórico da partida, com os ultimos 36 acontecimentos(tamanho da tela).

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
        //Movimentos de 2 alpinistas.
        public string move2OP1()
        {
            //Soma: D1D2 + D3D4
            string soma1 = somaDados(dado1, dado2);
            string soma2 = somaDados(dado3, dado4);
            string trilhas = (soma1 + soma2);

            return trilhas;
        }
        public string move2OP2()
        {
            //Soma: D1D3 + D2D4
            string soma1 = somaDados(dado1, dado3);
            string soma2 = somaDados(dado2, dado4);
            string trilhas = (soma1 + soma2);

            return trilhas;
        }
        public string move2OP3()
        {
            //Soma: D1D4 + D2D3
            string soma1 = somaDados(dado1, dado4);
            string soma2 = somaDados(dado2, dado3);
            string trilhas = (soma1 + soma2);

            return trilhas;
        }

        //Movimentos de 1 alpinista.
        public string move1OP1()
        {
            //Dados: D1D4
            string soma1 = somaDados(dado1, dado4);

            return soma1;
        }
        public string move1OP2()
        {
            //Dados: D1D3
            string soma1 = somaDados(dado1, dado3);

            return soma1;
        }
        public string move1OP3()
        {
            //Dados: D2D4
            string soma1 = somaDados(dado2, dado4);

            return soma1;
        }
        public string move1OP4()
        {
            //Dados: D1D2
            string soma1 = somaDados(dado1, dado2);

            return soma1;
        }
        public string move1OP5()
        {
            //Dados: D3D4
            string soma1 = somaDados(dado3, dado4);

            return soma1;
        }
        public string move1OP6()
        {
            //Dados: D2D3
            string soma1 = somaDados(dado2, dado3);

            return soma1;
        }

        //Movimenta novos alpinistas.
        public void movimenta2()
        {
            //Seleciona os movimentos possiveis e conta o valor de cada movimento, de acordo com o ponto.
            string opcao1 = move2OP1();
            string opcao2 = move2OP2();
            string opcao3 = move2OP3();
            string mover;
            int pontos1 = 0, pontos2 = 0, pontos3 = 0;

            foreach (Trilhas trilha in trilhas)
            {
                if (trilha.Id == opcao1.Substring(0, 1))
                    pontos1 += trilha.Pontostrilha;

                if (trilha.Id == opcao1.Substring(1, 1))
                    pontos1 += trilha.Pontostrilha;

                if (trilha.Id == opcao2.Substring(0, 1))
                    pontos2 += trilha.Pontostrilha;

                if (trilha.Id == opcao2.Substring(1, 1))
                    pontos2 += trilha.Pontostrilha;

                if (trilha.Id == opcao3.Substring(0, 1))
                    pontos3 += trilha.Pontostrilha;

                if (trilha.Id == opcao3.Substring(1, 1))
                    pontos3 += trilha.Pontostrilha;
            }

            if (pontos1 >= pontos2 && pontos1 >= pontos3)
            {
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", opcao1);
                if (mover == "")
                {
                    pontos += contarPontos(opcao1.Substring(0, 1));
                    pontos += contarPontos(opcao1.Substring(1, 1));
                }
            }
            else if (pontos2 >= pontos1 && pontos2 >= pontos3)
            {
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", opcao2);
                if (mover == "")
                {
                    pontos += contarPontos(opcao2.Substring(0, 1));
                    pontos += contarPontos(opcao2.Substring(1, 1));
                }
            }
            else
            {
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1423", opcao3);
                if (mover == "")
                {
                    pontos += contarPontos(opcao3.Substring(0, 1));
                    pontos += contarPontos(opcao3.Substring(1, 1));
                }
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
                            movimenta1();
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
        }
        public void movimenta1()
        {
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
                    pontos1 += trilha.Pontostrilha;

                if (trilha.Id == opcao2)
                    pontos2 += trilha.Pontostrilha;

                if (trilha.Id == opcao3)
                    pontos3 += trilha.Pontostrilha;

                if (trilha.Id == opcao4)
                    pontos4 += trilha.Pontostrilha;

                if (trilha.Id == opcao5)
                    pontos5 += trilha.Pontostrilha;

                if (trilha.Id == opcao6)
                    pontos6 += trilha.Pontostrilha;
            }

            if (pontos1 >= pontos2 && pontos1 >= pontos3 && pontos1 >= pontos4 && pontos1 >= pontos5 && pontos1 >= pontos6)
            {
                pontos += contarPontos(opcao1);
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1423", (opcao1 + "0"));
            }
            else if (pontos2 >= pontos1 && pontos2 >= pontos3 && pontos2 >= pontos4 && pontos2 >= pontos5 && pontos2 >= pontos6)
            {
                pontos += contarPontos(opcao2);
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", (opcao2 + "0"));
            }
            else if (pontos3 >= pontos1 && pontos3 >= pontos2 && pontos3 >= pontos4 && pontos3 >= pontos5 && pontos3 >= pontos6)
            {
                pontos += contarPontos(opcao3);
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2413", (opcao3 + "0"));
            }
            else if (pontos4 >= pontos1 && pontos4 >= pontos2 && pontos4 >= pontos3 && pontos4 >= pontos5 && pontos4 >= pontos6)
            {
                pontos += contarPontos(opcao4);
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (opcao4 + "0"));
            }
            else if (pontos5 >= pontos1 && pontos5 >= pontos2 && pontos5 >= pontos3 && pontos5 >= pontos4 && pontos5 >= pontos6)
            {
                pontos += contarPontos(opcao5);
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "3412", (opcao5 + "0"));
            }
            else
            {
                pontos += contarPontos(opcao6);
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
                                    pontos += contarPontos(opcao6);
                                }
                            }
                            else
                            {
                                pontos += contarPontos(opcao5);
                            }
                        }
                        else
                        {
                            pontos += contarPontos(opcao4);
                        }

                    }
                    else
                    {
                        pontos += contarPontos(opcao3);
                    }
                }
                else
                {
                    pontos += contarPontos(opcao2);
                }
            }
            else
            {
                pontos += contarPontos(opcao1);
            }
        }

        //Movimenta alpinistas ja usados.
        public void movimenta1Alpinista()
        {
            string movimento = move1OP1();
            string mover = "N";

            if (Alpinista3 == movimento || Alpinista2 == movimento || Alpinista1 == movimento)
            {
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1423", (movimento + "0"));
                if(mover == "")
                    pontos += contarPontosA(movimento);
            }
            else
            {
                movimento = move1OP2();
                if (Alpinista3 == movimento || Alpinista2 == movimento || Alpinista1 == movimento)
                {
                    mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", (movimento + "0"));
                    if (mover == "")
                        pontos += contarPontosA(movimento);
                }
                else
                {
                    movimento = move1OP3();
                    if (Alpinista3 == movimento || Alpinista2 == movimento)
                    {
                        mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2413", (movimento + "0"));
                        if (mover == "")
                            pontos += contarPontosA(movimento);
                    }
                    else
                    {
                        movimento = move1OP4();
                        if (Alpinista3 == movimento || Alpinista2 == movimento || Alpinista1 == movimento)
                        {
                            mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", (movimento + "0"));
                            if (mover == "")
                                pontos += contarPontosA(movimento);
                        }
                        else
                        {
                            movimento = move1OP5();
                            if (Alpinista3 == movimento || Alpinista2 == movimento || Alpinista1 == movimento)
                            {
                                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "3412", (movimento + "0"));
                                if (mover == "")
                                    pontos += contarPontosA(movimento);
                            }
                            else
                            {
                                movimento = move1OP6();
                                if (Alpinista3 == movimento || Alpinista2 == movimento || Alpinista1 == movimento)
                                {
                                    mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "2314", (movimento + "0"));
                                    if (mover == "")
                                        pontos += contarPontosA(movimento);
                                }
                            }
                        }
                    }
                }
            }

            if (mover == "N")
                movimenta2Alpinistas();
            if (mover != "")
                if (mover.Substring(0, 1) == "E")
                    movimenta2Alpinistas();
        }
        public void movimenta2Alpinistas()
        {
            string movimento1, movimento2, movimento;
            string mover = "N";
            movimento = move2OP1();
            movimento1 = move2OP1().Substring(0, 1);
            movimento2 = move2OP1().Substring(1, 1);

            if (Alpinista3 == movimento1 && Alpinista2 == movimento2 || Alpinista3 == movimento2 && Alpinista2 == movimento1 || Alpinista3 == movimento1 && Alpinista1 == movimento2 || Alpinista3 == movimento2 && Alpinista1 == movimento1 || Alpinista2 == movimento1 && Alpinista1 == movimento2 || Alpinista2 == movimento2 && Alpinista1 == movimento1)
            {
                mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1234", movimento);
                pontos += contarPontosA(movimento1);
                pontos += contarPontosA(movimento2);
            }
            else
            {
                movimento = move2OP2();
                movimento1 = move2OP2().Substring(0, 1);
                movimento2 = move2OP2().Substring(1, 1);
                if (Alpinista3 == movimento1 && Alpinista2 == movimento2 || Alpinista3 == movimento2 && Alpinista2 == movimento1 || Alpinista3 == movimento1 && Alpinista1 == movimento2 || Alpinista3 == movimento2 && Alpinista1 == movimento1 || Alpinista2 == movimento1 && Alpinista1 == movimento2 || Alpinista2 == movimento2 && Alpinista1 == movimento1)
                {
                    mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1324", movimento);
                    pontos += contarPontosA(movimento1);
                    pontos += contarPontosA(movimento2);
                }
                else
                {
                    movimento = move2OP3();
                    movimento1 = move2OP3().Substring(0, 1);
                    movimento2 = move2OP3().Substring(1, 1);
                    if (Alpinista3 == movimento1 && Alpinista2 == movimento2 || Alpinista3 == movimento2 && Alpinista2 == movimento1 || Alpinista3 == movimento1 && Alpinista1 == movimento2 || Alpinista3 == movimento2 && Alpinista1 == movimento1 || Alpinista2 == movimento1 && Alpinista1 == movimento2 || Alpinista2 == movimento2 && Alpinista1 == movimento1)
                    {
                        mover = Jogo.Mover(Lobby.IdJogador, Lobby.senhaJogador, "1423", movimento);
                        pontos += contarPontosA(movimento1);
                        pontos += contarPontosA(movimento2);
                    }
                }
            }

            if (mover == "N")
                movimenta2();
        }

        //Realiza o movimento.
        public void movimentacao()
        {
            rolardados();

            if (alpinista == 3)
                movimenta2();
            else
                movimenta1Alpinista();

            Alpinista3 = Alpinista2 = Alpinista1 = "N";
            verificadordeTabuleiro();
        }


        /*
            Timer
        */
        private void timer1_Tick(object sender, EventArgs e)
        { 
            if (!jogoCompleto())
            {
                historicopartida();
            }
            else
            {
                historicopartida();
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
                timerVerificaVez.Enabled = false;

            if (timerVerificaVez.Enabled)
            {
                verificarvez();                              

                if (NossaVez)
                {
                    if (trilhasDominadas >= 2 || (trilhasDominadas >= 1 && trilhasConquistadas >= 2))
                    {
                        acabaVez();
                        timerTabuleiro.Enabled = true;
                        //alpinista = 0;
                        //pontos = 30;
                    }
                    else
                    {
                        Console.WriteLine("-X-X-X-PONTOS-X-X-X-");
                        Console.WriteLine(pontos);
                        Console.WriteLine("-X-X-X-X-X-X-X-X-X-\n-X-X-X-ALPINISTA-X-X-X-\n");
                        Console.WriteLine(alpinista);

                        timerTabuleiro.Enabled = false;

                        if (alpinista != 0)
                            movimentacao();
                        else if (pontos <= 28)
                            movimentacao();
                        else
                        {
                            acabaVez();
                            timerTabuleiro.Enabled = true;
                        }
                    }                    
                }
                else
                {
                    timerTabuleiro.Enabled = true;
                    pontos = 0;
                    alpinista = 3;
                    trilhasDominadas = 0;
                    Alpinista3 = Alpinista2 = Alpinista1 = "N";
                }
            }
        }

        /*
            Logicas
        */
        public void printaImagem(int coluna, int linha)
        {
            //Verifica a cor do de acordo com a função "validaAlpinista" criando a posição no local destinado a cada cor.
            //Pega a posição do painel referente a coluna e linha para adicionar um jogador.

            Control posicao = tableLayoutPanel1.GetControlFromPosition(coluna, linha);
            PictureBox pictureBox = new PictureBox();
            posicao.Controls.Add(pictureBox);

            if (cor.Contains("vermelho"))
                pictureBox.Location = new Point(0, 0);
            else if (cor.Contains("azul"))
                pictureBox.Location = new Point(25, 0);
            else if (cor.Contains("verde"))
                pictureBox.Location = new Point(0, 22);
            else if (cor.Contains("amarelo"))
                pictureBox.Location = new Point(25, 22);

            pictureBox.Width = 20;
            pictureBox.Height = 20;
            pictureBox.BackgroundImage = new Bitmap(@"..\..\Imagens\jogador" + cor + ".png");
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void validaAlpinista(string player)
        {
            if (int.Parse(player) == int.Parse(Lobby.jogadorVermelho))
                cor = "vermelho" + validaBouA;
            else if (int.Parse(player) == int.Parse(Lobby.jogadorAzul))
                cor = "azul" + validaBouA;
            else if (int.Parse(player) == int.Parse(Lobby.jogadorVerde))
                cor = "verde" + validaBouA;
            else if (int.Parse(player) == int.Parse(Lobby.jogadorAmarelo))
                cor = "amarelo" + validaBouA;
        }
        public string somaDados(int dado1, int dado2)
        {
            //Altera a soma dos dados para HexaDecimal.

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
            //Rola os dados e guarda o valor nas variaveis.

            dadosGlobal = Jogo.RolarDados(Lobby.IdJogador, Lobby.senhaJogador);

            dadosGlobal = dadosGlobal.Replace("\r", "");
            dadosGlobal = dadosGlobal.Replace("\n", "");

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
        public void contaAlpinista(int coluna)
        {
            if (validaBouA == "A")
            {
                if (alpinista == 3)
                {
                    Alpinista3 = somaDados(coluna, 2);
                    alpinista -= 1;
                }
                else if (alpinista == 2)
                {
                    Alpinista2 = somaDados(coluna, 2);
                    alpinista -= 1;
                }
                else if (alpinista == 1)
                {
                    Alpinista1 = somaDados(coluna, 2);
                    alpinista -= 1;
                }
            }
        }
        public void atualizaTrilhas(string id, int coluna, int linha, string valida)
        {
            resetaTamanho();

            string posicao = somaDados(coluna, 2);
            if(int.Parse(id) == Lobby.IdJogador)
            {
                //onde achei minha base tenho que retirar 1 de tamanho e atualizar o valor de pontos de movimento naquela trilha.
                foreach (Trilhas trilha in trilhas)
                { 
                    if(trilha.Id == posicao)
                    {
                        trilha.Tamanho -= linha;
                        if (valida == "A")
                        {
                            if (trilha.Tamanho == 0)
                                trilhasDominadas += 1;
                        }
                        else
                        {
                            if (trilha.Tamanho == 0)
                                trilhasConquistadas += 1;
                        }
                        
                        trilha.Pontostrilha = 13 - trilha.Tamanho;
                    }
                }
            }
        }
        public int contarPontos(string id)
        {
            int pontosTrilha = 0;

            foreach (Trilhas trilha in trilhas)
            {
                if (trilha.Id == id)
                    pontosTrilha = trilha.PontosSemAlpinista;
            }

            return pontosTrilha;
        }
        public int contarPontosA(string id)
        {
            int pontosTrilha = 0;

            foreach (Trilhas trilha in trilhas)
            {
                if (trilha.Id == id)
                    pontosTrilha = trilha.PontosComAlpinista;
            }

            return pontosTrilha;
        }
        public void resetaTamanho()
        {
            foreach (Trilhas trilha in trilhas)
            {
                trilha.Tamanho = trilha.TamanhoOriginal;
                trilha.Pontostrilha = 13 - trilha.Tamanho;             
            }
        }

    }

}
