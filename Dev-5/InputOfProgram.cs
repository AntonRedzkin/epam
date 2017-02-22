using System;

namespace Dev_5
{
    class InputOfProgram
    {
        public int MonetarySum()
        {
            Console.WriteLine("Input monetary amount: ");
            return int.Parse(Console.ReadLine());
        }
        public int RequirProductivity()
        {
            Console.WriteLine("Input the required productivity: ");
            return int.Parse(Console.ReadLine());
        }
        public int SelectCriteria()
        {
            Console.WriteLine("Input selection criteria: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
