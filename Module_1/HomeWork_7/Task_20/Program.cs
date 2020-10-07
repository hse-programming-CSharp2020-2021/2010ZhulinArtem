using System;
using static System.Console;

namespace Task_20
{
    class Program
    {
        static Random random = new Random();
        static int MinValueOfRandom = 10;
        static int MaxValueOfRandom = 101;


        static void Main(string[] args)
        {
            do
            {
                int value, userNumber;

                Clear();

                do
                {
                    Write("Enter value of array: ");
                } while (!int.TryParse(ReadLine(), out value) | value < 1);

                do
                {
                    Write("Enter any number more than 9 and less that 101: ");
                } while (!int.TryParse(ReadLine(), out userNumber) | userNumber < 10 | userNumber > 100);

                ArrayItemDouble(CreateArray(value), userNumber);

                WriteLine("\nESC - to exit, other keys - to continue...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }

        static int[] CreateArray(int value)
        {
            var intArray = new int[value];

            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(MinValueOfRandom, MaxValueOfRandom);
            }

            return intArray;
        }

        

        static void ArrayItemDouble(int[] intArray, int userNumber)
        {
            var changedArray = new int[intArray.Length];
            Array.Copy(intArray, 0, changedArray, 0, intArray.Length);

            var equalNumberIndex = new int[0];
            var indexOfArray = 0;

            WriteLine("Original array:");
            Print(intArray);

            for (var i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == userNumber)
                {
                    Array.Resize(ref equalNumberIndex, equalNumberIndex.Length + 1);
                    equalNumberIndex[indexOfArray++] = i;
                }
            }

            if (equalNumberIndex.Length > 0)
            {
                for (var i = 0; i < equalNumberIndex.Length; i++)
                {
                    Array.Resize(ref changedArray, changedArray.Length + 1);
                    for (var j = equalNumberIndex[i]; j < intArray.Length; j++)
                    {
                        changedArray[j + i + 1] = intArray[j];
                    }
                }

                WriteLine("Changed array:");
                Print(changedArray);
            }
        }

        static void Print(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                Write($"{intArray[i]} ");
            }

            WriteLine();
        }
    }
}