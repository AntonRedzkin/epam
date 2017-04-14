using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_12
{
    class Checkers
    {
        public const int WHITE = 0;
        public int Color { get; set; }
        public int[] CurrentPosition { get; set; }
        public int[] WantedPosition { get; set; }
        public int positionX { get; set; }
        public int positionY { get; set; }

        /// Moves forward and left. Depends on checker's color.
        public void goLeft()
        {
            positionX--;

            if (Color == WHITE)
            {
                positionY++;
            }
            else
            {
                positionY--;
            }
        }

        /// Moves forward and right. Depends on checker's color.
        public void goRight()
        {
            positionX++;

            if (Color == WHITE)
            {
                positionY++;
            }
            else
            {
                positionY--;
            }
        }

        public bool areSame(Checkers checkers)
        {
            return this.positionY == checkers.positionY && this.positionX == checkers.positionX;
        }
    }
}
