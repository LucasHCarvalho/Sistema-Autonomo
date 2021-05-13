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
        public int numJogadores { get; set; }
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

            string listajogadores = Jogo.ListarJogadores(IdPartida);
            string[] espaco = listajogadores.Split('\n');

            lstListaJogadores.Items.Clear();

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
                    Console.WriteLine("Jogador Vermelho Criado: " + jogadorVermelho);
                }
                else if (i == 1)
                {
                    jogadorAzul = itens[0];
                    nomeJAzul = itens[1];
                    lblAzul.Text = nomeJAzul;
                    Console.WriteLine("Jogador Azul Criado: " + jogadorAzul);
                }
                else if (i == 2)
                {
                    jogadorVerde = itens[0];
                    nomeJVerde = itens[1];
                    lblVerde.Text = nomeJVerde;
                    Console.WriteLine("Jogador Verde Criado: " + jogadorVerde);
                }
                else if (i == 3)
                {
                    jogadorAmarelo = itens[0];
                    nomeJAmarelo = itens[1];
                    lblAmarelo.Text = nomeJAmarelo;
                    Console.WriteLine("Jogador Amarelo Criado: " + jogadorAmarelo);
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
                lblTratativaErro.Text = "Partida Criada! ";
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
                string partida = Jogo.IniciarPartida(IdJogador, senhaJogador);
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
            playerCor();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarJogadores(IdPartida);
        }

        private void Lobby_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTratativaErro_Click(object sender, EventArgs e)
        {

        }

        private void lblVersao_Click(object sender, EventArgs e)
        {

        }

        private void lstListaJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaPartida_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenhaPartida_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeJogador_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNomeJogador_Click(object sender, EventArgs e)
        {

        }

        private void lblCriarPartida_Click(object sender, EventArgs e)
        {

        }

        private void txtCriarPartida_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pcAmarelo_Click(object sender, EventArgs e)
        {

        }

        /*public void tocamusica()
        {
            SoundPlayer splayer = new SoundPlayer(@"..\..\Imagens\lobbymusic.wav");
            splayer.Play();
        }*/
    }
}
