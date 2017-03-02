using System;

namespace Dev_8
{
    class Inputer
    {
        public void CreateMatrix(string name, out double[,] matrix)
        {
            Console.WriteLine("Enter the dimension of matrix {0}: ", name);
            matrix = new double[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}[{1},{2}] = ", name, i, j);
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
    }
}
