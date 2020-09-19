using System;
using static System.Console;

/*
 * Задача №1
 * Ввести значение x и вывести значение полинома: F(x) = 12x4 + 9x3 - 3x2 + 2x – 4.
 * Не применять возведение в степень. Использовать минимальное количество операций умножения.
 */

namespace IndepWork_1
{
    class Program
    {
        /*
         * Метод получает параметр типа double.
         * Подставляет его в выражение и возвращает значение данного выражения.
         */

        public static double Func_F (double x)
        {
            return x * (x * (x * (12 * x + 9) - 3) + 2) - 4;
        }

        static void Main(string[] args)
        {
            double x;
            do
            {
                Clear();

                do
                {
                    Write("Введите корректное значение x: ");
                } while (!double.TryParse(ReadLine(), out x));

                WriteLine(Func_F(x));

                WriteLine("\nДля выхода нажмите ESC для продолжение - любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
