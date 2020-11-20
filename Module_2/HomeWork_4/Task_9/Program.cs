using System;
using System.Linq;

namespace Task_9
{
    internal class LinearEquation
    {
        private readonly int _a;
        private readonly int _b;
        private readonly int _c;

        public double X => (_c - _b)*1.0 / _a;

        public LinearEquation(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override string ToString()
        {
            return $"Root: {X:F2}; A: {_a}; B: {_b}; C: {_c}";
        }
    }

    internal class Program
    {
        private static readonly Random Random = new Random();

        private static void Main()
        {
            do
            {
                try
                {
                    Console.Write("Enter N: ");
                    var linearEquations =
                        GenerateLinearEquations(int.Parse(Console.ReadLine()!));

                    foreach (var linearEquation in linearEquations)
                    {
                        Console.WriteLine(linearEquation);
                    }

                    linearEquations =  linearEquations.OrderBy(linearEquation => linearEquation.X).ToArray();
                    
                    Console.WriteLine("Sorted array:");
                    foreach (var linearEquation in linearEquations)
                    {
                        Console.WriteLine(linearEquation);
                    }

                    Console.ReadKey();
                    return;

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            } while (true);
        }

        private static LinearEquation[] GenerateLinearEquations(int n)
        {
            var linearEquations = new LinearEquation[n];
            for (var i = 0; i < linearEquations.Length; i++)
            {
                linearEquations[i] = new LinearEquation(Random.Next(-10, 11),
                    Random.Next(-10, 11), Random.Next(-10, 11));
            }

            return linearEquations;
        }
    }
}