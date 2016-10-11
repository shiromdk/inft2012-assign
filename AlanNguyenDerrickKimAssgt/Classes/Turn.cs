using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanNguyenDerrickKimAssgt.Classes
{
    public class Turn
    {
        string playerName;
        bool turnLeft;
        int dieOneResult;
        int dieTwoResult;
        
        public Turn(string playerName, bool turnLeft, int dieOneResult,int dieTwoResult) {

            this.playerName = playerName;
            this.turnLeft = turnLeft;
            this.dieOneResult = dieOneResult;
            this.dieTwoResult = dieTwoResult;
        }

    }
}
