using System;
using static System.Console;

namespace Task_2
{
    class LatinChar
    {
        private char _char;

        public LatinChar()
        {
            Char = 'a';
        }

        public LatinChar(char _char)
        {
            Char = _char;
        }

        public char Char
        {
            get { return _char; }
            set
            {
                if (value < 'a' || value > 'z')
                {
                    throw new ArgumentException("Incorrect input");
                }

                _char = value;
            }
        }
    }

    class Program
    {
        private static void Main(string[] args)
        {
            char minChar, maxChar;
            try
            {
                Write("Enter min char: ");
                minChar = Convert.ToChar(ReadLine());
                Write("Enter max char: ");
                maxChar = Convert.ToChar(ReadLine());

                var latinChar = new LatinChar();

                for (; minChar <= maxChar; minChar++)
                {
                    latinChar.Char = minChar;
                    WriteLine(latinChar.Char);
                }
            }
            catch (Exception exception)
            {
                WriteLine($"Error: {exception.Message}");
            }

            ReadKey();
        }
    }
}