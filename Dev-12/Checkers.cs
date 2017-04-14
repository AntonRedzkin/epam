
namespace Dev_12
{
    public class Checkers
    {
        public const int WHITE = 0;
        public int Color { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        /// Moves forward and left. Depends on checker's color.
        public void goLeft()
        {
            PositionX--;

            if (Color == WHITE)
            {
                PositionY++;
            }
            else
            {
                PositionY--;
            }
        }

        /// Moves forward and right. Depends on checker's color.
        public void goRight()
        {
            PositionX++;

            if (Color == WHITE)
            {
                PositionY++;
            }
            else
            {
                PositionY--;
            }
        }
    }
}
