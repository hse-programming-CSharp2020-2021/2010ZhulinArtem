using System;
using static System.Console;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Write("Введите значение x:");
                var xTryParse = int.TryParse(ReadLine(), out var x);

                Write("Введите значение y:");
                var yTryParse = int.TryParse(ReadLine(), out var y);

                if (!xTryParse || !yTryParse)
                {
                    WriteLine("Введены не корректные данные");
                    WriteLine("Для выхода нажмите Enter для продолжение - другую клавишу...");

                    continue;
                }

                WriteLine($"Значение x-y: {x - y}");
                WriteLine($"Значение x*y: {x * y}");
                WriteLine($"Значение x/y: {x / y:F4}");
                WriteLine($"Значение x%y: {x % y}");
                WriteLine($"Значение x<<y: {x << y}");
                WriteLine($"Значение x>>y: {x >> y}");

                WriteLine("Для выхода нажмите Enter для продолжение - другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Enter);
        }
    }
}
