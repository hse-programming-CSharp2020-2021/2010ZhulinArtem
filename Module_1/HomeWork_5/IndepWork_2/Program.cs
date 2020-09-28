using System;
using static System.Console;

namespace IndepWork_2
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
        static int[] CreateArr(uint N)
        {
            int[] newarr = new int[N];
            int j = 0;
            for (int i = 0; i < N; i++)
            {
                while (true)
                {
                    j++;
                    if (j % 2 != 0)
                    {
                        newarr[i] = j;
                        break;
                    }
                }
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
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
