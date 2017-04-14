using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Checkers ch1 = new Checkers();
            Checkers ch2 = new Checkers();
            Inputer newInputer = new Inputer();
            newInputer.ReadData(ch1, ch2);
            Board newBoard = new Board();
            StepsCalculater stepsCalculater = new StepsCalculater();
            int Step = stepsCalculater.Move(ch1, ch2);
            Console.WriteLine("Steps: ", Step);
        }
    }
}
