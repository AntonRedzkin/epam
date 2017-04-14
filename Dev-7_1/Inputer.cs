using System;

namespace Dev_7_1
{
    class Inputer
    {
        public string TimeDate(string format)
        {
            Console.WriteLine("input Time and Date in this format:{0}", format);
            string inputedTimeDate = Console.ReadLine();

            return inputedTimeDate;
        }
    }
}
