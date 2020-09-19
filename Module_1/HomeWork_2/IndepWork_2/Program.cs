using System;
using static System.Console;

/*
 * Задача №2
 * Ввести натуральное трехзначное число Р.
 * Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р.
 */

namespace IndepWork_2
{
    class Program
    {
        /*
         * Метод получает параметр типа Int.
         * Разделяет его по разрядам, проводит сортировку разрядов по величине
         * Вычисляет число, соответствующее максимально возможному значение при перестановки цифр исходного параметра
         */
        public static void MaxValue(int p)
        {
            var first = p / 100;
            var second = p % 100 / 10;
            var third = p % 10;

            var maxFirst = Math.Max(Math.Max(first, second), third);
            var maxThird = Math.Min(Math.Min(first, second), third);
            var maxSecond = first + second + third - maxThird - maxFirst;

            WriteLine("Максимальное значение при перестановке цифр числа P: " + maxFirst + maxSecond + maxThird);
        }

        static void Main(string[] args)
        {
            int p;

            do
            {
                Clear();
            
                do
                {
                    Write("Введите корректное трехзначное число P: ");
                } while (!int.TryParse(ReadLine(), out p) | p < 100 | p > 999);
                
                MaxValue(p);
             
                WriteLine("\nДля выхода нажмите ESC для продолжение - любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
