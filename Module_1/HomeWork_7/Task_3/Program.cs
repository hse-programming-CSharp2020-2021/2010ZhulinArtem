using System;
using static System.Console;

namespace Task_3
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
                } while (!int.TryParse(ReadLine(), out value) | value < 1);

                Print(CreateArrayFirst(value));
                Print(CreateArraySecond(value));

                WriteLine("\nESC-to exit, other keys to continue...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }

        static void Print(char[][] intArray)
        {
            for (var i = 0; i < intArray.Length; i++)
            {
                for (var j = 0; j < intArray[i].Length; j++)
                {
                    Write($"{intArray[i][j],2}");
                }

                WriteLine();
            }

            WriteLine();
        }

        static char[][] CreateArrayFirst(int value)
        {
            var intArray = new char[value][];

            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = new char[i + 1];
                for (var j = 0; j < intArray[i].Length; j++) intArray[i][j] = '*';
            }

            return intArray;
        }

        static char[][] CreateArraySecond(int value)
        {
            var intArray = new char[value][];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = new char[value + i + 1];
                for (int j = 0; j < intArray[i].Length; j++)
                {
                    intArray[i][j] = j > value - i - 1 ? '*' : ' ';
                }
            }

            return intArray;
        }
    }
}