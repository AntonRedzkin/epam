using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_12
{
    class StepsCalculater
    {
        private static String WRONG_POSITION_MSG = "WRONG position ";
        public const int BLACK = 1;
        public const int WHITE = 0;

        public void Count(Checkers newChecker, Board newBoard)
        {
            int ICurrentPosition = newChecker.CurrentPosition.First();
            int JCurrentPosition = newChecker.CurrentPosition.Last();
            int IWantedPosition = newChecker.WantedPosition.First();
            int JWantedPosition = newChecker.WantedPosition.Last();

            newBoard.square[ICurrentPosition, JCurrentPosition].State = 1;

        }

        public int Move(Checkers ch1, Checkers ch2)
        {

            if (!isValid(ch1, ch2))
            {
                throw new ArgumentException(WRONG_POSITION_MSG);
            }

            if (ch1.Color == WHITE)
            {
                return goWhite(ch1, ch2);
            }
            else
            {
                return goBlack(ch1, ch2);
            }
        }

        private bool isValid(Checkers ch1, Checkers ch2)
        {
            bool isValid = true;

            if (!(ch1.Color == ch2.Color))
            {
                isValid = false;
            }

            if (ch1.Color==WHITE)
            {
                if ((ch1.positionX - ch1.positionY < ch2.positionX - ch2.positionY) ||
                    (ch1.positionX + ch1.positionY > ch2.positionX + ch2.positionY))
                {
                    isValid = false;
                }
            }
            else
            {
                if ((ch1.positionX - ch1.positionY > ch2.positionX - ch2.positionY) ||
                    (ch1.positionX + ch1.positionY < ch2.positionX + ch2.positionY))
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        private int goWhite(Checkers ch1, Checkers ch2)
        {
            int steps = 0;

            if (ch1.positionX < ch2.positionX)
            {
                while (!ch1.areSame(ch2))
                {
                    while (ch1.positionX + ch1.positionY != ch2.positionX + ch2.positionY)
                    {
                        ch1.goRight();
                        steps++;
                    }
                    ch1.goLeft();
                    steps++;
                }
            }
            else
            {
                while (!ch1.areSame(ch2))
                {
                    while (ch1.positionX - ch1.positionY != ch2.positionX - ch2.positionY)
                    {
                        ch1.goLeft();
                        steps++;
                    }
                    ch1.goRight();
                    steps++;
                }
            }
            return steps;
        }

        private int goBlack(Checkers ch1, Checkers ch2)
        {
            int steps = 0;

            if (ch1.positionX < ch2.positionX)
            {
                while (!ch1.areSame(ch2))
                {
                    while (ch1.positionX - ch1.positionY != ch2.positionX - ch2.positionY)
                    {
                        ch1.goRight();
                        steps++;
                    }
                    ch1.goLeft();
                    steps++;
                }
            }
            else
            {
                while (!ch1.areSame(ch2))
                {
                    while (ch1.positionX + ch1.positionY != ch2.positionX + ch2.positionY)
                    {
                        ch1.goLeft();
                        steps++;
                    }
                    ch1.goRight();
                    steps++;
                }
            }
            return steps;
        }
    }
}
