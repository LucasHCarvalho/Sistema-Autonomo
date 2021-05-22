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
using System.Media;
namespace Cant_stop
{
    public partial class Lobby : Form
    {
        /*
            Variaveis
        */
        public static int IdPartida { get; set; }
        public static int IdJogador { get; set; }
        public static string senhaJogador { get; set; }
        public static string jogadorVermelho { get; set; }
        public static string jogadorAzul { get; set; }
        public static string jogadorVerde { get; set; }
        public static string jogadorAmarelo { get; set; }
        public static string nomeJVermelho { get; set; }
        public static string nomeJAzul { get; set; }
        public static string nomeJVerde { get; set; }
        public static string nomeJAmarelo { get; set; }
        public static string entrar { get; set; }
        public static string nossoJogador { get; set; }
        
        /*
            Funções
        */
        public Lobby()
        {
            InitializeComponent();
            lblVersao.Text = "Versão " + Jogo.Versao;
            mostrarLista();
            lstListaJogadores.Margin = new Padding(0, 0, 0, 10);
            lstListaJogadores.Padding = new Padding(10);
            lstListaJogadores.Visible = false;
        }

        public void mostrarLista()
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');

            lstListarPartidas.Items.Clear();

            for (int i = 0; i < linha.Length - 1; i++)
            {
                lstListarPartidas.Items.Add(linha[i]);
            }
        }
        public void mostrarJogadores(int IdPartida)
        {
            pcVermelho.Visible = false;
            pcAzul.Visible = false;
            pcVerde.Visible = false;
            pcAmarelo.Visible = false;
            lblVermelho.Visible = false;
            lblAzul.Visible = false;
            lblVerde.Visible = false;
            lblAmarelo.Visible = false;

            lstListaJogadores.Items.Clear();

            string listajogadores = Jogo.ListarJogadores(IdPartida);
            string[] espaco = listajogadores.Split('\n');
            
            for (int i = 0; i < espaco.Length; i++)
            {
                lstListaJogadores.Items.Add(espaco[i]);
                if(i == 1)
                {
                    pcVermelho.Visible = true;
                    lblVermelho.Visible = true;
                }
                if (i == 2)
                {
                    pcAzul.Visible = true;
                    lblAzul.Visible = true;
                }
                if (i == 3)
                {
                    pcVerde.Visible = true;
                    lblVerde.Visible = true;
                }
                if (i == 4)
                {
                    pcAmarelo.Visible = true;
                    lblAmarelo.Visible = true;
                }
            }

            playerCor();
        }
        public void playerCor()
        {
            for (int i = 0; i < (lstListaJogadores.Items.Count - 1); i++)
            {
                string lista = lstListaJogadores.Items[i].ToString();
                string[] itens = lista.Split(',');

                if (i == 0)
                {
                    jogadorVermelho = itens[0];
                    nomeJVermelho = itens[1];
                    lblVermelho.Text = nomeJVermelho;
                }
                else if (i == 1)
                {
                    jogadorAzul = itens[0];
                    nomeJAzul = itens[1];
                    lblAzul.Text = nomeJAzul;
                }
                else if (i == 2)
                {
                    jogadorVerde = itens[0];
                    nomeJVerde = itens[1];
                    lblVerde.Text = nomeJVerde;
                }
                else if (i == 3)
                {
                    jogadorAmarelo = itens[0];
                    nomeJAmarelo = itens[1];
                    lblAmarelo.Text = nomeJAmarelo;
                }
            }
        }
        private void btnMostraLista_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');

            lstListarPartidas.Items.Clear();

            for (int i = 0; i < linha.Length - 1; i++)
            {
                lstListarPartidas.Items.Add(linha[i]);
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            nossoJogador = txtNomeJogador.Text;

            string linha = lstListarPartidas.SelectedItem.ToString();
            string[] itens = linha.Split(',');

            IdPartida = Convert.ToInt32(itens[0]);
            entrar = Jogo.EntrarPartida(IdPartida, txtNomeJogador.Text, txtSenhaPartida.Text);

            if (entrar.Substring(0, 1) == "E")
            {
                lblTratativaErro.Text = entrar;
            }
            else 
            {
                lblTratativaErro.Text = "Você entrou na partida!";
                mostrarJogadores(IdPartida);
            }
        }
        private void btnCriar_Click(object sender, EventArgs e)
        {
            nossoJogador = txtNomeJogador.Text;

            string criarPartida = Jogo.CriarPartida(txtCriarPartida.Text, txtSenhaPartida.Text);
            lblTratativaErro.Text = criarPartida;

            if (criarPartida.Substring(0, 1) != "E")
            {
                IdPartida = Convert.ToInt32(criarPartida);
                entrar = Jogo.EntrarPartida(IdPartida, txtNomeJogador.Text, txtSenhaPartida.Text);
                lblTratativaErro.Text = "Partida Criada!";
                mostrarJogadores(IdPartida);
            }
            else
            {
                lblTratativaErro.Text = criarPartida;
            }
            mostrarLista();
        }
        private void btnIniciarPartida_Click_1(object sender, EventArgs e)
        {
            string lista = entrar;
            string[] itens = lista.Split(',');

            if (entrar.Substring(0, 1) == "E")
            {
                MessageBox.Show("Erro: Senha de acesso para iniciar partida incorreto", "Senha incorreta",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IdJogador = Convert.ToInt32(itens[0]);
                senhaJogador = itens[1];
                Jogo.IniciarPartida(IdJogador, senhaJogador);
                playerCor();
                inGame ingame = new inGame();
                ingame.ShowDialog();
            }
        }        
        private void lstListarPartidas_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            string linha = lstListarPartidas.SelectedItem.ToString();
            string[] itens = linha.Split(',');
            IdPartida = Convert.ToInt32(itens[0]);
            mostrarJogadores(IdPartida);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarJogadores(IdPartida);
        }

        /*public void tocamusica()
        {
            SoundPlayer splayer = new SoundPlayer(@"..\..\Imagens\lobbymusic.wav");
            splayer.Play();
        }*/
    }
}
