using System;
using static System.Console;

namespace Task_13
{
    class Program
    {
        static Random random= new Random();


        static void Main(string[] args)
        {
            do
            {
                int a, k;

                Clear();

                do
                {
                    Write("Enter value of array: ");
                } while (!int.TryParse(ReadLine(), out a) | (a < 1));

                do
                {
                    Write("Enter any number more than 0: ");
                } while (!int.TryParse(ReadLine(), out k) | (k < 1) | (k > a));

                Clear();

                CreateArray(a, k);

                WriteLine("\nESC-to exit, other keys - to continue...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }


        static void CreateArray(int a, int k)
        {
            var intArray = new int[a];

            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(-100, 101);
            }

            WriteLine("Original array: ");
            Array.ForEach(intArray, x => Write($"{x} "));
            WriteLine();

            WriteLine("\nElements with index multiples K array: ");
            Print(intArray, k);
        }

        static void Print(int[] intArray, int k)
        {
            for (var i = k; i < intArray.Length; i += k)
            {
                Write($"Index {i}: {intArray[i]} ");
            }

            WriteLine();
        }
    }
}
