using System;

namespace Task_4
{
    class TestClass
    {
        public class Shape
        {
            public const double PI = Math.PI;
            protected double x, y;

            public Shape()
            {
            }

            public Shape(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public virtual double Area()
            {
                return x * y;
            }
        }

        public class Circle : Shape
        {
            public Circle(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                return PI * x * x;
            }

            public override string ToString()
            {
                return "CIRCLE";
            }
        }

        class Sphere : Shape
        {
            public Sphere(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                return 4 * PI * x * x;
            }

            public override string ToString()
            {
                return "Sphere";
            }
        }

        class Cylinder : Shape
        {
            public Cylinder(double r, double h) : base(r, h)
            {
            }

            public override double Area()
            {
                return 2 * PI * x * x + 2 * PI * x * y;
            }

            public override string ToString()
            {
                return "CYLINDER";
            }
        }

        private static readonly Random Random = new Random();

        private static void Main()
        {
            var shapes = GenerateShapes();

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }

            Array.Sort(shapes,
                (a, b) => string.Compare(a.GetType().FullName, b.GetType().FullName, StringComparison.Ordinal));

            Console.WriteLine("\nSorted array:");
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }

        private static Shape[] GenerateShapes()
        {
            var shapes = new Shape[Random.Next(3, 11)];
            for (var i = 0; i < shapes.Length; i++)
            {
                var type = Random.Next(0, 3);
                shapes[i] = type switch
                {
                    2 => new Sphere(Random.NextDouble() * 21 + 1),
                    1 => new Cylinder(Random.NextDouble() * 21 + 1, Random.NextDouble() * 21 + 1),
                    _ => new Circle(Random.NextDouble() * 21 + 1)
                };
            }

            return shapes;
        }
    }
}