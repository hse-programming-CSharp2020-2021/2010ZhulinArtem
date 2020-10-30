using System;
using static System.Console;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            uint value;

            do
            {
                Write("Enter value of Pascal triangle: ");
            } while (!uint.TryParse(ReadLine(), out value));

            PrintArray(CreateArrayFirstMethod(value));
        }

        static void PrintArray(int[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++,WriteLine())
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Write($"{array[i,j],4} ");
                }
            }
        }

        static int[,] CreateArrayFirstMethod(uint value)
        {
            var arrayInt = new int[value, value];
            for (var j = 0; j < value; j++)
            {
                for (var i = 0; i < value; i++)
                {
                    arrayInt[i, j] =(int) ((j)*value+  (j % 2 != 0 ? (value - i) : i+1));
                }
            }
            return arrayInt;
        }
    }
}