using System;
using static System.Console;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint value;

            do
            {
                Write("Enter value of Pascal triangle: ");
            } while (!uint.TryParse(ReadLine(), out value));

            PrintArray(Pascal(value));
        }

        static void PrintArray(int[][] array)
        {
            foreach (var line in array)
            {
                foreach (var number in line)
                {
                    Write($"{number} ");
                }

                WriteLine();
            }
        }

        static int[][] Pascal(uint value)
        {
            var arrayPascal = new int[value][];
            for (var i = 0; i < arrayPascal.GetLength(0); i++)
            {
                arrayPascal[i] = new int[1 + i ];
                for (var j = 0; j < i+1; j++)
                {
                    arrayPascal[i][j] = NumOfCombinations(i, j );
                }
            }

            return arrayPascal;
        }

        static int NumOfCombinations(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        static int Factorial(int number)
        {
            return 0 != number ? number * Factorial(number - 1) : 1;
        }
    }
}