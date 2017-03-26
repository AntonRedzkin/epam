
namespace Dev_12
{
    /// <summary>
    /// Contains information about color, state, 
    /// id, and position of this square on board.
    /// </summary>
    public class Square
    {
        public int Color { get; set; }
        public int State { get; set; }
        public int Id { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
    }
}
