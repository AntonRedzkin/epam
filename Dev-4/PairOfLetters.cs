using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_4
{
    class PairOfLetters
    {
        public void CreatePairOfLetters(out char l1, out char l2)
        {
            string pair;
            l1 = 'a';
            l2 = 'a';
            Console.WriteLine("Enter Pair Of Letters: ");
            pair = Console.ReadLine();
            l1 = pair[0];
            l2 = pair[1];
        }
    }
}
