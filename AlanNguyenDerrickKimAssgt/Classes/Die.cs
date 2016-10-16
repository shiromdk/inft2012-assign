using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanNguyenDerrickKimAssgt.Classes
{
   //This class represents the die that is used in the game
    public class Die
    {
        private Random ran;
        private Graphics graPaper;
        private SolidBrush brshBlack = new SolidBrush(Color.Black);
        private SolidBrush brshYellow = new SolidBrush(Color.Yellow);
        public Die(Graphics graphicsPaper) {
            this.ran = new Random();
            this.graPaper = graphicsPaper;
        }

        //Returns a random number from 1 to 6
        public int diceRoll() {
            return ran.Next(1,7);
            
            // second dice x must be 180 y must be 30.                       
        
        }
        public void drawDie(int iLeft, int iTop, int iSize, int iDiceNum)
        {
            graPaper.FillRectangle(brshBlack, iLeft, iTop, iSize, iSize);
            switch (iDiceNum)
            {
                case 1:
                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 3 + 5,
                    iTop + iSize / 3 + 5, iSize / 4, iSize / 4);
                    break;
                case 2:
                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 5, iTop + iSize / 3 + 5,
                        iSize / 4, iSize / 4);

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 2 + 5, iTop + iSize / 3 + 5,
                        iSize / 4, iSize / 4);
                    break;
                case 3:
                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 12, iTop + iSize / 3 + 5,
                        iSize / 4, iSize / 4);

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 3 + 5,
                    iTop + iSize / 3 + 5, iSize / 4, iSize / 4); // this is centre

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 2 + 20, iTop + iSize / 3 + 5,
                        iSize / 4, iSize / 4);
                    break;

                case 4:
                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 7, iTop + iSize / 5,
                        iSize / 4, iSize / 4);

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 2 + 10, iTop + iSize / 5,
                        iSize / 4, iSize / 4);

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 7, iTop + iSize / 2 + 10,
                        iSize / 4, iSize / 4);

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 2 + 10, iTop + iSize / 2 + 10,
                        iSize / 4, iSize / 4);
                    break;

                case 5:
                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 3 + 5,
                    iTop + iSize / 3 + 5, iSize / 4, iSize / 4);

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 7, iTop + iSize / 5,
                        iSize / 4, iSize / 4);

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 2 + 10, iTop + iSize / 5,
                        iSize / 4, iSize / 4);

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 7, iTop + iSize / 2 + 10,
                        iSize / 4, iSize / 4);

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 2 + 10, iTop + iSize / 2 + 10,
                        iSize / 4, iSize / 4);
                    break;

                case 6:
                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 7, iTop + iSize / 10,
                       iSize / 4, iSize / 4);

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 7, iTop + iSize / 4 + 17,
                       iSize / 4, iSize / 4);

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 7, iTop + iSize / 2 + 20,
                       iSize / 4, iSize / 4);

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 2 + 13, iTop + iSize / 10,
                      iSize / 4, iSize / 4);

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 2 + 13, iTop + iSize / 4 + 17,
                       iSize / 4, iSize / 4);

                    graPaper.FillEllipse(brshYellow, iLeft + iSize / 2 + 13, iTop + iSize / 2 + 20,
                       iSize / 4, iSize / 4);
                    break;
            }
            // Display dice number as picture. 
            // width and hight must be 110 for cube.


        }


    }
}
