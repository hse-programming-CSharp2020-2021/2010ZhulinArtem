using System;
using static System.Console;

namespace Task_16
{
    class Program
    {
        static Random random = new Random();
        private static int MinValueOfRandom = -10;
        private static int MaxValueOfRandom = 11;

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

                FindMinAndMaxElements(CreateArray(value));

                WriteLine("\nESC - to exit, other keys - to continue...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }

        static int[] CreateArray(int value)
        {
            var intArray = new int[value];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(MinValueOfRandom, MaxValueOfRandom);
            }

            return intArray;
        }

        static void FindMinAndMaxElements(int[] intArray)
        {
            var min = MaxValueOfRandom + 1;
            int minIndex=-1;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] < min)
                {
                    min = intArray[i];
                    minIndex = i;
                }
            }
            
            WriteLine($"Индекс минимального элемента: {minIndex}");

            var max = MinValueOfRandom - 1;
            int maxIndex=-1;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > max)
                {
                    max = intArray[i];
                    maxIndex = i;
                }
            }

            WriteLine($"Сумма индексов максимального и минимального элемента: {maxIndex} + {minIndex} = {maxIndex+minIndex}");
        }
    }
}