using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanNguyenDerrickKimAssgt.Classes
{
    //This class will represent the a single game. Each game will be associated with a gamescreen form
    public class Game
    {
        public bool cpuGame;                                       // True if cpu game
        private int totalScore;                                     // The total score the game will run two  
        private int difficulty;                                     // CPU Difficulty - 0 = easy 1 = normal 2 = hard
        private List<Turn> turns;                                   // contains a history of all the turns played in current game
        private bool leftTurn;                                      // determines if player 1 or 2 turn
        private bool gameEnd;
        private int currentTurn;
        private int previousTurn;
        private string currentPlayer;
        private string winner;
        private Die die;
        //Variables for Player One
        private string playerOneName;
        private int runningScoreOne;
        private int cumulativeScoreOne;

        //Variables for Player Two;
        private string playerTwoName;
        private int runningScoreTwo;
        private int cumulativeScoreTwo;




        //Constructor for the CPU Game
        public Game(string playername, int totalScore , int difficulty) {
            this.turns = new List<Turn>();
            this.currentTurn = 1;
            this.currentPlayer = playername;
            this.previousTurn = 0;
            this.cpuGame = true;
            this.totalScore = totalScore;
            this.difficulty = difficulty;
            this.playerOneName = playername;
            this.playerTwoName = "CPU";
            this.leftTurn = true;
            this.runningScoreOne = 0;
            this.cumulativeScoreOne = 0;
            this.runningScoreTwo = 0;
            this.cumulativeScoreTwo = 0;
            this.gameEnd = false;
        }

       

        //Constructor for the multiplayer game
        public Game(string playerOne, string playerTwo, int totalScore) {
            this.turns = new List<Turn>();
            this.currentTurn = 1;
            this.previousTurn = 0;
            this.currentPlayer = playerOne;
            this.cpuGame = false;
            this.totalScore = totalScore;
            this.difficulty = -1;
            this.playerOneName = playerOne;
            this.playerTwoName = playerTwo;
            this.leftTurn = true;
            this.runningScoreOne = 0;
            this.cumulativeScoreOne = 0;
            this.runningScoreTwo = 0;
            this.cumulativeScoreTwo = 0;
            this.gameEnd = false;
        }

        public void initDie(Graphics graPaper) {
            this.die = new Die(graPaper);
        }
        public void playTurn(int rollOne, int rollTwo) {
            if (rollOne == 1 || rollTwo == 1)
            {
                if (leftTurn)
                {
                    runningScoreOne = 0;
                    if (rollOne + rollTwo == 2)
                    {
                        cumulativeScoreOne = 0;
                    }

                    passTurn();
                }
                else
                {
                    if (rollOne + rollTwo == 2)
                    {
                        cumulativeScoreTwo = 0;
                    }
                    runningScoreTwo = 0;
                    passTurn();
                }
            }
            else {
                if (leftTurn) {
                    runningScoreOne += rollOne + rollTwo;
                } else {
                    runningScoreTwo += rollOne + rollTwo;
                }
            }
        }
        /*
        Starts a new turn
            */
       
        public void newTurn(int rollOne,int rollTwo, System.Windows.Forms.Label turnLabel) {
            if (!gameEnd) {
                playTurn(rollOne, rollTwo);
                turns.Add(new Turn(currentPlayer, leftTurn, rollOne, rollTwo));
                currentTurn++;
                previousTurn++;
                checkWin(turnLabel);
                
            }
            
        }
        /*
        This function will check if the game should be over and who the winner should be
            */

        private void checkWin(System.Windows.Forms.Label turnLabel) {
            if (leftTurn)
            {
                if (runningScoreOne + cumulativeScoreOne >= totalScore) {
                    gameEnd = true;
                    winner = playerOneName;
                }
            }
            else {
                if (runningScoreTwo + cumulativeScoreTwo >= totalScore)
                {
                    gameEnd = true;
                    winner = playerTwoName;
                }
            }
            if (!gameEnd)
            {
                turnLabel.Text = "It is currently turn " + currentTurn;
            }
            else {
                turnLabel.Text = winner+" has won the game";
            }
            
        }

        /*
            Toggles player and updates scores
            */
        public void passTurn() {
            if (leftTurn)
            {
                cumulativeScoreOne+=runningScoreOne;
                runningScoreOne = 0;
            }
            else {
                cumulativeScoreTwo += runningScoreTwo;
                runningScoreTwo = 0;
            }
            leftTurn = !leftTurn; //toggles player
        }







        /*
         * Getters and Setters
         *
         */
        public string getPlayerOneName() {
            return playerOneName;
        }

        public bool getIsLeftTurn() {
            return leftTurn;
        }
        public string getPlayerTwoName() {
            return playerTwoName;
        }
        public int getTotalScore() {
            return totalScore;
        }
        public int getPlayerOneRunningScore() {
            return runningScoreOne;
        }

        public int getPlayerTwoRunningScore() {
            return runningScoreTwo;
        }
        public int getPlayerOneCumulativeScore() {
            return cumulativeScoreOne;
        }
        public int getPlayerTwoCumulativeScore() {
            return cumulativeScoreTwo;
        }

        public int getDifficulty() {
            return difficulty;
        }

        public Die getDie() {
            return die;
        }
    }
}
