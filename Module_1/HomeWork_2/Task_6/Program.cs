using System;
using static System.Console;

/*
 * Задача №6
 * Задан круг с центром в начале координат и радиусом R=10.   
 * Ввести  координаты точки и вывести сообщение:   «Точка внутри круга!» или «Точка вне круга!».
 * Предусмотреть проверку входных данных и цикл повторения решений.  
 */

namespace Task_6
{
    class Program
    {
        /*
         * Метод принимает два параметра типа double, проводит проверку на принадлежность данной точки к данному кругу
         * Есть возможность быстрого изменения констант x1 и y1 (координаты центра круга) и радиуса круга R.
         */
        public static void IsBelong(double x, double y)
        {
            double R = 10;
            double x1 = 0;
            double y1 = 0;

            var test = Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2);

            string msg = test <= R * R ? "Точка внутри круга!" : "Точка вне круга!";

            WriteLine(msg);
        }

        static void Main(string[] args)
        {
            double x,y;

            do
            {
                Clear();

                do
                {
                    Write("Введите корректное значение координаты x: ");
                } while (!double.TryParse(ReadLine(), out x));

                do
                {
                    Write("Введите корректное значение координаты y: ");
                } while (!double.TryParse(ReadLine(), out y));

                IsBelong(x,y);

                WriteLine("\nДля выхода нажмите ESC для продолжение - любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
