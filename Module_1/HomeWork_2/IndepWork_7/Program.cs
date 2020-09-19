using System;
using static System.Console;

/*
 * Задача №7
 * Написать программу с использованием двух методов. Первый метод возвращает дробную и целую часть числа. 
 * Второй метод возвращает квадрат и корень из числа. В основной программе пользователь вводит дробное число. 
 * Программа должна вычислить, если это возможно, значение корня, квадрата числа, выделить целую и дробную часть из числа.
 */

namespace IndepWork_7
{
    class Program
    {
        /*
         * Метод получает параметр типа double.
         * Выдеяет из него целую и дробную часть.
         */
        public static void IntAndFract(double x)
        {
            WriteLine($"Целая часть числа x:{(int)x}, дробная часть: {Math.Abs(x%1):g5}");
        }
        /*
         * Метод получает параметр типа double.
         * Проводит над ним операции: возведения в квадрат и вычисления его корня.
         */
        public static void SqrAndSqrt(double x)
        {
            WriteLine(x > 0
                ? $"Квадрат числа x: {x * x:g5}, корень числа: {Math.Sqrt(x):g5}"
                : $"Квадрат числа x: {x * x:g5}, корень числа невозможно определить");
        }


        static void Main(string[] args)
        {
            double x;

            do
            {
                Clear();

                do
                {
                    Write("Введите корректное значение числа x: ");
                } while (!double.TryParse(ReadLine(), out x));

                IntAndFract(x);
                SqrAndSqrt(x);

                WriteLine("\nДля выхода нажмите ESC для продолжение - любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
