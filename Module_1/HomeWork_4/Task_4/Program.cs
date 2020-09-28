using System;
using static System.Console;

namespace Task_4
{
    class Program
    {
        static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0;
            sumOdd = 0;
            while (number > 0)
            {
                sumEven += number % 10;
                number /= 10;
                sumOdd += number % 10;
                number /= 10;
            }
            
        }
        static void Main(string[] args)
        {
            uint number;
            do
            {
                Clear();
                do
                {
                    Write("Enter any natural number: ");
                } while (!uint.TryParse(ReadLine(), out number));

                Sums(number, out var sumEven, out var sumOdd);

                WriteLine($"Sum of digits of even digits: {sumEven}");
                WriteLine($"Sum of digits of odd digits: {sumOdd}");

                WriteLine("Press ESC to exit, any other key to continue ...");
            } while (ReadKey(true).Key!=ConsoleKey.Escape);
            
        }
    }
}
