using System;
using static System.Console;

namespace Task_6
{
    class Program
    {
        static Random random = new Random();
        static int minValueOfRandom = 0;
        static int maxValueOfRandom = 21;

        static void Main(string[] args)
        {
            do
            {
                Clear();

                FindDeterm(CreateArray());

                WriteLine("\nESC- to exit, other keys to continue...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }

        static int[,] CreateArray()
        {
            var intArray = new int[3, 6];

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    intArray[i, j] = random.Next(minValueOfRandom, maxValueOfRandom);
                }
            }

            return intArray;
        }

        static void FindDeterm(int[,] intArray)
        {
            var det = new int[2];

            for (int i = 0; i < 2; i++)
            {
                det[i] = (intArray[0, 0 + i * 3] * intArray[1, 1 + i * 3] *
                          intArray[2, 2 + i * 3]
                          + intArray[0, 1 + i * 3] * intArray[1, 2 + i * 3] *
                          intArray[2, 0 + i * 3]
                          + intArray[0, 2 + i * 3] * intArray[1, 0 + i * 3] *
                          intArray[2, 1 + i * 3])
                         - (intArray[0, 0 + i * 3] * intArray[1, 2 + i * 3] *
                            intArray[2, 1 + i * 3]
                            + intArray[0, 1 + i * 3] * intArray[1, 0 + i * 3] *
                            intArray[2, 2 + i * 3]
                            + intArray[0, 2 + i * 3] * intArray[1, 1 + i * 3] *
                            intArray[2, 0 + i * 3]);
            }

            Print(intArray);

            Array.ForEach(det, x => Write($"{x} "));
        }

        static void Print(int[,] intArray)
        {
            for (int i = 0; i < intArray.GetLength(0); i++, WriteLine())
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Write($"{intArray[i, j],3}");
                }
            }

            WriteLine();
        }
    }
}