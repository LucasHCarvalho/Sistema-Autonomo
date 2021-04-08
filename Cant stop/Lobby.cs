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
        public static int IdPartida{ get; set; }
        public static int IdJogador { get; set; }
        public static string senhaJogador { get; set; }
        public Lobby()
        {
            InitializeComponent();
            lblVersao.Text = "Versão " + Jogo.Versao;
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
            string entrar = Jogo.EntrarPartida(IdPartida, txtNomeJogador.Text, txtSenha.Text);
            lblTratativaErro.Text = entrar;
    }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string criarPartida = Jogo.CriarPartida(txtCriarPartida.Text, txtSenhaPartida.Text);
            lblTratativaErro.Text = criarPartida;
        }

        private void btnListaJogadores_Click(object sender, EventArgs e)
        {
            string linha = lstListarPartidas.SelectedItem.ToString();
            string[] itens = linha.Split(',');
            IdPartida = Convert.ToInt32(itens[0]);
            
            string listajogadores = Jogo.ListarJogadores(IdPartida);
            /*listajogadores = listajogadores.Replace("\r", "");*/
            string[] espaco = listajogadores.Split('\n');
            lstListaJogadores.Items.Clear();
            for (int i = 0; i < espaco.Length; i++)
            {
                lstListaJogadores.Items.Add(espaco[i]);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaPartida_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstListarPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstListaJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblversao_Click(object sender, EventArgs e)
        {
            
        }

        private void Lobby_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string lista = lblTratativaErro.Text.ToString();
            string[] itens = lista.Split(',');
            string res = lblTratativaErro.Text.ToString().Substring(0, 1);
            if(res == "E")
            {
                MessageBox.Show("Erro: Senha de acesso para iniciar partida incorreto", "Senha incorreta",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else { 
            IdJogador = Convert.ToInt32(itens[0]);
            senhaJogador = itens[1];
            MessageBox.Show(senhaJogador);
            string partida = Jogo.IniciarPartida(IdJogador, senhaJogador);
            inGame ingame = new inGame();
            ingame.ShowDialog();
            }
        }

        private void lblTratativaErro_Click(object sender, EventArgs e)
        {

        }
    }
}
