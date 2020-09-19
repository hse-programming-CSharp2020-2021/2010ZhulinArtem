using System;
using static System.Console;

/*
 * Задача №5
 * Получить от пользователя три вещественных числа и проверить для них неравенство треугольника.
 * Оператор if не применять. Точность вывода три знака после запятой.
 */

namespace IndepWork_5
{
    internal class Program
    {
        /*
         * Метод получает три параметра типа double.
         * Проводит сортировку переменных по их величине.
         * Выводит необходимое сообщение согласно условию задачи.
         */
        public static void Istriangle(double a, double b, double c)
        {
            var a1 = a <= b && a <= c ? a : Math.Min(c, b);
            var c1 = a <= c && b <= c ? c : Math.Max(a, b);
            var b1 = a <= b && b <= c ? b : a + b + c - a1 - c1;

            if (a1 + b1 < c1 && a1 + c1 < b1 && c1 + b1 < a1)
                WriteLine(
                    $"Треугольник может существовать, если его большая сторона равна: {c1}, а другие: {a1} и {b1}.");
            else
                WriteLine($"Треугольник со сторонами: {a1}, {b1}, {c1}; не может существовать.");
        }

        private static void Main(string[] args)
        {
            double a, b, c;

            do
            {
                Clear();

                do
                {
                    Write("Введите корректное значение стороны a: ");
                } while (!double.TryParse(ReadLine(), out a));

                do
                {
                    Write("Введите корректное значение стороны b: ");
                } while (!double.TryParse(ReadLine(), out b));

                do
                {
                    Write("Введите корректное значение стороны c: ");
                } while (!double.TryParse(ReadLine(), out c));

                Istriangle(a, b, c);

                WriteLine("\nДля выхода нажмите ESC для продолжение - любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}