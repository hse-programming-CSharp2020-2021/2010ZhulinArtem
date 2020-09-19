using System;
using static System.Console;

namespace Task_2
{
    class Program
    {
        static void Total(double k, double r, uint n, out double A)
        {
            A = k * Math.Pow(1 + r / 100, n);
        }

        static void Main(string[] args)
        {
            double k, r, A;
            uint n;
            do
            {
                Clear();
                do
                {
                    Write("Введите начальный капитал: ");
                } while (!double.TryParse(ReadLine(), out k) | k < 0);

                do
                {
                    Write("Введите годовую процентную ставку: ");
                } while (!double.TryParse(ReadLine(), out r) | r < 0);

                do
                {
                    Write("Введите количество лет: ");
                } while (!uint.TryParse(ReadLine(), out n));

                for (uint i = 0; i < n; i++)
                {
                    Total(k, r, i + 1, out A);
                    WriteLine($"Итого в {i + 1} год: {A:f}");
                }

                WriteLine("\nДля выхода нажмите ESC");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}