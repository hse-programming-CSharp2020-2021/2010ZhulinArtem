using System;

namespace IndepWork_2
{
    class Program
    {
        public static void SumNegNum(ref int sum)
        {
            Console.Write("Введите свое число: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                sum +=  number < 0 ? number : 0;
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
                while (true)
                {
                    Console.Clear();

                    SumNegNum(ref sum);

                    Console.WriteLine("Для прекращения ввода ESC, для продолжения любую другую клавишу...");
                    if (sum < -999 || Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine($"Сумма отрицательных чисел: {sum}");
                        break;
                    }
                }

                Console.WriteLine("\nДля выхода нажмите ESC, для повтора любую другую клавишу...");
            } while (Console.ReadKey(true).Key!=ConsoleKey.Escape);
            
        }
    }
}
