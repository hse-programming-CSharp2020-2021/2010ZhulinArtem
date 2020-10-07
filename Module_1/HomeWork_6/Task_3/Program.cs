using System;
using static System.Console;


namespace Task_3
{
    class Program
    {
        static double[] MyFuncSin(uint N)
        {
            var funcSin = new double[N];
            double factorial = 1;
            double sign = 1;
            double firstNumberOfFactorial = 2;
            double secondNumberOfFactorial = 3;

            for (int i = 0; i < funcSin.Length; i++)
            {
                funcSin[i] = sign / factorial;
                factorial *= firstNumberOfFactorial * secondNumberOfFactorial;
                sign *= -1;
                firstNumberOfFactorial += 2;
                secondNumberOfFactorial += 2;
            }

            return funcSin;
        }

        static double MySin(double angle, double[] funcSin)
        {
            double mySin = 0;
            double angle2 = angle;

            foreach (var t in funcSin)
            {
                mySin += t * angle2;
                angle2 *= angle * angle;
            }

            return mySin;
        }

        static void Main(string[] args)
        {
            double angle;
            uint N;

            do
            {
                Clear();
                do
                {
                    Write("Enter value of N: ");
                } while (!uint.TryParse(ReadLine(), out N));

                do
                {
                    Write("Enter value of angle: ");
                } while (!double.TryParse(ReadLine(), out angle));


               
                angle *= Math.PI / 180;
                WriteLine("\tMy sin\t|\tMath sin");
                WriteLine($"\t{MySin(angle, MyFuncSin(N)):G6}\t|\t{Math.Sin(angle):G6}");
                
                WriteLine("\nESC - to exit, other other keys - to continue");
            } while (ReadKey(true).Key!=ConsoleKey.Escape);

        }
    }
}
