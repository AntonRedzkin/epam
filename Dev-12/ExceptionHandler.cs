using System;

namespace Dev_12
{
    public class ExceptionHandler
    {
        /// <summary>
        /// Write on console exception's message,
        /// ask user try again. 
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="key"></param>
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
