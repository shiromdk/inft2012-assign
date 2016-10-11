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
    public partial class Groan : Form
    {
    
       

        public Groan()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            GameSetup newGame = new GameSetup(this);
            newGame.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //This closes the game.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
