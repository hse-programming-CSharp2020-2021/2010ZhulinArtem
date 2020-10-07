using System;
using static System.Console;

namespace Task_11
{
    class Program
    {
        static long[] CreateArray(int N)
        {
            var intArray = new long[N];
            intArray[0] = 0;
            intArray[1] = 1;
            for (int i = 2; i < intArray.Length; i++)
            {
                intArray[i] = 34 * intArray[i - 1] - intArray[i - 2] + 2;
            }

            return intArray;
        }
        static void Main(string[] args)
        {
            do
            {
                Clear();
                int n;
                do
                {
                    Write("Enter value of array: ");
                } while (!int.TryParse(ReadLine(), out n) | (n < 1));
                
                WriteLine();
                Array.ForEach(CreateArray(n), x => Write($"{x} "));

                WriteLine("\n\nESC-to exit, other keys - to continue...");
            } while (ReadKey(true).Key!=ConsoleKey.Escape);
        }
    }
}
