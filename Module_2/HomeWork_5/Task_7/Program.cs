using System;
using System.Globalization;
using System.Linq;

namespace Task_7
{
    public abstract class Dimensions
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        public abstract double Area { get; }

        protected Dimensions(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract string Description();

        public void Change(int k)
        {
            X *= k;
            Y *= k;
        }
    }

    public class Ellipse : Dimensions
    {
        public Ellipse(int x, int y) : base(x, y) { }

        public override double Area => Math.PI * X * Y / 4;
        public override string Description()
        {
            return $"Ellipse: x = {X}, y = {Y}, area = {Area:F2}";
        }
    }

    public class Triangle : Dimensions
    {
        public Triangle(int x, int y) : base(x, y) { }

        public override double Area =>  X * Y / 2.0;
        public override string Description()
        {
            return $"Triangle: x = {X}, y = {Y}, area = {Area:F2}";
        }
    }

    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public virtual double Area => -1;

        public virtual string Display()
        {
            return $"X = {X}; Y ={Y}; ";
        }
    }

    internal class Circle : Point
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect input.");
                }

                _radius = value;
            }
        }

        public override double Area => Math.PI * Math.Pow(Radius, 2);

        public double Len => 2 * Math.PI * Radius;

        public Circle(Point point, double radius)
        {
            X = point.X;
            Y = point.Y;
            Radius = radius;
        }

        public override string Display()
        {
            return base.Display() + $"Radius: {Radius:F2}; Len: {Len:F2}; Square: {Area:F2}";
        }
    }

    internal class Square : Point
    {
        private double _side;

        public double Side
        {
            get => _side;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect input.");
                }

                _side = value;
            }
        }

        public double Len => Side * 4;

        public override double Area => Side * Side;

        public Square(Point point, double side)
        {
            X = point.X;
            Y = point.Y;
            Side = side;
        }

        public override string Display()
        {
            return base.Display() + $"Side: {Side:F2}; Len: {Len:F2}; Square: {Area:F2}";
        }
    }

    internal class Program
    {
        private static readonly Random Random = new Random();

        private static void Main(string[] args)
        {
            var arrayPoints = FigArray();
            var circleNumber = arrayPoints.Where(pointCircle => pointCircle is Circle).ToArray().Length;
            var squareNumber = arrayPoints.Where(pointCircle => pointCircle is Square).ToArray().Length;

            Console.WriteLine($"Num of circle objects: {circleNumber}; Num of square objects: {squareNumber}");
            foreach (var point in arrayPoints)
            {
                Console.WriteLine(point.Display());
            }

            arrayPoints = arrayPoints.OrderBy(point => point.Area).ToArray();
            Console.WriteLine("Sorted:");
            foreach (var point in arrayPoints)
            {
                Console.WriteLine(point.Display());
            }

            var dimensions = GenerateDimensions();

            Console.WriteLine("Dimension array:");

            foreach (var dimension in dimensions)
            {
                Console.WriteLine(dimension);
            }

            Console.WriteLine("Enter any key...");
            Console.ReadKey();
        }

        private static Point[] FigArray()
        {
            var array = new Point[Random.Next(3, 11)];
            for (var i = 0; i < array.Length; i++)
            {
                try
                {
                    var point = new Point() {X = Random.Next(-10, 11), Y = Random.Next(-10, 11)};
                    if (Random.Next(0, 2) == 0)
                    {
                        array[i] = new Circle(point, Random.NextDouble() * (1000 - 10) + 10);
                    }
                    else
                    {
                        array[i] = new Square(point, Random.NextDouble() * (1000 - 10) + 10);
                    }
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                    i--;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    i--;
                }
            }

            return array;
        }

        private static Dimensions[] GenerateDimensions()
        {
            var dimensions = new Dimensions[Random.Next(3,15)];
            for (var i = 0; i < dimensions.Length; i++)
            {
                if (Random.Next(0, 2) == 0)
                {
                    dimensions[i] = new Triangle(Random.Next(-10, 10), Random.Next(-10, 10));
                }
                else
                {
                    dimensions[i] = new Ellipse(Random.Next(-10, 10), Random.Next(-10, 10));
                }

                dimensions[i].Change(Random.Next(1, 5));
            }

            return dimensions;
        }
    }
}