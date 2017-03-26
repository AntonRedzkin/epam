
namespace Dev_12
{
    /// <summary>
    /// Contains information about color, current position of checker.
    /// Also contain posible actions.
    /// </summary>
    public class Checkers
    {
        public const int WHITE = 0;
        public int Color { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        /// <summary>
        /// Moves forward and left. Depends on checker's color.
        /// </summary>
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
        
        /// <summary>
        /// Moves forward and right. Depends on checker's color.
        /// </summary>
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
