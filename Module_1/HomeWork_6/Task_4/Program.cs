using System;
using static System.Console;

namespace Task_4
{
    class Program
    {
        static void Print(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                Write($"Индекс {i}: {intArray[i]} ");
                if ((i+1)%5==0)
                {
                    WriteLine();
                }
            }
        }

        static int[] CreateArray(int userNumber)
        {
            var intArray=new int[100000];
            intArray[0] = userNumber;
            
            var valueOfArray = 1;

            for (int i = 1; i < intArray.Length+1; i++)
            {
                
                intArray[i] = intArray[i - 1] % 2 == 0 ? intArray[i - 1] / 2 : (3 * intArray[i - 1] + 1);

                if (intArray[i - 1] > 1)
                {
                    valueOfArray++;
                }
                else
                {
                    Array.Resize(ref intArray, valueOfArray);
                }
            }

            return intArray;
        }

        static void Main(string[] args)
        {
            int userNumber;
            do
            {
                Clear();

                do
                {
                    Write("Enter number >=1: ");
                } while (!int.TryParse(ReadLine(),out userNumber)| userNumber<1);

                Print(CreateArray(userNumber));

                WriteLine("\nESC-to exit, other keys - to continue");
            } while (ReadKey(true).Key!=ConsoleKey.Escape);
        }
    }
}
