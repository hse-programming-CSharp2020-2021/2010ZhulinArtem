using System;
using static System.Console;

namespace Task_3
{
    class Polygon
    {
        private int _numberOfSides;
        private double _radius;

        public int NumberOfSides
        {
            get => _numberOfSides;
            set
            {
                if (value.GetType() != typeof(int) || value < 0)
                {
                    throw new ArgumentException("Incorrect input.");
                }

                _numberOfSides = value;
            }
        }

        public double Radius
        {
            get => _radius;
            set
            {
                if (value.GetType() != typeof(double) || value < 0)
                {
                    throw new ArgumentException("Incorrect input.");
                }

                _radius = value;
            }
        }

        public double Perimeter => NumberOfSides * 2 * Radius * Math.Tan(Math.PI / NumberOfSides);
        public double Square => NumberOfSides * Math.Pow(Radius, 2) * Math.Tan(Math.PI / NumberOfSides);

        public void PolygonData()
        {
            WriteLine($"Number of side: {NumberOfSides}");
            WriteLine($"Inscribed circle radius: {Radius} cm");
            WriteLine($"Perimeter: {Perimeter:F4} cm");
            WriteLine($"Square: {Square:F4} cm^2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            try
            {
                var polygon = new Polygon();

                Write("Enter number of side: ");
                polygon.NumberOfSides = int.Parse(ReadLine());

                Write("Enter inscribed circle radius: ");
                polygon.Radius = double.Parse(ReadLine());

                polygon.PolygonData();
            }
            catch (Exception exception)
            {
                WriteLine($"Error: {exception.Message}");
                WriteLine("Try again.Enter any key...");
                ReadKey();
                Clear();
                MainMenu();
            }
        }
    }
}