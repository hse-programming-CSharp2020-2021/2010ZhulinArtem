using System;
using static System.Console;

namespace IndepWork_3
{
    class Program
    {
        static void Print(int[] arr)
        {
            for (int i = 1; i < arr.Length + 1; i++)
            {
                WriteLine($"Элемент {i}: {arr[i - 1]}");
            }
        }
        static int[] CreateArr(int N, int A, int D)
        {
            int[] newarr = new int[N];

            for (int i = 0; i < N; i++)
            {
                newarr[i] = A + i * D;
            }

            return newarr;
        }
        static void Main(string[] args)
        {
            int N,A,D;
            do
            {
                Clear();
                do
                {
                    Write("Введите количество элементов массива: ");
                } while (!int.TryParse(ReadLine(), out N) | (N < 1));

                do
                {
                    Write("Введите значение А: ");
                } while (!int.TryParse(ReadLine(), out A));

                do
                {
                    Write("Введите значение В: ");
                } while (!int.TryParse(ReadLine(), out D));

                Print(CreateArr(N, A, D));

                WriteLine("\nДля выхода нажмите ESC, для продолжения любую дргую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
