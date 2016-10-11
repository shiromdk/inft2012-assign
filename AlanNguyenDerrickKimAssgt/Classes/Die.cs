using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanNguyenDerrickKimAssgt.Classes
{
   //This class represents the die that is used in the game
    public class Die
    {
        private Random ran;
        
        public Die() {
            this.ran = new Random();
        }

        //Returns a random number from 1 to 6
        public int diceRoll() {
            return ran.Next(1,7);
        }
    }
}
