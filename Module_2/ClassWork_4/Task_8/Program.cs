using System;
using System.Security.Cryptography.X509Certificates;

namespace Task_8
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Triangle
    {
        private Point _aPoint;
        private Point _bPoint;
        private Point _cPoint;

        private int AB => LengthOfSide(_aPoint, _bPoint);
        private int AC => LengthOfSide(_aPoint, _cPoint);
        private int BC => LengthOfSide(_bPoint, _cPoint);

        public Point FirstPoint
        {
            get => _aPoint;
            set => _aPoint = value;
        }

        public Point SecondPoint
        {
            get => _bPoint;
            set => _bPoint = value;
        }

        public Point ThirdPoint
        {
            get => _cPoint;
            set => _cPoint = value;
        }


        public Triangle()
        {
        }

        public Triangle(int firstX, int firstY, int secondX, int secondY, int thirdX, int thirdY)
        {
            FirstPoint = new Point {X = firstX, Y = firstY};
            SecondPoint = new Point {X = secondX, Y = secondY};
            ThirdPoint = new Point {X = thirdX, Y = thirdY};
        }

        public Triangle(Point first, Point second, Point third)
        {
            FirstPoint = first;
            SecondPoint = second;
            ThirdPoint = third;
        }

        public int GetPerimeter => AB + AC + BC;

        public int GetSquare => (int) Math.Sqrt(GetPerimeter / 2 * (GetPerimeter / 2 - AB)
                                                                 * (GetPerimeter / 2 - AC) * (GetPerimeter / 2 - BC));

        private static int LengthOfSide(Point a, Point b)
        {
            return (int) Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }


    class Program
    {
        private static Random Random = new Random();
        private static void Main(string[] args)
        {
        }

        private static Triangle[] GenerateTriangles()
        {
            var triangleArray = new Triangle[Random.Next(5,16)];
            for (var i = 0; i < triangleArray.Length; i++)
            {
                var pointArray = new Point[3];
                for (var j = 0; j < 3; j++)
                {

                }
                triangleArray[i] = new Triangle();
            }
        }
    }
}