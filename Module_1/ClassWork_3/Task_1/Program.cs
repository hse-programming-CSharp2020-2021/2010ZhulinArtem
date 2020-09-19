using System;
using Microsoft.VisualBasic;
using static System.Console;

namespace Task_1
{
    
        class Program
        {
            
            public static void QuadtraticEq(double a, double b, double c, out double? x1, out double? x2)
            {
                var d = b * b - 4 * a * c;

                if (a != 0)
                {
                    if (d >= 0)
                    {
                        x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    }

                    else
                    {
                        x1 = null;
                        x2 = null;
                    }
                }
                else if (b == 0 && c != 0)
                {
                    x1 = null;
                    x2 = null;
                }
                else if (b == 0 && c == 0)
                {
                    x1 = 0;
                    x2 = 0;
                }
                else
                {
                    x1 = null;
                    x2 = null;
                }
            }

            static void Main(string[] args)
            {
                double a, b, c;
                double? x1;
                double? x2;
                do
                {
                    Clear();

                    do
                    {
                        Write("Введите корректное значение коэффициента А: ");
                    } while (!double.TryParse(ReadLine(), out a));

                    do
                    {
                        Write("Введите корректное значение коэффициента B: ");
                    } while (!double.TryParse(ReadLine(), out b));

                    do
                    {
                        Write("Введите корректное значение коэффициента C: ");
                    } while (!double.TryParse(ReadLine(), out c));

                    QuadtraticEq(a, b, c, out x1, out x2);
                    if (x1 != null && x2 != null)
                    {
                        WriteLine($"x1={x1}\nx2={x2}");
                    }
                    else
                    {
                        WriteLine("Корней нет");
                    }

                    WriteLine("\nДля выхода нажмите ESC для продолжение - любую другую клавишу...");
                } while (ReadKey(true).Key != ConsoleKey.Escape);
            }

        }
}
