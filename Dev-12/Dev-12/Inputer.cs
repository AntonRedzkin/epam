using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dev_12
{
    class Inputer
    {
        public const int BLACK = 1;
        public const int WHITE = 0;
        private string startData;

        public void ReadData(Checkers ch1, Checkers ch2)
        {
            Console.WriteLine("Input color (w, b): ");
            ch1.Color = ParseColor(Console.ReadLine().ToLower());
            Console.WriteLine("Input startPosition (a1 - h8): ");
            ch1.CurrentPosition = ParsePosition(Console.ReadLine().ToLower());
            ch1.positionX = ch1.CurrentPosition.First();
            ch1.positionY = ch1.CurrentPosition.Last();
            ch2 = ch1;
            Console.WriteLine("Input endPosition (a1 - h8): ");
            ch2.CurrentPosition = ParsePosition(Console.ReadLine().ToLower());
        }

        public int ParseColor(string colorString)
        {
            int color = -1;
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
                {
                    Console.WriteLine("Error. Invalid format. Do you want to input color? (y, n)");
                    if (Console.ReadLine() == "n")
                    {
                        break;
                    }
                }
            }
            return color;
        }

        public int[] ParsePosition(string input)
        {
            int[] Position = new int[2];
            string coordinatePattern = @"^\s*[abcdefgh]\s*[12345678]\s*$";
            if (Regex.IsMatch(input, coordinatePattern))
            {
                input = input.Trim();
                if ((input.First() - 96) % 2 == input.Last() % 2)
                {
                    Position[0] = input.First() - 96;
                    Position[1] = input.Last() - 48;
                    return Position;
                }                    
                else
                    throw new FormatException("Only black fields are allowed");
            }
            else
                throw new FormatException("Wrong format of coordinate");
        }

    }
}
