using System;
using static System.Console;

/*
 * Задача №5
 */

namespace Task_5
{
    class Program
    {
        //Метод для вычисление функции G согласно условию задачи
        public static double CalculateFunc(double x)
        {
            if (x <= 0.5)
            {
                return Math.Sin(Math.PI / 2);
            }

            return Math.Sin(Math.PI * (x - 1) / 2);
        }

        static void Main(string[] args)
        {
            double x;

            do
            {
                Clear();

                do
                {
                    Write("Введите значение x: ");
                } while (!double.TryParse(ReadLine(), out x));

                WriteLine("Значение функции G: " + CalculateFunc(x));

                WriteLine("\nДля выхода нажмите ESC, для продолжения любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
