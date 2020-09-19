using System;
using static System.Console;

namespace Task_4
{
    class Program
    {
        static double Func(double x,out double y)
        {
            return y= x * x;
        }

        static double Square(double y1, double y2,double x, double delta , out double S1)
        {
            return S1 = 0.5 *(y1+y2)*(delta - x) ;
        }
        public static double SquareSum(ref double S0,double S1)
        {
            return S0+=S1;
        }
        static void Main(string[] args)
        {
            double x=0, y1, y2, 
                A,
                delta,
                S1 = 0, S0 = 0;
            do
            { 
                Write("Введите значение А>0: ");
            } while (!double.TryParse(ReadLine(),out A) | A<0);

            do
            {
                Write("Введите значение delta>0: ");
            } while (!double.TryParse(ReadLine(), out delta) | delta < 0);

            for (; x<=A+delta; x += delta)
            {
                Func(x, out y1);
                Func(x, out y2);
                Square(y1,y2,x,x+delta, out S1);
                SquareSum(ref S0, S1);
                ;
            }
            WriteLine(S0);




        }
    }
}
