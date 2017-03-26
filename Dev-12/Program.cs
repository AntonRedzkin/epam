using System;

namespace Dev_12
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                int idOfWantedSquare = 0;
                Checkers checker = new Checkers();
                Board board = new Board();
                ExceptionHandler exceptionHandler = new ExceptionHandler();
                InputerFromConsole inputer = new InputerFromConsole();
                bool key = true;
                while (key)
                {
                    try
                    {
                        inputer.TakeData(checker, out idOfWantedSquare);
                        key = false;
                    }
                    catch (FormatException exception)
                    {
                        exceptionHandler.HandleAndQuestion(exception, out key);
                    }
                }
                Algorithm stepsCalculater = new Algorithm(ref board);
                try
                {
                    stepsCalculater.FindNumberOfSteps(checker, idOfWantedSquare);
                    Console.WriteLine("Number Of Steps: {0}", stepsCalculater.NumberOfSteps);
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine("{0}", exception.Message);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("{0}", exception.Message);
            }
        }
    }
}
