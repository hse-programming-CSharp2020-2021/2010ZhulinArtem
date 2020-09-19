using System;
using static System.Console;

/*
 * Задача №4
 */

namespace Task_4
{
    class Program
    {
        //Метод для вычисление функции G согласно условию задачи
        public static double CalculateFunc(double x, double y)
        {
            if (x<y && x>0)
            {
                return x + Math.Sin(y);
            }

            else if (x>y && x<0)
            {
                return y - Math.Cos(x);
            }
            return x * y * 0.5;
        }
        static void Main(string[] args)
        {
            double x, y;

            do
            {
                Clear();

                do
                {
                    Write("Введите значение x: ");
                } while (!double.TryParse(ReadLine(), out x));
                do
                {
                    Write("Введите значение y: ");
                } while (!double.TryParse(ReadLine(), out y));

                WriteLine("Значение функции G: "+CalculateFunc(x,y));

                WriteLine("\nДля выхода нажмите ESC, для продолжения любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
