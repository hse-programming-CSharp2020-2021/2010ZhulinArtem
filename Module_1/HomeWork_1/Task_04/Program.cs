using System;
using static System.Console;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Write("Введите значение напряжения U: ");
                var voltageTryParse = double.TryParse(ReadLine(), out var voltage);

                Write("Введите значение сопротивления R: ");
                var resistanceTryParse = double.TryParse(ReadLine(), out var resistance);

                if (voltageTryParse && resistanceTryParse)
                {
                    WriteLine($"Сила тока I = {voltage/resistance:F4} (А)");    
                    WriteLine($"Мощность P = {Math.Pow(voltage,2)/resistance:F4} (Вт)");    
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
