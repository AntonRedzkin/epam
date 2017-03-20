using System;

namespace Dev_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int idOfWantedSquare = 0;
            Checkers checker = new Checkers();
            Inputer inputer = new Inputer();
            Board board = new Board();
            ExceptionHandler exceptionHandler = new ExceptionHandler();
            bool key = true;
            while (key)
            {
                try
                {
                    inputer.GetData(checker, out idOfWantedSquare);
                    key = false;
                }
                catch (FormatException exception)
                {
                    exceptionHandler.HandleAndQuestion(exception, out key);
                }
            }
            StepsCalculater stepsCalculater = new StepsCalculater();
            try
            {                
                int step = stepsCalculater.Move(checker, board, board.Select(idOfWantedSquare));
                Console.WriteLine("Steps: {0}", step);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine("{0}", exception.Message);
            }
        }
    }
}
