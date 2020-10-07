using System;
using static System.Console;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int value;

                Clear();

                do
                {
                    Write("Enter value of array: ");
                } while (!int.TryParse(ReadLine(), out value) | value < 1);

                Print(CreateMatrixFirst(value));
                Print(CreateMatrixSecond(value));
                Print(CreateMatrixThird(value));

                WriteLine("\nESC-to exit, other keys - to continue...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }

        static void Print(int[,] intArray)
        {
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Write($"{intArray[i, j],5}");
                }

                WriteLine();
            }

            WriteLine();
        }

        static int[,] CreateMatrixFirst(int value)
        {
            var intArray = new int[value, value];

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (j == i) intArray[i, j] = 0;

                    if (j < i) intArray[i, j] = -1;

                    if (j > i) intArray[i, j] = 1;
                }
            }

            return intArray;
        }
        
        static int[,] CreateMatrixSecond(int value)
        {
            var intArray = new int[value, value];

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (j == intArray.GetLength(0)-i-1) intArray[i, j] = 0;

                    if (j < intArray.GetLength(0)-i-1) intArray[i, j] = -1;

                    if (j > intArray.GetLength(0)-i-1) intArray[i, j] = 1;
                }
            }

            return intArray;
        }

        static int[,] CreateMatrixThird(int value)
        {
            var intArray = new int[value, value];

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {

                }
            }

            return intArray;
        }
    }
}