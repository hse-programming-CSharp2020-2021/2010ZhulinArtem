using System;
using static System.Console;

/*
 * Задание №4
 */

namespace Task_10
{
    class Program
    {
        static bool Newton(double x, out double square, out double epsilon)
        {
            double result1, result2 = x;
            square = epsilon = 0.0;
            if (x <= 0.0)
            {
                WriteLine("Ошибка в данных!");
                return false;
            }

            do
            {
                result1 = result2;
                epsilon = x / result1 / 2 - result1 / 2;
                result2 = result1 + epsilon;
            } while (result1 != result2);

            square = result2;
            return true;
        }

        static void Main(string[] args)
        {
            double x;
            Title = "Формула Ньютона";
            do
            {
                do
                {
                    Clear();
                    Write("Введите значение x=");
                } while (!double.TryParse(ReadLine(), out x));

                if (!Newton(x, out var result, out var epsilon))
                {
                    WriteLine("\nДля выхода нажмите клавишу ESC, для продолжения  - любую другую...");
                    continue;
                }

                WriteLine($"root({x}) = {result,8:f4}, epsilon = {epsilon,8:e4}");

                WriteLine("\nДля выхода нажмите клавишу ESC, для продолжения  - любую другую...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}
