using System;
using static System.Console;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            uint value;

            do
            {
                Write("Enter value of array: ");
            } while (!uint.TryParse(ReadLine(), out value));

//            PrintArray(CreateArrayFirstMethod(value));
            PrintArray(CreateArraySecondMethod(value));
        }

        static void PrintArray(int[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++, WriteLine())
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Write($"{array[i, j],4} ");
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
                    arrayInt[i, j] = (int) ((j) * value + (j % 2 != 0 ? (value - i) : i + 1));
                }
            }

            return arrayInt;
        }

        static int[,] CreateArraySecondMethod(uint value)
        {
            var arrayInt = new int[value, value];
            var sumOfIndex = 0;
            var number = 1;

            for (var l = 0; l < value; l++)
            {
                for (var k = 0; k < value; k++)
                {
                    for (var j = 0; j < value; j++)
                    {
                        for (var i = 0; i < value; i++)
                        {
                            if (j + i == sumOfIndex)
                            {
                                if (i%2==0)
                                {
                                    if (j % 2 == 0)
                                    {
                                        arrayInt[j, i] = number++;

                                    }
                                    else
                                    {
                                        arrayInt[i, j] = number++;
                                    }

                                }
                                else
                                {
                                    if (j % 2 == 0)
                                    {
                                        arrayInt[i, j] = number++;

                                    }
                                    else
                                    {
                                        arrayInt[j, i] = number++;
                                    }
                                }



                                break;

                            }
                        }
                    }

                    sumOfIndex++;
                }
            }


            return arrayInt;
        }
    }
}