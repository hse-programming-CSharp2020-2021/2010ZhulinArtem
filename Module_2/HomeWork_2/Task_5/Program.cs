using System;
using static System.Console;

namespace Task_5
{
    class ConsolePlate
    {
        private char _plateChar;
        private ConsoleColor _plateColor;

        public char PlateChar
        {
            get => _plateChar;
            set
            {
                if (value > 31)
                {
                    _plateChar = value;
                }
                else
                {
                    _plateChar = '+';
                }
            }
        }

        public ConsoleColor PlateColor { get=>_plateColor;
            set => _plateColor = value;
        }

        public ConsolePlate()
        {
            PlateChar = '+';
            PlateColor = ConsoleColor.White;
        }
        public ConsolePlate(char plateChar, ConsoleColor plateColor)
        {
            PlateChar = plateChar;
            PlateColor = plateColor;
        }
    }

    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            ConsoleColor[] consoleColors =
            {
                ConsoleColor.White, ConsoleColor.Yellow, ConsoleColor.Magenta,
                ConsoleColor.Cyan, ConsoleColor.DarkBlue, ConsoleColor.DarkCyan,
                ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta,
                ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.Gray
            };
            var consolePlates = new ConsolePlate[10];
            for (var i = 0; i < consolePlates.Length; i++)
            {
                consolePlates[i] = new ConsolePlate((char)random.Next(1,'~'),consoleColors[random.Next(0,consoleColors.Length)]);
            }

            foreach (var consolePlate in consolePlates)
            {
                BackgroundColor = consoleColors[random.Next(0,consoleColors.Length)];
                ForegroundColor = consolePlate.PlateColor;
                WriteLine(consolePlate.PlateChar);
                ResetColor();
            }
        }
    }
}