using System;
using static System.Console;

namespace IndepWork_3
{
    class Program
    {
        public static void PrintFunc(double a, double b, double c, double y, double x)
        {
            WriteLine($"\t{a}\t|\t{b}\t|\t{c}\t|\t{x:G3}\t|\t{y:G8}");
        }
        static void Func(double a, double b, double c)
        {
            double y=0;
            double x = 1;
            while (x<2.05)
            {
                if (x < 1.2)
                {
                    y = a * (x) * x + b * x + c;
                }
                else if (x == 1.2)
                {
                    y = a / x + Math.Sqrt(x * x + 1);
                }
                else if (x > 1.2)
                {
                    y = (a + b * x) / Math.Sqrt(x * x + 1);
                }
                PrintFunc(a, b, c, y, x);
                x += 0.05;
            }
        }

        static void Main(string[] args)
        {
            double a, b, c;
            do
            {
                Clear();

                do
                {
                    Write("Введите значение a: ");
                } while (!double.TryParse(ReadLine(), out a));
                do
                {
                    Write("Введите значение b: ");
                } while (!double.TryParse(ReadLine(), out b));
                do
                {
                    Write("Введите значение c: ");
                } while (!double.TryParse(ReadLine(), out c));
                
                Clear();

                WriteLine("*- - - - - - - -|- - - - - - - -|- - - - - - - -|- - - - - - - -|- - - - - - - -*");
                WriteLine("\ta\t|\tb\t|\tc\t|\tx\t|\ty");
                WriteLine("*- - - - - - - -|- - - - - - - -|- - - - - - - -|- - - - - - - -|- - - - - - - -*");

                Func(a,b,c);

                WriteLine("\nДля выхода нажмите ESC, для продолжения любую дргую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
