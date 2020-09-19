﻿using System;
using static System.Console;

/* Задача 4. 
* Написать метод с целочисленным параметром, определяющий является ли значение аргумента кодом цифры, 
* кодом буквы русского алфавита (прописной либо строчной), или ни тем и ни другим. В основной программе, 
* вводя целые числа, выводить сообщения о них: «Это цифра!», «Это буква!», «Это ни буква, ни цифра!». 
* Для выхода из программы – ESC, для повторения решения - любой символ. При анализе цифрового кода использовать тернарную операцию. 
* Строку сообщения может возвращать метод, либо метод возвращает признак, а строку формирует основная программа 
*/


namespace Task_4
{
    class Program
    {

        /*
         * Метод получает параметр типа uint, в дальнейших операциях преобразует его в тип char, 
         * затем делает проверку на принадлежность данного аргумента к коду цифры или буквы кириллицы 
         * и выводит необходимые сообщения по условию задачи.
         */
        public static void IsNumOrAny(uint x)
        {
            var code = (char) x;
            var str = x >= '0' && x <= '9' ? $"Это цифра: {code}!"
                : x>='А' && x <= 'я' ? $"Это буква: {code}!"
                : "Это ни буква, ни цифра!";
            
            WriteLine(str);
        }

        static void Main(string[] args)
        {
            uint x;
            
            do
            {
                Clear();

                do
                {
                    Write("Введите корректное целочисленное значение: ");
                } while (!uint.TryParse(ReadLine(), out x));

                IsNumOrAny(x);

                WriteLine("\nДля выхода нажмите ESC для продолжение - любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
