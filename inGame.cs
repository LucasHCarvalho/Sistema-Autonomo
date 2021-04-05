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
    public partial class inGame : Form
    {
        public inGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPartidasJ_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("J");
            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');

            lstJogadores.Items.Clear();
            for (int i = 0; i < linha.Length; i++)
            {
                lstJogadores.Items.Add(linha[i]);
            }
        }
    }
}
