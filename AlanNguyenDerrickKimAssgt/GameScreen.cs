using AlanNguyenDerrickKimAssgt.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlanNguyenDerrickKimAssgt
{
    public partial class GameScreen : Form
    {
        Game currentGame;
        public GameScreen(Game newGame)
        {
            InitializeComponent();
            this.currentGame = newGame;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
