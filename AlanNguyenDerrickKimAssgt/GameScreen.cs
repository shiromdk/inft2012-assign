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
        Groan menuRef;
        private Graphics graPaper;
        private SolidBrush brshBlack = new SolidBrush(Color.Black);
        private SolidBrush brshYellow = new SolidBrush(Color.Yellow);
        public GameScreen(Game newGame, Groan menuRef)
        {
            InitializeComponent();
            this.menuRef = menuRef;
            graPaper = dicePictureBox.CreateGraphics();
            this.currentGame = newGame;
            currentGame.initDie(graPaper);
            objectiveLabel.Text = "First Player to "+currentGame.getTotalScore()+" wins!";
            player1NameLabel.Text = currentGame.getPlayerOneName();
            player2NameLabel.Text = currentGame.getPlayerTwoName();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            updateStats();
        }

        private void updateStats() {
            player1CumulativeScore.Text ="Cumulative Score:"+currentGame.getPlayerOneCumulativeScore().ToString();
            player2CumulativeScore.Text = "Cumulative Score:" + currentGame.getPlayerTwoCumulativeScore().ToString(); 
            player1RunningScore.Text = "Running Score:" + currentGame.getPlayerOneRunningScore().ToString();
            player2RunninglScore.Text = "Running Score:" + currentGame.getPlayerTwoRunningScore().ToString();
            if (currentGame.getIsLeftTurn())
            {
                playerTurnLabel.Text = "It is " + player1NameLabel.Text + "'s turn";
            }
            else {
                playerTurnLabel.Text = "It is " + player2NameLabel.Text + "'s turn";
            }
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            int dieOneRoll = currentGame.getDie().diceRoll();
            int dieTwoRoll = currentGame.getDie().diceRoll();
            currentGame.getDie().drawDie(30, 30, 110,dieOneRoll);
            currentGame.getDie().drawDie(180, 30, 110, dieTwoRoll);
            currentGame.newTurn(dieOneRoll,dieTwoRoll,TurnLabel);
            updateStats();
        }

        private void turnHistoryButton_Click(object sender, EventArgs e)
        {

        }

        private void passButton_Click(object sender, EventArgs e)
        {
            currentGame.passTurn();
            updateStats();
        }

        private void exitGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
            menuRef.Show();
        }
    }
}
