using System;

namespace Dev_12
{
    public class StepsCalculater
    {
        private static String WRONG_POSITION_MSG = "Position is unreachable.";
        public const int BLACK = 1;
        public const int WHITE = 0;

        public int Move(Checkers checker, Board board, Square wantedSquare)
        {
            if (!isValid(checker, wantedSquare))
            {
                throw new ArgumentException(WRONG_POSITION_MSG);
            }
            return go(checker, board, wantedSquare);
        }

        private bool isValid(Checkers checker, Square wantedSquare)
        {
            bool isValid = true;
            if (wantedSquare.Color == WHITE)
            {
                isValid = false;
            }
            if (checker.Color==WHITE)
            {
                if ((checker.PositionX - checker.PositionY < wantedSquare.PositionX - wantedSquare.PositionY) ||
                    (checker.PositionX + checker.PositionY > wantedSquare.PositionX + wantedSquare.PositionY))
                {
                    isValid = false;
                }
            }
            else
            {
                if ((checker.PositionX - checker.PositionY > wantedSquare.PositionX - wantedSquare.PositionY) ||
                    (checker.PositionX + checker.PositionY < wantedSquare.PositionX + wantedSquare.PositionY))
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        private int go(Checkers checker, Board board, Square wantedSquare)
        {
            int steps = 0;
            while (!areSame(checker, wantedSquare))
            {
                if (checker.PositionX < wantedSquare.PositionX)
                {
                    checker.goRight();
                    steps++;
                }
                else if(checker.PositionX > wantedSquare.PositionX)
                {
                    checker.goLeft();
                    steps++;
                }
                else
                {
                    if (checker.PositionX < board.GetDEMENSION())
                    {
                        checker.goRight();
                    }
                    else
                    {
                        checker.goLeft();
                    }
                    steps++;
                }
            }          
            return steps;
        }

        public bool areSame(Checkers checker, Square wantedSquare)
        {
            return ((checker.PositionY == wantedSquare.PositionY) && (checker.PositionX == wantedSquare.PositionX));
        }
    }
}
