using System;
using static System.Console;

namespace Task_4
{
    internal class Program
    {
        private static void Print(int[,] intArray)
        {
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Write($"{intArray[i, j]}\t");
                }
                WriteLine();
            }
        }

        private static void Print(char[][,] charArray)
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < charArray[i].GetLength(0); j++)
                {
                    for (int k = 0; k < charArray[i].GetLength(1); k++)
                    {
                        Write($"{charArray[i][j,k]}");
                    }
                    WriteLine();

                }
                WriteLine();
            }
        }

        private static char[][,] CreateArray(uint value)
        {
            var charArray = new char[value][,];
            for (int i = 0; i < charArray.GetLength(0); i++)
            {
                charArray[i] = new char[i + 1, i + 1];

                for (int j = 0; j < charArray[i].GetLength(0); j++)
                {
                    for (int k = 0; k < charArray[i].GetLength(0); k++)
                    {
                        charArray[i][j, k] = '*';
                        if (k+1==j+1)
                        {
                            break;
                        }
                    }
                }
            }

            return charArray;
        }

        private static int[,] CreateArraySnake(uint value)
        {
            var intArray= new int[value,value];
            int number = 1;
            int change = 1;

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (change==1)
                    {
                        intArray[i, j] = number++;
                    }

                    if (change==-1)
                    {
                        intArray[j, i+1] = number++;
                    }

                }
                change *= -1;

            }

            return intArray;
        }

      

        private static void Main(string[] args)
        {
            uint N;
            do
            {
                Write("Enter number: ");
            } while (!uint.TryParse(ReadLine(), out N));

            Print(CreateArray(N));
            Print(CreateArraySnake(N));
        }
    }
}
