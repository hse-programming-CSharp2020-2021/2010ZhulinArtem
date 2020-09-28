using System;
using static System.Console;

namespace Task_8
{
    class Program
    {
        static void Print(double[] arr)
        {
            for (int i = 1; i < arr.Length+1; i++)
            {
                WriteLine($"Элемент {i}: {arr[i - 1]}");
            }
        }
        static double[] CreateArr(uint N)
        {
            double[] newarr = new double[N];

            for (int i = 0; i < N; i++)
            {
                newarr[i] = i * (i + 1) / 2 % N;
            }

            return newarr;
        }
        static void Main(string[] args)
        {
            uint N;
            do
            {
                Clear();
                do
                {
                    Write("Введите количество элементов массива: ");
                } while (!uint.TryParse(ReadLine(), out N));

                Print(CreateArr(N));

                WriteLine("\nДля выхода нажмите ESC, для продолжения любую дргую клавишу...");
            } while (ReadKey(true).Key!=ConsoleKey.Escape);
        }
    }
}
