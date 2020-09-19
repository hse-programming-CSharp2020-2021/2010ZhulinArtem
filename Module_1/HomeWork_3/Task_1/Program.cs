using System;
using static System.Console;

/*
 * Задача №1
 * Написать метод, находящий трехзначное десятичное число s,
 * все цифры которого одинаковы и которое представляет собой сумму первых членов натурального ряда, то есть s = 1+2+3+4+…
 * Вывести полученное число, количество членов ряда и условное изображение соответствующей суммы,
 * в которой указаны первые три и последние три члена, а средние члены обозначены многоточием.
 * Например, если последний член равен 25, то вывести: 1+2+3+…+23+24+25.
 */

namespace Task_1
{
    internal class Program
    {
        //Метод проверяет является ли число суммой арифметической последовательности
        public static int Check(int num, out int i)
        {
            var numcheck = 0;

            for (i = 0; numcheck < num; i++) numcheck += i;
            return numcheck;
        }

        //Метод создает число и проверяет его на условия задачи, используя метод Check
        public static void FindNum()
        {
            for (var i = 1; i < 10; i++)
            {
                var num = i * 111;
                if (num == Check(num, out var count))
                {
                    Write($"{num} = ");
                    if (count > 6)
                        for (var j = 1; j < count; j++)
                        {
                            if (j > 3 && j < count - 3)
                            {
                                if (j == 4) Write("... + ");
                                continue;
                            }

                            if (j == count-1)
                                WriteLine(j);
                            else
                                Write(j + " + ");
                        }
                    else
                        for (var j = 1; j < count; j++)
                            if (j == count - 1)
                                WriteLine(j);
                            else
                                Write(j + " + ");
                }
            }
        }

        private static void Main(string[] args)
        {
            FindNum();
        }
    }
}