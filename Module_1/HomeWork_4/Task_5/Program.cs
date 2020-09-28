using System;
using static System.Console;

namespace Task_5
{
    class Program
    {
        static double Sum(uint k)
        {
            double sum = 0;
            for (int i = 1; i < k + 1; i++)
            {
                sum += (k + 0.3) / (3 * k * k + 5);
            }

            return sum;
        }
        static void Main(string[] args)
        {
            uint k;
            do
            {
                Clear();
                do
                {
                    Write("Enter value of k: ");
                } while (!uint.TryParse(ReadLine(), out k));

                WriteLine("n\t|\tSn");

                for (uint i = 1; i < k + 1; i++)
                {
                    WriteLine($"{i}\t|\t{Sum(i):G4}");
                }


                WriteLine("\nPress ESC to exit, any other key to continue ...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
