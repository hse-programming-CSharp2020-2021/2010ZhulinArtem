using System;

namespace IndepWork_2
{
    class Program
    {
        public static void SumNegNum(ref int sum, ref int count)
        {
            Console.Write("Введите свое число: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number < 0)
            {
                sum +=  number;
                count++;
            }
            else
            {
                Console.WriteLine("Введены некоректные данные");
            }

        }
        static void Main(string[] args)
        {
            do
            {
                var sum = 0;
                var count = 0;
                while (true)
                {
                    Console.Clear();

                    SumNegNum(ref sum, ref count);

                    Console.WriteLine("Для прекращения ввода ESC, для продолжения любую другую клавишу...");
                    if (sum < -999 || Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine($"Среднее арифметическое отрицательных чисел: {sum * 1.0 / count}");
                        break;
                    }
                }

                Console.WriteLine("\nДля выхода нажмите ESC, для повтора любую другую клавишу...");
            } while (Console.ReadKey(true).Key!=ConsoleKey.Escape);
            
        }
    }
}
