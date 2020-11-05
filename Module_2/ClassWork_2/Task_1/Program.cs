using System;

namespace Task_1
{
    class Circle
    {
        private double _r;

        public Circle()
        {
            R = 1;
        }

        public Circle(double _r)
        {
            R = _r;
        }

        public double R
        {
            get { return _r; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect radius");
                }

                _r = value;
            }
        }

        public double S
        {
            get { return Math.PI * Math.Pow(R, 2); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double rMin, rMax, delta;
            do
            {
                Console.Write("Enter r min: ");
            } while (!double.TryParse(Console.ReadLine(), out rMin));

            do
            {
                Console.Write("Enter r max: ");
            } while (!double.TryParse(Console.ReadLine(), out rMax));

            do
            {
                Console.Write("Enter delta: ");
            } while (!double.TryParse(Console.ReadLine(), out delta));
            
            var circle = new Circle();
            try
            {
                for (; Math.Abs(rMin - rMax) > 0; rMin += delta)
                {
                    circle.R = rMin;
                    Console.WriteLine($"{circle.S:F4}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

        }
    }
}