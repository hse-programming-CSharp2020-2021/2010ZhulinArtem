using System;

/*
 * Задание №2
 */

namespace Task_8
{
    class Program
    {
        //Проверка на истинность
        public static bool Function(bool p, bool q)
        {
            return !(p & q) & !(p | !q);
        }
        static void Main()
        {
            bool p = true, q, res;
            do
            {
                Console.WriteLine("Таблица истинности !(p & q) & !(p | !q)");
                Console.WriteLine(" p \t q \t F");
                do
                {
                    q = true;
                    do
                    {
                        res = Function(p, q); // Вызов Function()
                        Console.WriteLine($"{p}\t{q}\t{res}");
                        q = !q;
                    } while (!q);

                    p = !p;
                } while (!p);

                Console.WriteLine("\nДля выхода нажмите ESC, для продолжения любую другую клавишу...");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            
        }
    }
}
