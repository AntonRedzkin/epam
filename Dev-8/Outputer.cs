using System;

namespace Dev_8
{
    class Outputer
    {
        public void Print(string name, double[,] matrix)
        {
            Console.WriteLine("\nMatrix {0}:", name);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
