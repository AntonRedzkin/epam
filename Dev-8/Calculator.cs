using System;

namespace Dev_8
{
    class Calculator
    {
        public double[,] Multiply(double[,] matrixA, double[,] matrixB)
        {
            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                throw new MultiplyException("Matrix impossible to multiply", 1);
            }
            double[,] matrixC = new double[matrixA.GetLength(0), matrixB.GetLength(1)];
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int r = 0; r < matrixB.GetLength(0); r++)
                    {
                        matrixC[i, j] += matrixA[i, r] * matrixB[r, j];
                    }
                }
            }
            return matrixC;
        }
    }
}
