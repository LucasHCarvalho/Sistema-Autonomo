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
    public partial class Tabuleiro : Form
    {
        public Tabuleiro()
        {
            Lobby lobby = new Lobby();

            lobby.ShowDialog();

            InitializeComponent();

            txtJogadores.Text = Jogo.ListarJogadores(lobby.IdPartida);
        }
    }
}
