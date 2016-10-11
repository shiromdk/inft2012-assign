using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanNguyenDerrickKimAssgt.Classes
{
    //This class will represent the a single game. Each game will be associated with a gamescreen form
    public class Game
    {
        private bool cpuGame;                                       // True if cpu game
        private int totalScore;                                     // The total score the game will run two  
        private int difficulty;                                     // CPU Difficulty - 0 = easy 1 = normal 2 = hard
        private List<Turn> turns;                                   // contains a history of all the turns played in current game
        private bool leftTurn;                                      // determines if player 1 or 2 turn

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
            this.cpuGame = true;
            this.totalScore = totalScore;
            this.difficulty = difficulty;
            this.playerOneName = playername;
            this.playerTwoName = "CPU";
            this.die = new Die();
            this.leftTurn = true;
            this.runningScoreOne = 0;
            this.cumulativeScoreOne = 0;
            this.runningScoreTwo = 0;
            this.cumulativeScoreTwo = 0;
        }

       

        //Constructor for the single player game
        public Game(string playerOne, string playerTwo, int totalScore) {

        }

        public void newTurn() {

        }
    }
}
