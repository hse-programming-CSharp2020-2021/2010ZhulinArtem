using System;
using static System.Console;

namespace Task_1
{
    internal class GeometricProgression
    {
        private double _start;
        private double _increment;

        public GeometricProgression()
        {
        }

        public GeometricProgression(double start, double increment)
        {
            _start = start;
            _increment = increment;
        }

        public double this[int index] => Math.Round(_start * Math.Pow(_increment, index), 2);

        public override string ToString()
        {
            return $"Start: {_start}  Increment: {_increment}";
        }

        public double GetSum(int n)
        {
            var sum = 0d;
            for (var i = 0; i < n + 1; i++)
            {
                sum += this[i];
            }

            return Math.Round(sum, 2);
        }
    }

    internal class Program
    {
        private static readonly Random Random = new Random();
        private const double Eps = 0.00000001;


        private static void Main()
        {
            do
            {
                var geomProgression = GenerateGeometricProgression(out var geomProgressionArray);

                var step = Random.Next(3, 15);
                LargerThan(step, geomProgression, geomProgressionArray);

                SumOfFirst(geomProgressionArray, step);

                WriteLine("\nEsc - to exit, another key to repeat.");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
            
        }

        private static GeometricProgression GenerateGeometricProgression(out GeometricProgression[] geomProgressionArray)
        {
            var geomProgression = new GeometricProgression(GenerateDouble(Random.Next(1, 3), Random.Next(3, 6)),
                GenerateDouble(Random.Next(1, 3), Random.Next(3, 6)));

            geomProgressionArray = new GeometricProgression[Random.Next(5, 16)];

            for (var i = 0; i < geomProgressionArray.Length; i++)
            {
                geomProgressionArray[i] = new GeometricProgression(GenerateDouble(0, 10), GenerateDouble(0, 5));
            }

            return geomProgression;
        }

        private static void SumOfFirst(GeometricProgression[] geomProgressionArray, int step)
        {
            foreach (var geomProgress in geomProgressionArray)
            {
                WriteLine($"Progression: {geomProgress}");

                WriteLine($"Sum of first {step} elements: {geomProgress.GetSum(step)}");
            }
        }

        private static void LargerThan(int step, GeometricProgression geomProgression,
            GeometricProgression[] geomProgressionArray)
        {
            var flag = true;

            WriteLine($"Geometric progression element {step} larger than {geomProgression[step]}.\n");
            foreach (var geomProgress in geomProgressionArray)
            {
                if (Math.Abs(geomProgress[step] - geomProgression[step]) < Eps)
                {
                    WriteLine(geomProgress);
                    flag = false;
                }
            }

            if (flag)
            {
                WriteLine($"There are no progression with element {step} larger than {geomProgression[step]}");
            }
        }

        private static double GenerateDouble(int min, int max)
        {
            return Math.Round(Random.NextDouble() * (max - min) + min, 2);
        }
    }
}