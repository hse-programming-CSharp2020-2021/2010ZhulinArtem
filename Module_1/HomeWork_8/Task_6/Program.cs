using System;
using static System.Console;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Clear();

                WriteLine("Write something...");
                var userString = ReadLine();

                FindNumbers(userString, out var intArray);
                Average(intArray, out var average);

                WriteLine(average != null ? $"{average}" : "There are no numbers..");

                WriteLine("\nESC-to continue, other key to continue...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }

        static void FindNumbers(string userString, out int[] intArray)
        {
            char[] splitChars = {' ', '.', ',', ';', '!', '?'};
            var stringArray = userString.Split(splitChars, StringSplitOptions.None);

            intArray = new int[0];
            var index = 0;

            foreach (var element in stringArray)
            {
                if (int.TryParse(element, out int number))
                {
                    Array.Resize(ref intArray, intArray.Length + 1);
                    intArray[index++] = number;
                }
            }
        }

        static void Average(int[] intArray, out double? average)
        {
            if (intArray.Length > 0)
            {
                var sumOfNumber = 0;
                foreach (var number in intArray)
                {
                    sumOfNumber += number;
                }

                average = sumOfNumber / intArray.Length;
            }
            else
            {
                average = null;
            }
        }
    }
}