using System;
using static System.Console;

namespace IndepWork_4
{
    class Program
    {
        static public int Multiple(int M, int N)
        {
            return (2 << N-1) + (2 << M-1);
        }
        static void Main(string[] args)
        {
            int M,N;
            do
            {
                Clear();

                do
                {
                    Write("Введите значение N: ");
                } while (!int.TryParse(ReadLine(), out N));
                do
                {
                    Write("Введите значение M: ");
                } while (!int.TryParse(ReadLine(), out M));
                
                Clear();

                WriteLine($"2^{N} + 2^{M} = {Multiple(M,N)}");

                WriteLine("\nДля выхода нажмите ESC, для продолжения любую дргую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
