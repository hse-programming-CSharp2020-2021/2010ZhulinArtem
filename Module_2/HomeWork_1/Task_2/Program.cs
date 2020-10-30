using System;

namespace Task_2
{
    class Program
    {
        private static Random random = new Random();
        private static void Main(string[] args)
        {
            int valueofFirst
        }

        private static int[,] CreateMatrix(int m,int n)
        {
            var matrix = new int[m, n];
            
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1, 11);
                }
            }

            return matrix;
        }

        private static int[,] MatrixMult(int[,] A, int[,] B)
        {

            if (A.GetLength(1)!=B.GetLength(0))
            {
                Console.WriteLine("Multiplication is impossible");
                return null;
            }

            var matrix = new int[A.GetLength(1), B.GetLength(0)];
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    for (var k = 0; k < A.GetLength(1); k++)
                    {
                        matrix[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            return matrix;
        }

        private static void MaxToString(int[,] matrix)
        {
            if (matrix==null)
            {
                Console.Write("Error");
                return;
            }
            for (var i = 0; i < matrix.GetLength(0); i++,Console.WriteLine())
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"{matrix[i,j],3}");
                }
            }
        }
    }
}
