using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Dev_12
{
    /// <summary>
    /// Takes on the input color, current and desired coordinates 
    /// of the checker on the field (given by the value of type a1, a1 .... h8)
    /// </summary>
    public class InputerFromConsole
    {
        public const int BLACK = 1;
        public const int WHITE = 0;
        public const int DEMENSION = 8;
        private const int NUM_FOR_TRANSLATE_LETTER_IN_NUMBER = 96;

        /// <summary>
        /// Assign values of Color and Positions to Checkers checker,
        /// and output id of wanted position(square).
        /// </summary>
        /// <param name="checker"></param>
        /// <param name="idOfWantedSquare"></param>
        public void TakeData(Checkers checker, out int idOfWantedSquare)
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

        /// <summary>
        /// Turn colostring to int, and verify it. 
        /// </summary>
        /// <param name="colorString"></param>
        /// <returns></returns>
        public int ParseColor(string colorString)
        {
            int color = -1;
            colorString = colorString.ToLower();
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

        /// <summary>
        /// Turn inputed position to int[], and verify it.
        /// </summary>
        /// <param name="input">inputed position</param>
        /// <returns></returns>
        public int[] ParsePosition(string input)
        {
            input = input.ToLower();
            int[] position = new int[2];
            string coordinatePattern = @"^\s*[abcdefgh]\s*[12345678]\s*$";
            if (Regex.IsMatch(input, coordinatePattern))
            {
                input = input.Trim();
                if ((input.First() - NUM_FOR_TRANSLATE_LETTER_IN_NUMBER) % 2 == input.Last() % 2)
                {
                    position[0] = input.First() - NUM_FOR_TRANSLATE_LETTER_IN_NUMBER;
                    position[1] = input.Last() - (NUM_FOR_TRANSLATE_LETTER_IN_NUMBER / 2);
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
