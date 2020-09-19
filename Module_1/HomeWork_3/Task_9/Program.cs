using System;
using static System.Console;

/*
 * Задание №3
 */

namespace Task_9
{
    class Program
    {
        //Вычисление значение функции
        public static double func(double x)
        {
            return x * x;
        }

        //Метод вычисляет площадь фигуры под графиком
        public static double SquareSum(double A, double delta)
        {
            double S = 0;
            double i = 0;
            var flag = false;

            for (; i + delta <= A; i += delta)
            {
                flag = true;
                S += delta * (func(i) + func(i + delta)) / 2;
            }

            if (flag)
            {
                S += (A - (i - delta)) * (func(i - delta) + func(A)) / 2;
            }
            else
            {
                S += A * func(A) / 2;
            }

            return S;
        } 
        static void Main(string[] args)
        {
            double A, delta;
            do
            {
                Clear();

                Write("Введите значение А: ");
                while (!double.TryParse(ReadLine(), out A))
                {
                    WriteLine("Введены некорректные данные. Попробуйте снова.");
                    Write("Введите значение А: ");
                }

                Write("Введите значение delta: ");
                while (!double.TryParse(ReadLine(), out delta))
                {
                    WriteLine("Введены некорректные данные. Попробуйте снова.");
                    Write("Введите значение delta: ");
                }

                WriteLine("Площадь под графиком: " + SquareSum(A, delta));

                WriteLine("\nДля выхода нажмите ESC, для продолжения - любую другю...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
