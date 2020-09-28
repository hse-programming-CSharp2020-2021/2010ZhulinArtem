using System;
using static System.Console;

namespace Task_6
{
    class Program
    {
        static double Factorial(int i)
        {
            if (i>0)
            {
                return i * Factorial(i-1);
            }
            return 1;
        }
        static double FuncFirst(double x)
        {
            double oldvalue = -1;
            double nowvalue = 0;
            for (int i = 1; oldvalue - nowvalue != 0.0; i++)
            {
                oldvalue = nowvalue;
                nowvalue += Math.Pow(-1, i - 1) *Math.Pow(2,2*i-1)*Math.Pow(x,2*i)/Factorial(i*2);
            }

            return nowvalue;
        }

        static double FuncSecond(double x)
        {
            double oldvalue = -1;
            double nowvalue = 1;
            for (int i = 1; oldvalue != nowvalue; i++)
            {
                oldvalue = nowvalue;
                nowvalue += Math.Pow(x, i) / Factorial(i);
            }

            return nowvalue;
        }
        static void Main(string[] args)
        {
            double x;
            do
            {
                Clear();
                do
                {
                    Write("Enter value of x: ");
                } while (!double.TryParse(ReadLine(), out x));

                WriteLine("Value\t|\tFuncFirst\t|\tFuncSecond");

                WriteLine($"{x}\t|\t{FuncFirst(x):G4}\t\t|\t{FuncSecond(x):G4}");
                //WriteLine($"{x}\t|\t\t\t|\t{FuncSecond(x):G4}");
                

                WriteLine("\nPress ESC to exit, any other key to continue ...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}