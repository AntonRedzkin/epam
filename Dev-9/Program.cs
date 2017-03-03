using System;
using System.IO;

namespace Dev_9
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader fileReader = new FileReader();
            string filesText = String.Empty;
            bool key = true;
            while (key)
            {
                try
                {
                    fileReader.FileText(out filesText);
                    key = false;
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("\nError File Not Found, try once again:\n");
                    key = true;
                }
            }
            int startIndexOfSection = 0;
            int countIndexOfSection = 0;
            Searcher searcher = new Searcher();
            ExceptionHandler exceptionHandler = new ExceptionHandler();
            key = true;
            while (key)
            {
                try
                {
                    searcher.FindSection(filesText, out startIndexOfSection, out countIndexOfSection);
                    key = false;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    exceptionHandler.Handle(e, key);
                }
                catch (ArgumentNullException e)
                {
                    exceptionHandler.Handle(e, key);
                }
            }
            int startIndexOfValue = 0;
            int endIndexOfValue = 0;
            key = true;
            while (key)
            {
                try
                {
                    searcher.FindValueByKey(filesText, startIndexOfSection, countIndexOfSection, out startIndexOfValue, out endIndexOfValue);
                    key = false;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    exceptionHandler.Handle(e, key);
                }
            }
            Outputer outputer = new Outputer();
            outputer.Value(filesText, startIndexOfValue, endIndexOfValue);
        }
    }
}
