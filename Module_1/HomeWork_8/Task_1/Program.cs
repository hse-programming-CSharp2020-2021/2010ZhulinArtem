using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using static System.Console;

namespace Task_2
{
    class Program
    {
        static Random random = new Random();
        private static int minValueOfRandom = 0;
        private static int maxValueOfRandom = 10001;
        private static string inputPath = "input.txt";
        private static string outputPath = "output.txt";
        private static string pathToNotepad = @"C:\Windows\system32\notepad.exe";

        static void Main(string[] args)
        {
            CreateIntArrayToFile();
            CreateSquareArrayToFile();

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) StartNotepadWindows();
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) StartNotepadMacOs();

            CloseApplication();
        }

        private static void CloseApplication()
        {
            var userChoose = ReadLine();
            while (userChoose == "exit")
            {
                WriteLine("Something went wrong...");
                WriteLine("So enter \"exit\"-to close...");
                userChoose = ReadLine();
            }

            Environment.Exit(0);
        }

        private static void StartNotepadMacOs()
        {
            WriteLine("It's MacOs\nI don't know path to the notepad.");
            WriteLine("So enter \"exit\"-to close...");
        }

        private static void StartNotepadWindows()
        {
            WriteLine("It's Windows.");
            Process.Start(pathToNotepad, inputPath);
            Process.Start(pathToNotepad, outputPath);
        }

        static void CreateIntArrayToFile()
        {
            var intArray = new string[random.Next(1, maxValueOfRandom)];
            for (var i = 0;
                i < intArray.Length;
                i++)
            {
                intArray[i] = random.Next(minValueOfRandom, maxValueOfRandom).ToString();
            }

            File.WriteAllLines(inputPath, intArray);
        }

        static void CreateSquareArrayToFile()
        {
            var intArray = File.ReadAllLines(inputPath).Select(x => int.Parse(x)).ToArray();

            var squareArray = new string[intArray.Length];
            for (var i = 0;
                i < squareArray.Length;
                i++)
            {
                if (intArray[i] == 0)
                {
                    continue;
                }

                var number = 1;
                squareArray[i] = number.ToString();
                while (true)
                {
                    if (number * 2 > intArray[i])
                    {
                        break;
                    }

                    squareArray[i] = (number * 2).ToString();
                    number *= 2;
                }
            }

            File.WriteAllLines(outputPath, squareArray);
        }
    }
}