using System;

namespace Task_3
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point() : this(0, 0)
        {
        } // конструктор умолчания

        // СВОЙСТВО RO
        // СВОЙСТВО FI
        public string PointData
        {
            // СВОЙСТВО 
            get
            {
                string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                return string.Format(maket, X, Y, Ro, Fi);
            }
        }

        public double Ro => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));

        public double Fi
        {
            get { return HelpMethodFi(); }
        }

        private double HelpMethodFi()
        {
            if (X > 0 && Y > 0)
            {
                return Math.Atan(Y / X);
            }
            else if (X > 0 && Y < 0)
            {
                return Math.Atan(Y / X) + 2 * Math.PI;
            }
            else if (X < 0)
            {
                return Math.Atan(Y / X) + Math.PI;
            }
            else if (X == 0 && Y > 0)
            {
                return Math.PI / 2;
            }
            else if (X == 0 && Y < 0)
            {
                return 3 * Math.PI / 2;
            }

            return 0;
        }
    }

    class Programm
    {
        static void Main()
        {
            Point a, b, c;
            a = new Point(3, 4);
            b = new Point(0, 3);
            c = new Point();
            double x = 0, y = 0;
            bool xBooTryParse;
            bool yBoolTryParse;
            do
            {
                Console.Write("x = ");
                xBooTryParse = double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                yBoolTryParse = double.TryParse(Console.ReadLine(), out y);
                c.X = x;
                c.Y = y;
            } while (!xBooTryParse && yBoolTryParse);

            Point[] points = {a, b, c};
            double max = Math.Max(Math.Max(a.Ro, b.Ro), c.Ro);
            double min = Math.Min(Math.Min(a.Ro, b.Ro), c.Ro);
            double avg = a.Ro + b.Ro + c.Ro - max - min;
            double[] ro = {min, avg, max};
            for (int i = 0; i < ro.Length; i++)
            {
                for (int j = 0; j < points.Length; j++)
                {
                    if (points[j].Ro == ro[i])
                    {
                        Console.WriteLine(points[j].PointData);
                    }
                }
            }
        }
    }
}