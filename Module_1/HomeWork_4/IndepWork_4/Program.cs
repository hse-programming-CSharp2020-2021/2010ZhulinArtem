using System;
using static System.Console;

namespace IndepWork_4
{
    class Program
    {
        static public int Multiple(uint M, uint N)
        {
            var firstNumber = N == 0 ? 1 : 2 << (int) N - 1;
            var secondNumber = M == 0 ? 1 : 2 << (int) M - 1;
            return firstNumber + secondNumber;
        }
        static void Main(string[] args)
        {
            uint M,N;
            do
            {
                Clear();

                do
                {
                    Write("Введите значение N: ");
                } while (!uint.TryParse(ReadLine(), out N));
                do
                {
                    Write("Введите значение M: ");
                } while (!uint.TryParse(ReadLine(), out M));
                
                Clear();

                WriteLine($"2^{N} + 2^{M} = {Multiple(M,N)}");

                WriteLine("\nДля выхода нажмите ESC, для продолжения любую дргую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
