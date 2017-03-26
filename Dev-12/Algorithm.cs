using System;

namespace Dev_12
{
    /// <summary>
    /// Contain algorithms for calculating necessary number of steps
    /// for reaching wanted position of checkerboard.
    /// </summary>
    public class Algorithm
    {
        private const string UNREACHABLE_POSITION_MSG = "Position is unreachable.";
        public const int BLACK = 1;
        public const int WHITE = 0;
        public int NumberOfSteps { get; set; }
        Board CheckerBoard { get; set; }
        Square WantedSquare { get; set; }

        public Algorithm(ref Board board)
        { this.CheckerBoard = board; }

        public void FindNumberOfSteps(Checkers checker, int idOfWantedSquare)
        {
            this.WantedSquare = CheckerBoard.Select(idOfWantedSquare);
            if (!IsPositionReachable(checker))
            {
                throw new ArgumentException(UNREACHABLE_POSITION_MSG);
            }
            NumberOfSteps = GoToWantedSquare(checker);
        }

        private bool IsPositionReachable(Checkers checker)
        {
            bool isReachable = true;
            if (WantedSquare.Color == WHITE)
            {
                isReachable = false;
            }
            if (checker.Color==WHITE)
            {
                if ((checker.PositionX - checker.PositionY < WantedSquare.PositionX - WantedSquare.PositionY) ||
                    (checker.PositionX + checker.PositionY > WantedSquare.PositionX + WantedSquare.PositionY))
                {
                    isReachable = false;
                }
            }
            else
            {
                if ((checker.PositionX - checker.PositionY > WantedSquare.PositionX - WantedSquare.PositionY) ||
                    (checker.PositionX + checker.PositionY < WantedSquare.PositionX + WantedSquare.PositionY))
                {
                    isReachable = false;
                }
            }
            return isReachable;
        }

        private int GoToWantedSquare(Checkers checker)
        {
            int steps = 0;
            while (!AreSame(checker))
            {
                if (checker.PositionX < WantedSquare.PositionX)
                {
                    checker.goRight();
                }
                else if(checker.PositionX > WantedSquare.PositionX)
                {
                    checker.goLeft();
                }
                else
                {
                    if (checker.PositionX < CheckerBoard.GetDEMENSION())
                    {
                        checker.goRight();
                    }
                    else
                    {
                        checker.goLeft();
                    }
                }
                steps++;
            }          
            return steps;
        }

        public bool AreSame(Checkers checker)
        {
            return ((checker.PositionY == WantedSquare.PositionY) && (checker.PositionX == WantedSquare.PositionX));
        }
    }
}
