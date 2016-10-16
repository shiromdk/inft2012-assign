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
    public partial class GameSetup : Form
    {

        List<string> difficultyString = new List<string>();
        Groan menuRef;                       //References the main menu
        public GameSetup(Groan menuForm)
        {
            this.menuRef = menuForm;
            InitializeComponent();
        
            
        }

        private void GameSetup_Load(object sender, EventArgs e)
        {
            
        }

        private void vsPlayerbutton_Click(object sender, EventArgs e)
        {
            vsCpuPanel.Visible = false;
            twoPlayerPanel.Visible=true;
            gameSetupPanel.Visible = false;
        }

        private void vsCpuButton_Click(object sender, EventArgs e)
        {
            twoPlayerPanel.Visible = false; 
            vsCpuPanel.Visible = true;
            gameSetupPanel.Visible = false;
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void vsCpuBack_Click(object sender, EventArgs e)
        {
            gameSetupPanel.Visible = true;
            vsCpuPanel.Visible = false;
            playerNameTextBox.Text = "";
            cpuGameScore.Value = 0;

        }

        private void startCpuGame_Click(object sender, EventArgs e)
        {
            int difficulty = 0;                     //An Integer which represents the difficulty - -1 2 Player Game 0 Easy .....
            if (easy.Checked) {
                difficulty = 0;
            }
            if (normal.Checked)
            {
                difficulty = 0;
            }
            if (hard.Checked)
            {
                difficulty = 0;
            }
            if (playerNameTextBox.Text.Equals("") || cpuGameScore.Value==0){
                MessageBox.Show("Please enter the player name and total game score");
            }else {
                string playerName = playerNameTextBox.Text;
                int totalScore = (int)cpuGameScore.Value;
                Game newGame = new Game(playerName,totalScore,difficulty);
                GameScreen newGameScreen = new GameScreen(newGame, menuRef);
                newGameScreen.Show();
                this.Hide();
                
            }

        }

        private void backButton2p_Click(object sender, EventArgs e)
        {
            twoPlayerPanel.Visible = false;
            p1Name.Text = "";
            p2Name.Text = "";
            totalValue2p.Value = 0;
            gameSetupPanel.Visible = true;

        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            menuRef.Visible = true;
            this.Visible = false;
        }

        private void twoPlayerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void start2p_Click(object sender, EventArgs e)
        {
            if (totalValue2p.Value == 0 || p1Name.Text.Equals("") || p2Name.Text.Equals("")){
                MessageBox.Show("Please enter the player names and total game score");
            }
            else {
                string player1Name = p1Name.Text;
                string player2Name = p2Name.Text; 
                int totalScore = (int)totalValue2p.Value;
                Game newGame = new Game(player1Name,player2Name, totalScore);
                GameScreen newGameScreen = new GameScreen(newGame,menuRef);
                newGameScreen.Show();
                this.Hide();
            }
        }
    }
}
