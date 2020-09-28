using System;
using static System.Console;

namespace IndepWork_1
{
    class Program
    {
        public static void PrintFunc(int a, int b, int c)
        {
            WriteLine($"\t{a}\t|\t{b}\t|\t{c}\t|\t{a}^2 + {b}^2 = {c}^2");
        }
        public static void Func()
        {
            for (int i = 1; i < 21; i++)
            {
                for (int j = 1; j < 21; j++)
                {
                    for (int k = 1; k < 21; k++)
                    {
                        if (i*i+j*j==k*k)
                        {
                            PrintFunc(i, j, k);
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            do
            {
                Clear();

                WriteLine("*- - - - - - - -|- - - - - - - -|- - - - - - - -|- - - - - - - - - - - - -*");
                WriteLine("\ta\t|\tb\t|\tc\t|\ta^2 + b^2 = c^2");
                WriteLine("*- - - - - - - -|- - - - - - - -|- - - - - - - -|- - - - - - - - - - - - -*");

                Func();

                WriteLine("\nДля выхода нажмите ESC, для продолжения любую дргую клавишу...");
            } while (ReadKey(true).Key!=ConsoleKey.Escape);
        }
    }
}
