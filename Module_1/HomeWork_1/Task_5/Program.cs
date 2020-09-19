using System;
using static System.Console;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Write("Введите значение катета a: ");
                var aTryParse = double.TryParse(ReadLine(), out var a);

                Write("Введите значение катета b: ");
                var bTryParse = double.TryParse(ReadLine(), out var b);

                if (aTryParse && bTryParse)
                {
                    WriteLine($"Длина гипотенузы с = {Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)):F4}");
                }
                else
                {
                    WriteLine("Введены не корректные данные, попробуйте в следующий раз.");
                }

                WriteLine("Для выхода нажмите Enter для продолжения нажмите другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Enter);
        }
    }
}