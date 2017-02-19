using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> NewAllText = new List<String>();
            List<String> DevText = new List<String>();
            PairOfLetters pairOfLetter = new PairOfLetters();
            AddText addText = new AddText();
            WordsCounter wc = new WordsCounter();
            FindText ft = new FindText();

            int selection = -1;
            char letter1;
            char letter2;

            while (selection != 0)
            {
                Console.WriteLine("\n 1 - Add Text \n" +
                    " 2 - WordCounter \n 3 - Print PairOfLetters \n 0 - Exit \n");
                try
                {
                    selection = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("InCorrect case");
                    continue;
                }
                switch (selection)
                {
                    case 1:
                        {
                            addText.AddNewText(NewAllText, DevText);
                            break;
                        }
                    case 2:
                        {
                            foreach (string item in NewAllText)
                            {
                                Console.WriteLine("Text: " + item);
                            }
                            wc.WordCounter(NewAllText);
                            break;
                        }
                    case 3:
                        {
                            foreach (string item in NewAllText)
                            {
                                Console.WriteLine("Text: " + item);
                            }
                            pairOfLetter.CreatePairOfLetters(out letter1, out letter2);
                            ft.FindPairOfLetters(DevText, letter1, letter2);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
