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
        public Lobby()
        {
            InitializeComponent();
            lblVersao.Text = "Versão " + Jogo.Versao;
            mostrarLista();
        }

        /*public void tocamusica()
        {
            SoundPlayer splayer = new SoundPlayer(@"..\..\Imagens\lobbymusic.wav");
            splayer.Play();
        }*/
        public void mostrarLista()
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');

            lstListarPartidas.Items.Clear();
            for (int i = 0; i < linha.Length; i++)
            {
                lstListarPartidas.Items.Add(linha[i]);
            }

        }
        public void mostrarJogadores(int IdPartida)
        {
            string listajogadores = Jogo.ListarJogadores(IdPartida);
            string[] espaco = listajogadores.Split('\n');
            lstListaJogadores.Items.Clear();
            for (int i = 0; i < espaco.Length; i++)
            {
                lstListaJogadores.Items.Add(espaco[i]);
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
                }
                else if (i == 1)
                {
                    jogadorAzul = itens[0];
                    nomeJAzul = itens[1];
                }
                else if (i == 2)
                {
                    jogadorVerde = itens[0];
                    nomeJVerde = itens[1];
                }
                else
                {
                    jogadorAmarelo = itens[0];
                    nomeJAmarelo = itens[1];
                }
            }
        }
        private void btnMostraLista_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');

            lstListarPartidas.Items.Clear();
            for (int i = 0; i < linha.Length; i++)
            {
                lstListarPartidas.Items.Add(linha[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string linha = lstListarPartidas.SelectedItem.ToString();
            string[] itens = linha.Split(',');
            IdPartida = Convert.ToInt32(itens[0]);
            entrar = Jogo.EntrarPartida(IdPartida, txtNomeJogador.Text, txtSenhaPartida.Text);
            string res = entrar.Substring(0, 1);
            if (res == "E")
            {
                lblTratativaErro.Text = entrar;
            }
            mostrarJogadores(IdPartida);
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string criarPartida = Jogo.CriarPartida(txtCriarPartida.Text, txtSenhaPartida.Text);
            lblTratativaErro.Text = criarPartida;
            string res = lblTratativaErro.Text.ToString().Substring(0, 1);
            if (res != "E")
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

        private void btnListaJogadores_Click(object sender, EventArgs e)
        {
            string listajogadores = Jogo.ListarJogadores(IdPartida);
            string[] espaco = listajogadores.Split('\n');
            lstListaJogadores.Items.Clear();
            for (int i = 0; i < espaco.Length; i++)
            {
                lstListaJogadores.Items.Add(espaco[i]);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string lista = entrar;
            string[] itens = lista.Split(',');
            string res = entrar.Substring(0, 1);
            if (res == "E")
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

        private void Lobby_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaPartida_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstListarPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTratativaErro_Click(object sender, EventArgs e)
        {

        }

        private void btnListaPartidas_Click(object sender, EventArgs e)
        {
            mostrarLista();
        }

        private void lblSenhaJogador_Click(object sender, EventArgs e)
        {

        }

        private void txtSenhaPartida_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Lobby_Load_1(object sender, EventArgs e)
        {

        }

        private void lstListaJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCriarErro_Click(object sender, EventArgs e)
        {

        }

        private void lstListarPartidas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string linha = lstListarPartidas.SelectedItem.ToString();
            string[] itens = linha.Split(',');
            IdPartida = Convert.ToInt32(itens[0]);

            string listajogadores = Jogo.ListarJogadores(IdPartida);
            string[] espaco = listajogadores.Split('\n');
            lstListaJogadores.Items.Clear();
            for (int i = 0; i < espaco.Length; i++)
            {
                lstListaJogadores.Items.Add(espaco[i]);
            }
        }

        private void lblCriarPartida_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeJogador_Click(object sender, EventArgs e)
        {

        }
        
        private void lstListarPartidas_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            {
                string linha = lstListarPartidas.SelectedItem.ToString();
                string[] itens = linha.Split(',');
                IdPartida = Convert.ToInt32(itens[0]);

                string listajogadores = Jogo.ListarJogadores(IdPartida);
                string[] espaco = listajogadores.Split('\n');
                lstListaJogadores.Items.Clear();
                for (int i = 0; i < espaco.Length; i++)
                {
                    lstListaJogadores.Items.Add(espaco[i]);
                }
            }
        
        }
    }

}
