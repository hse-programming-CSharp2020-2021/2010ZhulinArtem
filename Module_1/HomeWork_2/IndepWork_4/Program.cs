using System;
using static System.Console;

/*
 * Задача №4
 * Получить от пользователя четырехзначное натуральное число и напечатать его цифры в обратном порядке.
 */

namespace IndepWork_4
{
    internal class Program
    {
        /*
         * Метод получает параметр типа string.
         * Используя обратный цикл for, метод выводит элементы строки в обратном порядке.
         */
        public static void Column(string number)
        {
            for (var i = number.Length - 1; i >= 0; i--) Write(number[i]);
        }

        private static void Main(string[] args)
        {
            int x;

            do
            {
                Clear();

                do
                {
                    Write("Введите корректное трехзначное число: ");
                } while (!int.TryParse(ReadLine(), out x) | (x < 1000) | (x > 9999));

                Column(x.ToString());

                WriteLine("\nДля выхода нажмите ESC для продолжение - любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}