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
        Random cpuController;
        Groan menuRef;
        int difficulty;
        private Graphics graPaper;
        private SolidBrush brshBlack = new SolidBrush(Color.Black);
        private SolidBrush brshYellow = new SolidBrush(Color.Yellow);
        public GameScreen(Game newGame, Groan menuRef)
        {
            InitializeComponent();
            cpuController = new Random();
            this.menuRef = menuRef;
            graPaper = dicePictureBox.CreateGraphics();
            this.currentGame = newGame;
            currentGame.initDie(graPaper);
            difficulty = currentGame.getDifficulty();
            objectiveLabel.Text = "First Player to " + currentGame.getTotalScore() + " wins!";
            player1NameLabel.Text = currentGame.getPlayerOneName();
            player2NameLabel.Text = currentGame.getPlayerTwoName();
          
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            updateStats();
            if (!currentGame.getIsLeftTurn()) {
                cpuTurn();
            }
        }

        private void updateStats() {
            player1CumulativeScore.Text = "Cumulative Score:" + currentGame.getPlayerOneCumulativeScore().ToString();
            player2CumulativeScore.Text = "Cumulative Score:" + currentGame.getPlayerTwoCumulativeScore().ToString();
            player1RunningScore.Text = "Running Score:" + currentGame.getPlayerOneRunningScore().ToString();
            player2RunninglScore.Text = "Running Score:" + currentGame.getPlayerTwoRunningScore().ToString();
            Application.DoEvents();
            if (currentGame.getIsLeftTurn())
            {
                rollDiceButton.Visible = true;
                passButton.Visible = true;
                playerTurnLabel.Text = "It is " + player1NameLabel.Text + "'s turn";


            }
            else {
                playerTurnLabel.Text = "It is " + player2NameLabel.Text + "'s turn";
                cpuTurn();
            }
        }

        private void updateCPUStats() {
            player1CumulativeScore.Text = "Cumulative Score:" + currentGame.getPlayerOneCumulativeScore().ToString();
            player2CumulativeScore.Text = "Cumulative Score:" + currentGame.getPlayerTwoCumulativeScore().ToString();
            player1RunningScore.Text = "Running Score:" + currentGame.getPlayerOneRunningScore().ToString();
            player2RunninglScore.Text = "Running Score:" + currentGame.getPlayerTwoRunningScore().ToString();
            Application.DoEvents();
            if (currentGame.getIsLeftTurn())
            {
                rollDiceButton.Visible = true;
                passButton.Visible = true;
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
            currentGame.getDie().drawDie(30, 30, 110, dieOneRoll);
            currentGame.getDie().drawDie(180, 30, 110, dieTwoRoll);
            currentGame.newTurn(dieOneRoll, dieTwoRoll, TurnLabel);
            updateStats();
            
        }
        private void rollDice_CPU() {
            int dieOneRoll = currentGame.getDie().diceRoll();
            int dieTwoRoll = currentGame.getDie().diceRoll();
            currentGame.getDie().drawDie(30, 30, 110, dieOneRoll);
            currentGame.getDie().drawDie(180, 30, 110, dieTwoRoll);
            currentGame.newTurn(dieOneRoll, dieTwoRoll, TurnLabel);
            updateCPUStats();
            Application.DoEvents();
            
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

        private void cpuTurn() {
            if (currentGame.cpuGame) {
                if (!currentGame.getIsLeftTurn()) {
                    rollDiceButton.Visible = false;
                    passButton.Visible = false;
                    System.Threading.Thread.Sleep(2000);
                    switch (difficulty) {
                        case 0:easyCPU();  break;
                        case 1:normalCPU();  break;
                        case 2:hardCPU(); break;
                            
           
                    }
                    
          
                }


            }
        }

        /*
            The strategies for the different CPU difficulties.
            Easy CPU will just keep rolling and never pass the die leaving it vulnerable to losing its score
            On low scoring games it has a good chance of just winning outright 

            Normal CPU will roll once and pass if it does not roll a one.
            */
        private void easyCPU() {
            rollDice_CPU();
        }

        private void normalCPU() {
            rollDice_CPU();
            if (!currentGame.getIsLeftTurn()) {
                MessageBox.Show("U AM GFETTING HERE");
                System.Threading.Thread.Sleep(2000);
                currentGame.passTurn();
                updateCPUStats();
            }
        }

        private void hardCPU() {
   
            // Will always roll at least once
            rollDice_CPU();
            System.Threading.Thread.Sleep(2000);
            if (!currentGame.getIsLeftTurn())
            {
                if (currentGame.getPlayerTwoRunningScore() > 25) {
                    currentGame.passTurn();
                    updateCPUStats();
                }
                else if
                //If the AI lead is only 20 it will play more conservatively
                (currentGame.getPlayerTwoCumulativeScore()>currentGame.getPlayerOneRunningScore() &&
                    currentGame.getPlayerTwoCumulativeScore()-currentGame.getPlayerOneRunningScore()<=20)
                {
                    currentGame.passTurn();
                    updateCPUStats();
                }
                else
                //if the lead is greater than 20 or the CPU is behind it will keep rolling
                {
                    hardCPU(); 
                }
                
            }
            updateStats();
        }
    }
}
