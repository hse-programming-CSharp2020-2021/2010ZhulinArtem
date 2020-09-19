using System;
using static System.Console;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Write("Введите слова: ");
                var inputStr = ReadLine();

                if (string.IsNullOrEmpty(inputStr))
                {
                    WriteLine("Введены некоректные данные");
                    WriteLine("Для выхода нажмите Enter для продолжение - другую клавишу...");

                    continue;
                }

                var words = inputStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    Write($"{word}!");
                }

                WriteLine("\nДля выхода нажмите Enter для продолжение - другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Enter);
        }
    }
}
