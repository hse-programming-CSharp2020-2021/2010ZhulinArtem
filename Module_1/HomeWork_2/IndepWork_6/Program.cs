using System;
using System.Text;
using System.Globalization;
using static System.Console;


/*
 * Задача №6
 * Получить от пользователя вещественное значение – бюджет пользователя и целое число – процент бюджета, выделенный на компьютерные игры.
 * Вычислить и вывести на экран сумму в рублях\евро или долларах, выделенную на компьютерные игры.
 * Использовать спецификаторы формата для валют.
 */

namespace IndepWork_6
{
    internal class Program
    {
        /*
         * Метод получает три параметра типа uint(currencu, percent) и double(budget).
         * Проводит операция над параметрами budget и percent.
         * Используя параметр currency, выводит необходимое сообщение.
         */
        public static void Budget(uint currency, double budget, uint percent)
        {
            var budgetGame = budget * percent / 100;

            switch (currency)
            {
                case 1:
                    WriteLine(string.Format(new CultureInfo("en-Us"), "Ваш бюджет на игры:{0:c3}", budgetGame));
                    break;

                case 2:
                    WriteLine(string.Format(new CultureInfo("ru-Ru"), "Ваш бюджет на игры:{0:c3}", budgetGame));
                    break;

                case 3:
                    WriteLine(string.Format(new CultureInfo("fr-Fr"), "Ваш бюджет на игры:{0:c3}", budgetGame));
                    break;
            }
        }

        private static void Main(string[] args)
        {
            uint currency, percent;
            double budget;

            OutputEncoding = Encoding.Unicode;

            do
            {
                Clear();

                do
                {
                    WriteLine("Выберите валюту своего бюджета:");
                    WriteLine("1.$\t2.₽\t3.€");
                } while (!uint.TryParse(ReadLine(), out currency) | (currency < 1) | (currency > 3));

                do
                {
                    Write("Введите размер вашего бюджета: ");
                } while (!double.TryParse(ReadLine(), out budget) | (budget < 0));

                do
                {
                    Write("Введите процент выделенный из вашего бюджета на игры: ");
                } while (!uint.TryParse(ReadLine(), out percent) | (percent > 100));

                Budget(currency, budget, percent);

                WriteLine("\nДля выхода нажмите ESC для продолжение - любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}