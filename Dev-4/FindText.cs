using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_4
{
    class FindText
    {
        public void FindPairOfLetters(List<String> DevText, char letter1, char letter2)
        {
            int count = 0;
            double countOfAllText = 0;

            foreach (string item in DevText)
            {
                StringBuilder sb = new StringBuilder();
                countOfAllText += item.Length;
                for (int i = 0; i < item.Length; i++)
                {
                    char pa = item[i];
                    if (pa == ' ' || pa == '_')
                    {
                        sb.Append(string.Empty);
                    }
                    else if (char.IsLetter(item[i]))
                    {
                        sb.Append(item[i]);
                    }
                    else
                    {
                        sb.Append(".");
                    }
                }
                string[] tex = sb.ToString().ToLower().Split('.');
                foreach (string other in tex)
                {
                    for (int i = 0; i < other.Length - 1; i++)
                    {
                        if (other[i] == letter1 && other[i + 1] == letter2)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine("The frequency of occurrence of pairs of letters:{0}{1}, is :{2} ", letter1, letter2, count / countOfAllText);
        }
    }
}
