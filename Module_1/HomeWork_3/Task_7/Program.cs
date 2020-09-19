using System;
using static System.Console;

/*
 * Задание №1
 */
namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            uint grade;
            do
            {
                Clear();

                Write("Введите свою оценку(0-10): ");
                while (!uint.TryParse(ReadLine(), out grade) | grade>10)
                {
                    WriteLine("Введены некорректные данные. Попробуйте снова.");
                    Write("Введите свою оценку(0-10): ");
                }

                switch (grade)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        WriteLine($"Ваша оценка {grade} - неудовлетворительно");
                        break;
                    case 4:
                    case 5:
                        WriteLine($"Ваша оценка {grade} - удовлетворительно");
                        break;
                    case 6:
                    case 7:
                        WriteLine($"Ваша оценка {grade} - хорошо");
                        break;
                    case 8:
                    case 9:
                    case 10:
                        WriteLine($"Ваша оценка {grade} - отлично");
                        break;
                }

                WriteLine("\nДля выхода нажмите ESC, для продолжения - любую другую...");
            } while (ReadKey(false).Key!=ConsoleKey.Escape);
        }
    }
}
