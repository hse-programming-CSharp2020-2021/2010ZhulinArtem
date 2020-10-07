using System;
using static System.Console;

namespace Task_4
{
    class Program
    {
        static Random random = new Random();
        private static double minValueOfRandom = -10;
        private static double maxValueOfRandom = 11;

        static void Main(string[] args)
        {
            do
            {
                int value;

                Clear();

                do
                {
                    Write("Enter value of array(2 or 3): ");
                } while (!int.TryParse(ReadLine(), out value) | value < 2 | value > 3);


                WriteLine($"{FindDeterm(CreateArray(value)):G4}");

                WriteLine("\nESC-to exit, other keys to continue...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }

        static void Print(double[,] doubleArray)
        {
            for (int i = 0; i < doubleArray.GetLength(0); i++, WriteLine())
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    Write($"{doubleArray[i,j]:G4}\t");
                }
            }
            WriteLine();
        }

        static double[,] CreateArray(int value)
        {
            var doubleArray = new double[value, value];

            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    doubleArray[i, j] = random.NextDouble() * (maxValueOfRandom - minValueOfRandom) + minValueOfRandom;
                }
            }

            Print(doubleArray);

            return doubleArray;
        }

        static double FindDeterm(double[,] doubleArray)
        {
            double det = 0;
            if (doubleArray.Length == 4)
            {
                det = doubleArray[0, 0] * doubleArray[1, 1]
                      - doubleArray[0, 1] * doubleArray[1, 0];
            }

            if (doubleArray.Length == 9)
            {
                det = (doubleArray[0, 0] * doubleArray[1, 1] * doubleArray[2, 2]
                       + doubleArray[0, 1] * doubleArray[1, 2] * doubleArray[2, 0]
                       + doubleArray[0, 2] * doubleArray[1, 0] * doubleArray[2, 1])

                      - (doubleArray[0, 0] * doubleArray[1, 2] * doubleArray[2, 1]
                         + doubleArray[0, 1] * doubleArray[1, 0] * doubleArray[2, 2]
                         + doubleArray[0, 2] * doubleArray[1, 1] * doubleArray[2, 0]);
            }

            return det;
        }
    }
}