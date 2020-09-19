using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int code;
            
            do
            {
                Console.WriteLine("Введите число от 32 до 127:");
                
                var resultTryParse = int.TryParse(Console.ReadLine(), out code);

                if (resultTryParse && code >= 32 && code <= 127)
                {
                    Console.WriteLine((char)code);
                }
                else
                {
                    Console.WriteLine("Введены не корректные данные, попробуйте в следующий раз.");
                }

                Console.WriteLine("Для выхода нажмите Enter для продолжения нажмите другую клавишу...");
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
        }
    }
}
