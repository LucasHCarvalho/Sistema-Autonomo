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
        public Lobby()
        {
            InitializeComponent();
            lblVersao.Text = "Versão " + Jogo.Versao;
            mostrarLista();
        }

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
        public void playerCor(int numJogadores)
        {
            string lista = lblTratativaErro.Text;
            string[] itens = lista.Split(',');
            if (numJogadores == 1)
            {
                jogadorVermelho = itens[2];
                MessageBox.Show("Jogador da cor: " + jogadorVermelho + " Criado com sucesso!");
            }else if(numJogadores == 2)
            {
                jogadorAzul = itens[2];
                MessageBox.Show("Jogador da cor: " + jogadorAzul + " Criado com sucesso!");
            } else if(numJogadores == 3)
            {
                jogadorVerde = itens[2];
                MessageBox.Show("Jogador da cor: " + jogadorVerde + " Criado com sucesso!");
            } else if(numJogadores == 4)
            {
                jogadorAmarelo = itens[2];
                MessageBox.Show("Jogador da cor: " + jogadorAmarelo + " Criado com sucesso!");
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
            string entrar = Jogo.EntrarPartida(IdPartida, txtNomeJogador.Text, txtSenhaPartida.Text);
            lblTratativaErro.Text = entrar;
            string res = lblTratativaErro.Text.ToString().Substring(0, 1);
            if (res != "E")
            {
                numJogadores += 1;
                playerCor(numJogadores);
            
            mostrarJogadores(IdPartida);
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string criarPartida = Jogo.CriarPartida(txtCriarPartida.Text, txtSenhaPartida.Text);
            lblTratativaErro.Text = criarPartida;
            string res = lblTratativaErro.Text.ToString().Substring(0, 1);
            if (res != "E")
            {
                IdPartida = Convert.ToInt32(criarPartida);
                string entrar = Jogo.EntrarPartida(IdPartida, txtNomeJogador.Text, txtSenhaPartida.Text);
                lblTratativaErro.Text = entrar;
                numJogadores += 1;
                playerCor(numJogadores);
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
            string lista = lblTratativaErro.Text.ToString();
            string[] itens = lista.Split(',');
            string res = lblTratativaErro.Text.ToString().Substring(0, 1);
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
    }
}
