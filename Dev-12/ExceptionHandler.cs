using System;

namespace Dev_12
{
    public class ExceptionHandler
    {
        public void HandleAndQuestion(Exception exception, out bool key)
        {
            Console.WriteLine("{0}", exception.Message);
            Console.WriteLine("Try again?(y/n)");
            string ansver = Console.ReadLine().ToLower();
            if (ansver.Equals("y"))
            {
                key = true;
            }
            else
            {
                key = false;
            }            
        }
    }
}
