using System;
using static System.Console;

/* 
 * Задача №5. 
 * Ввести трехзначное натуральное число и напечатать его цифры "столбиком".
*/


namespace Task_5
{
    class Program
    {
        /*
         * Метод принимает параметр типа string и выводит его элементы "столбиком"
         */
        public static void Column(string number)
        {
            foreach (var digit in number)
            {
                WriteLine(digit);                
            }
        }

        static void Main(string[] args)
        {
            int x;

            do
            {
                Clear();   

                do
                {
                    Write("Введите корректное трехзначное число: ");
                } while (!int.TryParse(ReadLine(), out x) | x < 100 | x > 999);

                Column(x.ToString());

                WriteLine("\nДля выхода нажмите ESC для продолжение - любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
