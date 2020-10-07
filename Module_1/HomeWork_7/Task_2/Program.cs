using System;
using static System.Console;

namespace Task_2
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
                    Write("Enter value of array more than 0: ");
                } while (!int.TryParse(ReadLine(), out value)|value<1);

                Print(CreateArray(value));

                WriteLine("\nESC-to exit, other keys to continue...");
            } while (ReadKey(true).Key!=ConsoleKey.Escape);
        }

        static void Print(int[][] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = 0; j < intArray[i].Length; j++)
                {
                    Write($"{intArray[i][j],5}");
                }
                WriteLine();
            }
            WriteLine();
        }

        static int[][] CreateArray(int value)
        {
            var intArray = new int[value][];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i]=new int[i+1];
                for (int j = 0; j < intArray[i].Length; j++)
                {
                    intArray[i][j] = value--;
                }
            }

            return intArray;
        }
    }
}
