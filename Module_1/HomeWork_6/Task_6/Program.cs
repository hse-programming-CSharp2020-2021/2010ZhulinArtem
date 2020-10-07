using System;
using static System.Console;

namespace Task_6
{
    class Program
    {
        static Random random= new Random();
        static void Print(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                Write($"Индекс {i}: {intArray[i]} ");
                if ((i + 1) % 5 == 0)
                {
                    WriteLine();
                }
            }
        }

        static int[] CreateArray(uint userNumber)
        {
            var intArray = new int[userNumber];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(-10, 11);
            }

            intArray = ChangeArray(intArray);

            return intArray;
        }

        private static int[] ChangeArray(int[] intArray)
        {
            for (int i = 0; i < intArray.Length-1; i++)
            {
                if ((intArray[i] + intArray[i + 1]) % 3 == 0)
                {
                    intArray[i] = intArray[i] * intArray[i + 1];
                    
                        for (int j = i+1; j < intArray.Length - 1; j++)
                        {
                            intArray[j] = intArray[j + 1];
                        }

                        Array.Resize(ref intArray, intArray.Length - 1);
                }
            }


            return intArray;
        }

        static void Main(string[] args)
        {
            uint valueOfArray;
            do
            {
                Clear();

                do
                {
                    Write("Enter value of array : ");
                } while (!uint.TryParse(ReadLine(), out valueOfArray)| valueOfArray<1);

                Print(CreateArray(valueOfArray));

                WriteLine("\n\nESC-to exit, other keys - to continue");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
