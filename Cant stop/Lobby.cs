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
        public int IdPartida{ get; set; }

        public Lobby()
        {
            InitializeComponent();
        }

        private void btnMostraLista_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');

            for (int i = 0; i < linha.Length; i++)
            {
                lstListarPartidas.Items.Add(linha[i]);
            }
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            string linha = lstListarPartidas.SelectedItem.ToString();
            string[] itens = linha.Split(',');
            this.IdPartida = Convert.ToInt32(itens[0]);
            this.Close();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string linha = lstListarPartidas.SelectedItem.ToString();
            string[] itens = linha.Split(',');
            this.IdPartida = Convert.ToInt32(itens[0]);
            string jogador = Jogo.EntrarPartida(this.IdPartida, txtNomeJogador.Text, txtSenha.Text);   
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
           string criarPartida = Jogo.CriarPartida(txtCriarPartida.Text, txtSenhaPartida.Text);
        }

        private void btnListaJogadores_Click(object sender, EventArgs e)
        {
            string linha = lstListarPartidas.SelectedItem.ToString();
            string[] itens = linha.Split(',');
            this.IdPartida = Convert.ToInt32(itens[0]);

            string listajogadores = Jogo.ListarJogadores(this.IdPartida);
            listajogadores = listajogadores.Replace("\r", "");
            string[] espaco = listajogadores.Split('\n');

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
    }
}
