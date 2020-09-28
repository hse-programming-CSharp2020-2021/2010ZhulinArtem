using System;
using static System.Console;

namespace IndepWork_4
{
    class Program
    {
        static void Print(double[] arr)
        {
            for (int i = 1; i < arr.Length + 1; i++)
            {
                WriteLine($"Элемент {i}: {arr[i - 1]}");
            }
        }
        static double[] CreateArr(int N)
        {
            double[] newarr = new double[N];
            newarr[0] = 1;
            newarr[1] = 1;

            for (int i = 2; i < N; i++)
            {
                newarr[i] = newarr[i - 2] + newarr[i - 1];
            }

            return newarr;
        }
        static void Main(string[] args)
        {
            int N;
            do
            {
                Clear();
                do
                {
                    Write("Введите количество элементов массива: ");
                } while (!int.TryParse(ReadLine(), out N) | (N < 1));


                Print(CreateArr(N));

                WriteLine("\nДля выхода нажмите ESC, для продолжения любую дргую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
