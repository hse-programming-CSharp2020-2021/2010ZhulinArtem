using System;
using static System.Console;

/*
 * Задача№2
 * Написать метод, преобразующий число переданное в качестве параметра в число, записанное теми же цифрами, но идущими в обратном порядке. 
 */

namespace Task_2
{
    internal class Program
    {
        //Метод преобразует число в строку и выводит символы, полученной строки в обратном порядке
        public static void NumBack(ref int num)
        {
            var input = num.ToString();
            var output = "";
            for (var i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }

            int.TryParse(output, out num);
        }

        private static void Main(string[] args)
        {
            int num;
            do
            {
                Write("Введите корректное число: ");
            } while (!int.TryParse(ReadLine(), out num));

            NumBack(ref num);
            WriteLine($"В обратном порядке: {num}");
        }
    }
}