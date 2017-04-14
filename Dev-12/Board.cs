
namespace Dev_12
{
    public class Board
    {
        public const int BLACK = 1;
        public const int WHITE = 0;
        public const int EMPTY = 0;
        public const int DEMENSION = 8;
        public Square[,] arrayOfSquare = new Square[DEMENSION, DEMENSION];

        public int GetDEMENSION()
        {
            return DEMENSION;
        }

        public Board()
        {
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
                    this.arrayOfSquare[i, j].State = EMPTY;
                    this.arrayOfSquare[i, j].Id = i * DEMENSION + j + 1;
                }
            }
        }

        public Square Select(int Index)
        {
            int i = 0, j = 0;
            foreach (Square square in arrayOfSquare)
            {
                if(square.Id == Index)
                {
                    i = square.PositionY - 1;
                    j = square.PositionX - 1;
                }
            }
            return arrayOfSquare[i, j];
        }
    }
}
