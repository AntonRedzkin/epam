using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Dev_12
{
    public class Inputer
    {
        public const int BLACK = 1;
        public const int WHITE = 0;
        public const int DEMENSION = 8;

        public void GetData(Checkers checker, out int idOfWantedSquare)
        {
            Console.WriteLine("Input color (w, b): ");
            checker.Color = ParseColor(Console.ReadLine());
            Console.WriteLine("Input startPosition (a1 - h8): ");
            int[] position = ParsePosition(Console.ReadLine());
            checker.PositionX = position.First();
            checker.PositionY = position.Last();
            Console.WriteLine("Input endPosition (a1 - h8): ");
            position = ParsePosition(Console.ReadLine().ToLower());
            idOfWantedSquare = position.First() + (position.Last() - 1) * DEMENSION;
        }

        public int ParseColor(string colorString)
        {
            int color = -1;
            colorString.ToLower();
            while (color < 0) 
            {                
                if (colorString == "b" || colorString == "black")
                {
                    color = BLACK;
                }
                else if (colorString == "w" || colorString == "white")
                {
                    color = WHITE;
                }
                else
                    throw new FormatException("Invalid format or color.");                
            }
            return color;
        }

        public int[] ParsePosition(string input)
        {
            input.ToLower();
            int[] position = new int[2];
            string coordinatePattern = @"^\s*[abcdefgh]\s*[12345678]\s*$";
            if (Regex.IsMatch(input, coordinatePattern))
            {
                input = input.Trim();
                if ((input.First() - 96) % 2 == input.Last() % 2)
                {
                    position[0] = input.First() - 96;
                    position[1] = input.Last() - 48;
                    return position;
                }                    
                else
                    throw new FormatException("Positions is unacceptable. Only black fields are allowed.");
            }
            else
                throw new FormatException("Wrong format of coordinate.");
        }
    }
}
