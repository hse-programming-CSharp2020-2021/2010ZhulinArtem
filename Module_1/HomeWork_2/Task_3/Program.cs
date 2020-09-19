using System;
using static System.Console;

/*
Задача 3
Задача на применение тернарной операции. 
Написать метод, так обменивающий значения трех переменных x, y, z, чтобы выполнилось требование: x <= y <= z. 
В основной программе, вводить значения трех переменных и упорядочивать их с помощью обращения к написанному методу. 
Для выхода из программы вводите ESC, для повторения решения – любую другую клавишу. 
*/


namespace Task_3
{
    class Program
    {
        /*
         Функция принимает три значения и упорядычивает их по условию задания: x <= y <= z.
        */
        public static void Change(double x, double y, double z)
        {
            var x1 = x <= y && x <= z ? x : Math.Min(z,y);
            var z1 = x <= z && y <= z ? z : Math.Max(x, y);
            var y1 = x <= y && y <= z ? y : x + y + z - x1 - z1;
            
            WriteLine($"x= {x1:g8}, y= {y1:g8}, z= {z1:g8}");
        }

        static void Main(string[] args)
        {
            double x, y, z;

            do
            {
                Clear();

                do
                {
                    Write("Введите корректное значение x: ");
                } while (!double.TryParse(ReadLine(), out x));
                
                do
                {
                    Write("\nВведите корректное значение y: ");
                } while (!double.TryParse(ReadLine(), out y));
                
                do
                {
                    Write("\nВведите корректное значение z: ");
                } while (!double.TryParse(ReadLine(), out z));

                Change(x,y,z);

                WriteLine("\nДля выхода нажмите ESC для продолжение - любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
