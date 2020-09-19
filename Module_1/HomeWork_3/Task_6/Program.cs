using System;
using static System.Console;

/*
 * Задача №6
 * Трехзначным целым числом кодируется номер аудитории в учебном корпусе.
 * Старшая цифра обозначают номер этажа, а две младшие –  номер аудитории на этаже.
 * Из трех аудиторий определить и вывести на экран ту аудиторию, которая имеет минимальный номер внутри этажа.
 * Если таких аудиторий несколько - вывести любую из них. 
 */

namespace Task_6
{
    class Program
    {
        //Метод сравнивает номера аудиторий на этаже и выводит минимальную аудиторию
        public static void MinAuditory(uint audit1, uint audit2, uint audit3)
        {
            var cab1 = audit1 % 100;
            var cab2 = audit2 % 100;
            var cab3 = audit3 % 100;

            if (cab1 == Math.Min(Math.Min(cab1, cab2), cab3))
            {
                WriteLine("Аудитория с меньшим номером на этаже: " + audit1);
            }
            else if (cab2 == Math.Min(Math.Min(cab1, cab2), cab3))
            {
                WriteLine("Аудитория с меньшим номером на этаже: " + audit2);
            }
            else
            {
                WriteLine("Аудитория с меньшим номером на этаже: " + audit3);
            }
        }
        static void Main(string[] args)
        {
            uint audit1, audit2, audit3;
            do
            {
                Clear();

                Write("Введите номер первой аудитории: ");
                while (!uint.TryParse(ReadLine(), out audit1) | audit1 / 100 == 0)
                {
                    WriteLine("Введены некоректные данные. Попробуйте снова.");
                    Write("Введите номер первой аудитории: ");
                }

                Write("Введите номер второй аудитории: ");
                while (!uint.TryParse(ReadLine(), out audit2) | audit2 / 100 == 0)
                {
                    WriteLine("Введены некоректные данные. Попробуйте снова.");
                    Write("Введите номер второй аудитории: ");
                }

                Write("Введите номер третий аудитории: ");
                while (!uint.TryParse(ReadLine(), out audit3) | audit3 / 100 == 0)
                {
                    WriteLine("Введены некоректные данные. Попробуйте снова.");
                    Write("Введите номер третий аудитории: ");
                }

                MinAuditory(audit1,audit2,audit3);

                WriteLine("\nДля выхода нажмите ESC, для продолжения любую другую клавишу...");
            } while (ReadKey(true).Key!=ConsoleKey.Escape);
            

        }
    }
}
