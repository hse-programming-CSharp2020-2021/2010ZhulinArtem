using System;
using static System.Console;

namespace Task_5
{
    class Program
    {
        static Random random = new Random();
        static int minValueOfRandom = 0;
        static int maxValueOfRandom = 26;

        static void Main(string[] args)
        {
            do
            {
                int value;

                Clear();

                do
                {
                    Write("Enter value of array (more than 0): ");
                } while (!int.TryParse(ReadLine(), out value) | value < 1);

                Print(CreateArray(value));

                WriteLine("\nESC- to exit, other keys to continue...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }

        static int[,] CreateArray(int value)
        {
            var intArray = new int[value, value];

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    intArray[i, j] = random.Next(minValueOfRandom, maxValueOfRandom);
                }
            }

            return intArray;
        }

        static void Print(int[,] intArray)
        {
            PrintArray(intArray);

            PrintArrayFirst(intArray);

            PrintArraySecond(intArray);

            PrintArrayThird(intArray);

            PrintArrayFourth(intArray);
        }

        private static void PrintArrayFourth(int[,] intArray)
        {
            for (int i = 0; i < intArray.GetLength(0); i++, WriteLine())
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (j < i && j > intArray.GetLength(1) - 1 - i && j > (int) (intArray.GetLength(1) / 2.0 - 0.5)
                        || j > i && j < intArray.GetLength(1) - 1 - i && j < (int) (intArray.GetLength(1) / 2.0))
                    {
                        Write($"{intArray[i, j],3}");
                    }
                    else
                    {
                        Write($"{"",3}");
                    }
                }
            }

            WriteLine();
        }

        private static void PrintArrayThird(int[,] intArray)
        {
            for (int j = 0; j < intArray.GetLength(0); j++, WriteLine())
            {
                for (int i = 0; i < intArray.GetLength(1); i++)
                {
                    if (i < j && i > intArray.GetLength(1) - 1 - j || i > j && i < intArray.GetLength(1) - 1 - j)
                    {
                        Write($"{intArray[j, i],3}");
                    }
                    else
                    {
                        Write($"{"",3}");
                    }
                }
            }

            WriteLine();
        }

        private static void PrintArraySecond(int[,] intArray)
        {
            for (int i = 0; i < intArray.GetLength(0); i++, WriteLine())
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (j <= i && j >= intArray.GetLength(1) - 1 - i)
                    {
                        Write($"{intArray[i, j],3}");
                    }
                    else
                    {
                        Write($"{"",3}");
                    }
                }
            }

            WriteLine();
        }

        private static void PrintArrayFirst(int[,] intArray)
        {
            for (int i = 0; i < intArray.GetLength(0); i++, WriteLine())
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (i > j && i < intArray.GetLength(1) - 1 - j)
                    {
                        Write($"{intArray[i, j],3}");
                    }
                    else
                    {
                        Write($"{"",3}");
                    }
                }
            }

            WriteLine();
        }

        private static void PrintArray(int[,] intArray)
        {
            for (int i = 0; i < intArray.GetLength(0); i++, WriteLine())
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Write($"{intArray[i, j],3} ");
                }
            }

            WriteLine();
        }
    }
}