
namespace Dev_12
{
    /// <summary>
    /// Contains demnsion of board,
    /// posible states and colors for squares on board.
    /// </summary>
    public class Board
    {
        public const int BLACK = 1;
        public const int WHITE = 0;
        public const int DEMENSION = 8;
        public Square[,] arrayOfSquare { get; private set; }
        public enum States { Empty, WhiteFig, BlackFig };

        /// <summary>
        ///  Creates and fills arrayOfSquare with size = DEMENSION  
        /// </summary>
        public Board()
        {
            arrayOfSquare = new Square[DEMENSION, DEMENSION];
            for (int i = 0; i < DEMENSION; i++)
            {
                for (int j = 0; j < DEMENSION; j++)
                {
                    this.arrayOfSquare[i, j] = new Square();
                    if ((i + j) % 2 == 0)
                    {
                        this.arrayOfSquare[i, j].Color = BLACK;
                    }
                    else
                    {
                        this.arrayOfSquare[i, j].Color = WHITE;
                    }
                    this.arrayOfSquare[i, j].PositionY = i + 1;
                    this.arrayOfSquare[i, j].PositionX = j + 1;
                    this.arrayOfSquare[i, j].State = (int)States.Empty;
                    this.arrayOfSquare[i, j].Id = i * DEMENSION + j + 1;
                }
            }
        }

        /// <summary>
        /// Selects on Board squar with Id = index. And returns it.
        /// </summary>
        public Square Select(int index)
        {
            int i = 0, j = 0;
            foreach (Square square in arrayOfSquare)
            {
                if(square.Id == index)
                {
                    i = square.PositionY - 1;
                    j = square.PositionX - 1;
                }
            }
            return arrayOfSquare[i, j];
        }

        public int GetDEMENSION()
        {
            return DEMENSION;
        }
    }
}
