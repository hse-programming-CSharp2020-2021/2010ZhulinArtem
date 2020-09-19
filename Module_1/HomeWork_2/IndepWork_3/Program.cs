using System;
using static System.Console;

/*
 * Задача №3
 * Введя значения коэффициентов А, В, С, вычислить корни квадратного уравнения.
 * Учесть (как хотите) возможность появления комплексных корней.
 * Оператор if не применять.
 */

namespace IndepWork_3
{
    class Program
    {
        /*
         * Метод получает три параметра типа double
         * Производит над ними операции, вычисляя дискриминант и корни уравнения 
         * В случае если дискриминант меньше нуля, метод выводит следующее сообщение:
         * "Дискриминант меньше нуля"
         */
        public static void QuadtraticEq(double a, double b, double c)
        {
            var d = b * b - 4 * a * c;
            if (d>=0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);

                WriteLine($"Корни уравнения {a}*x^2 + ({b})*x + ({c}) = 0 равны:\nx1 = {x1:g2} ; x2 = {x2:g2}");
            }

            else
            {
                WriteLine("Дискриминант меньше нуля");
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
                    Write("Введите корректное значение коэффициента А: ");
                } while (!double.TryParse(ReadLine(), out a)| a==0);
                do
                {
                    Write("Введите корректное значение коэффициента B: ");
                } while (!double.TryParse(ReadLine(), out b));
                do
                {
                    Write("Введите корректное значение коэффициента C: ");
                } while (!double.TryParse(ReadLine(), out c));

                QuadtraticEq(a,b,c);

                WriteLine("\nДля выхода нажмите ESC для продолжение - любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
