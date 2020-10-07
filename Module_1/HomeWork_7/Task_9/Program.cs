using System;
using static System.Console;

namespace Task_9
{
    class Program
    {
        static Random random = new Random();

        static int MinValue = -10;
        static int MaxValue = 11;


        static void Main(string[] args)
        {
            do
            {
                Clear();

                int value;
                do
                {
                    Write("Enter value of array: ");
                } while (!int.TryParse(ReadLine(), out value) | (value < 1));

                ArrayHill(CreateArray(value));

                WriteLine("\nESC - to exit, other keys - continue...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }


        static void ArrayHill(int[] intArray)
        {
            var changedArray = new int[intArray.Length];

            Write("Original array: ");
            Print(intArray);

            for (var i = 0; i < changedArray.Length / 2 + 1; i++)
            {
                changedArray[i] = GetMinElement(ref intArray);
                if (intArray.Length == 0)
                {
                    break;
                }

                changedArray[changedArray.Length - 1 - i] = GetMinElement(ref intArray);
                if (intArray.Length == 0)
                {
                    break;
                }
            }

            Write("Changed array: ");
            Print(changedArray);
        }

        static int GetMinElement(ref int[] intArray)
        {
            var min = intArray[0];
            var minIndex = 0;

            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] < min)
                {
                    min = intArray[i];
                    minIndex = i;
                }
            }

            RemoveElementByIndex(ref intArray, minIndex);

            return min;
        }

        static int[] CreateArray(int value)
        {
            var intArray = new int[value];

            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(MinValue, MaxValue);
            }

            return intArray;
        }

        static void RemoveElementByIndex(ref int[] arr, int index)
        {
            for (var j = index; j < arr.Length - 1; j++)
            {
                arr[j] = arr[j + 1];
            }

            Array.Resize(ref arr, arr.Length - 1);
        }

        static void Print(int[] intArray)
        {
            foreach (var element in intArray)
            {
                Write($"{element} ");
            }

            WriteLine();
        }
    }
}