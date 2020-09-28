using System;
using static System.Console;

namespace Task_7
{
    class Program
    {
        static void DividerAndMultiple(uint a,uint b, out int divider, out int multiple)
        {
            multiple = (int) (a * b);

            while (a != 0 && b != 0)
                if (a > b)
                    a = a % b;
                else
                    b = b % a;

            divider = (int) (a + b);
            multiple /= divider;
        }
        static void Main(string[] args)
        {
            uint a,b;
            do
            {
                Clear();
                do
                {
                    Write("Enter value of A: ");
                } while (!uint.TryParse(ReadLine(), out a));

                do
                {
                    Write("Enter value of B: ");
                } while (!uint.TryParse(ReadLine(), out b));

                DividerAndMultiple(a, b, out int divider, out int multiple);

                WriteLine("\tA\t|\tB\t|\tDivider\t|\tMultiple");
                WriteLine($"\tA\t|\tB\t|\t{divider}\t|\t{multiple}");



                WriteLine("\nPress ESC to exit, any other key to continue ...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
