using System;
using static System.Console;

namespace Task_2
{
    class Circle
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public int Radius { get; set; }

        private const double Eps = 0.00000001;

        public Circle(int xCoord, int yCoord, int radius)
        {
            XCoord = xCoord;
            YCoord = yCoord;
            Radius = radius;
        }

        public static void IsCross(Circle circleFirst, Circle circleSecond)
        {
            var A = 2 * (circleFirst.XCoord - circleSecond.XCoord);
            var B = 2 * (circleFirst.YCoord - circleSecond.YCoord);
            var C = Math.Pow(circleSecond.XCoord, 2) + Math.Pow(circleSecond.YCoord, 2) 
                - Math.Pow(circleFirst.XCoord, 2) - Math.Pow(circleFirst.YCoord, 2) 
                + Math.Pow(circleFirst.Radius, 2) - Math.Pow(circleSecond.Radius, 2);

            var x0 = -A * C / (A * A + B * B) - circleFirst.XCoord;
            var y0 = -B * C / (A * A + B * B) - circleFirst.YCoord;

            if (circleFirst.XCoord == circleSecond.XCoord && circleFirst.YCoord == circleSecond.YCoord)
            {
                WriteLine(circleFirst.Radius == circleSecond.Radius
                    ? "The circles match"
                    : "Circles doesn't cross each other.");
            }
            else if (C * C > Math.Sqrt(circleFirst.Radius) * (A * A + B * B) + Eps)
            {
                WriteLine("Circles doesn't cross each other.");
            }
            else if (Math.Abs(C * C - Math.Sqrt(circleFirst.Radius) * (A * A + B * B)) < Eps)
            {
                WriteLine($"There is only one point ({x0:F2};{y0:F2})");
            }
            else
            {
                var d = Math.Sqrt(circleFirst.Radius) - C * C / (A * A + B * B);
                var mult = Math.Sqrt(d / (A * A + B * B));
                var ax = x0 + B * mult;
                var bx = x0 - B * mult;
                var ay = y0 - B * mult;
                var by = y0 + B * mult;

                WriteLine($"There are two points: A({ax:F2};{ay:F2}) and B({bx:F2};{by:F2})");
            }
        }

        public override string ToString()
        {
            return $"X coordinate: {XCoord} | Y coordinate: {YCoord} | Radius: {Radius}";
        }
    }

    class Program
    {
        private static readonly Random Random = new Random();

        private static void Main(string[] args)
        {
            do
            {
                Clear();

                var specialCircle = GenerateCircles(out var circles);

                CrossCircles(specialCircle, circles);

                WriteLine("\nEsc - to exit, another key to repeat.");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static Circle GenerateCircles(out Circle[] circles)
        {
            var specialCircle = new Circle(Random.Next(-15, 16), Random.Next(-15, 16), Random.Next(0, 16));
            circles = new Circle[Random.Next(1, 15)];

            for (var index = 0; index < circles.Length; index++)
            {
                circles[index] = new Circle(Random.Next(-15, 16), Random.Next(-15, 16), Random.Next(0, 16));
            }

            return specialCircle;
        }

        private static void CrossCircles(Circle specialCircle, Circle[] circles)
        {
            WriteLine("Special circle:");
            WriteLine(specialCircle);
            WriteLine();

            foreach (var circle in circles)
            {
                WriteLine("Circle:");
                WriteLine(circle);
                WriteLine();
                Circle.IsCross(specialCircle, circle);
                WriteLine();
            }
        }
    }
}