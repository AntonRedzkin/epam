using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_4
{
    class WordsCounter
    {
        public void WordCounter(List<String> NewText)
        {
            int wordsCount = 0;
            foreach (string item in NewText)
            {
                string[] words = item.Split(',', '.', '_', ' ');
                for (int i = 0; i < words.Length; i++)
                    if (words[i].Length > 5)
                        wordsCount++;
                Console.WriteLine("Number of words longer than 5 letters: " + wordsCount.ToString());
            }
        }
    }
}
