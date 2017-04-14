using System;
using System.Globalization;
using System.Threading;

namespace Dev_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Inputer inputer = new Inputer();
            double[,] matrixA = { { 0 }, { 0 } };
            double[,] matrixB = { { 0 }, { 0 } };
            inputer.CreateMatrix("A", out matrixA);
            inputer.CreateMatrix("B", out matrixB);
            Outputer outputer = new Outputer();
            outputer.Print("A", matrixA);
            outputer.Print("B", matrixB);
            Calculator calculator = new Calculator();
            try
            {
                double[,] matrixC = calculator.Multiply(matrixA, matrixB);
                outputer.Print("C = A * B", matrixC);
            }
            catch (MultiplyException exception)
            {
                Console.WriteLine("\nAn error has occurred: {0}", exception.Message);
            }
        }
    }
}
