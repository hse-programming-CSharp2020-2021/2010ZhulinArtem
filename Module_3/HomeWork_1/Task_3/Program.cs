using System;
using System.Collections.Generic;

namespace Task_3
{
    internal class TemperatureConverterImp
    {
        public double ConvertCToF(double temperature) => 9 * temperature / 5 + 32;
        public double ConvertFToC(double temperature) => 5 * (temperature - 32) / 9;
    }

    internal class StaticTempConverters
    {
        public static double ConvertCToK(double temperature) => temperature + 273.15;
        public static double ConvertKToC(double temperature) => temperature - 273.15;

        public static double ConvertCToRan(double temperature) => (temperature + 273.15) * 9 / 5;
        public static double ConvertRanToC(double temperature) => (temperature - 491.67) * 5 / 9;

        public static double ConvertCToRea(double temperature) => temperature * 4 / 5;
        public static double ConvertReaToC(double temperature) => temperature * 5 / 4;
    }

    internal class Program
    {
        private delegate double DelegateConvertTemperature(double temperature);

        private static readonly Random Random = new Random();

        private static void Main()
        {
            TestDelegateFirst();
            Console.WriteLine();
            TestDelegateSecond();
        }

        private static void TestDelegateFirst()
        {
            DelegateConvertTemperature delegateConvert = new TemperatureConverterImp().ConvertCToF;
            delegateConvert += new TemperatureConverterImp().ConvertFToC;

            var temperature = Random.NextDouble() * 100;
            Console.WriteLine($"Temperature: {temperature:F2}");

            foreach (DelegateConvertTemperature converter in delegateConvert.GetInvocationList())
            {
                Console.WriteLine(
                    $"Result: {converter?.Invoke(temperature):F2}; " +
                    $"Method: {converter?.Method}; Target: {converter?.Target}"
                    );
            }
        }

        private static void TestDelegateSecond()
        {
            var delegateConverters = new List<DelegateConvertTemperature> { new TemperatureConverterImp().ConvertCToF, 
                new TemperatureConverterImp().ConvertFToC };  

            delegateConverters.AddRange(new List<DelegateConvertTemperature>
            {
                StaticTempConverters.ConvertCToK, StaticTempConverters.ConvertKToC,
                StaticTempConverters.ConvertCToRan, StaticTempConverters.ConvertRanToC,
                StaticTempConverters.ConvertCToRea, StaticTempConverters.ConvertReaToC
            });

            double temperature;

            do
            {
                Console.Write("Enter the correct number: ");
            } while (!double.TryParse(Console.ReadLine(), out temperature) || temperature < -273 || temperature > 1000);

            foreach (var converter in delegateConverters)
            {
                Console.WriteLine($"Result: {converter?.Invoke(temperature):F2}; Method: {converter?.Method}");
            }
        }
    }
}