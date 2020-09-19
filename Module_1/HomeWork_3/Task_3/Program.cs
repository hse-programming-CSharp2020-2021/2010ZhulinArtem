using System;
using static System.Console;
/*
 * Задача №3
 * Написать метод, вычисляющий логическое значение функции G=F(X,Y).
 * Результат равен true, если точка с координатами (X,Y) попадает в фигуру G,
 * и результат равен false, если точка с координатами (X,Y) не попадает в фигуру G.
 * Фигура G - сектор круга радиусом R=2 в диапазоне углов -90<= fi <=45.
 */

namespace Task_3
{
    class Program
    {
        //Константа R
        public static double R = 2;

        //Метод вычисляющий косинус по координатам 
        public static double CalculateCosVector(double x01, double y01, double x02, double y02, double x11, double y11, double x12, double y12)
        {
            var scalar = (x02 - x01) * (x12 - x11) + (y02 - y01) * (y12 - y11);

            var length = Math.Sqrt(Math.Pow(x02 - x01, 2) + Math.Pow(y02 - y01, 2)) *
                Math.Sqrt(Math.Pow(x12 - x11, 2) + Math.Pow(y12 - y11, 2));

            return length != 0 ? scalar / length : 0;
        }

        //Метод проверяет принадлежность точки к кругу
        public static bool IsBelongToCircle(double x, double y, double xA, double yA)
        {
            return Math.Pow(xA - x, 2) + Math.Pow(yA - y, 2) <= R * R;
        }

        //Метод проверяет принадлежность точки к сектору, используя методы на проверку принадлежности к кругу и вычисление косинуса
        public static bool IsBelongToSector(double x, double y, double xA, double yA)
        {
            var cosAlpha = CalculateCosVector(x, y, x, y - R, x, y, xA, yA);

            var cosLimit = CalculateCosVector(x, y, x, y - R, x, y, x + R * Math.Sqrt(2) / 2, y + R * Math.Sqrt(2) / 2);

            return IsBelongToCircle(x, y, xA, yA) && xA >= x && cosAlpha >= cosLimit;
        }

        static void Main(string[] args)
        {
            double x, y, xA, yA;

            do
            {
                Clear();

                do
                {
                    Write("Введите координату x центра круга G: ");
                } while (!double.TryParse(ReadLine(), out x));

                do
                {
                    Write("Введите координату y центра круга G: ");
                } while (!double.TryParse(ReadLine(), out y));

                do
                {
                    Write("Введите координату x точки А: ");
                } while (!double.TryParse(ReadLine(), out xA));

                do
                {
                    Write("Введите координату y точки А: ");
                } while (!double.TryParse(ReadLine(), out yA));

                var result = IsBelongToSector(x, y, xA, yA) ? "Точка принадлежит сектору" : "Точка не принадлежит сектору";
               
                WriteLine(result);

                WriteLine("\nДля выхода нажмите ESC, для продолжения любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
            
        }
    }
}
