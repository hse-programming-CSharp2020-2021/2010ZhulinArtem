using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using static System.Console;

namespace Task_1
{
    class Program
    {
        static Random random = new Random();
        private static int minValueOfRandom = -10;
        private static int maxValueOfRandom = 11;
        private static string inputPath = "input.txt";
        private static string outputPath = "output.txt";
        private static string pathToNotepad = @"C:\Windows\system32\notepad.exe";

        static void Main(string[] args)
        {
            CreateIntArrayToFile();
            CreateBoolArrayToFile();

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

            try
            {
                Process.Start(pathToNotepad, inputPath);
                Process.Start(pathToNotepad, outputPath);
            }
            catch (FileNotFoundException exception)
            {
                WriteLine($"Didn't find a notepad. Error Message:\n{exception.Message}");
            }
        }


        static void CreateIntArrayToFile()
        {
            var intArray = new string[random.Next(0, maxValueOfRandom)];
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(minValueOfRandom, maxValueOfRandom).ToString();
            }

            File.WriteAllLines(inputPath, intArray);
        }

        static void CreateBoolArrayToFile()
        {
            var intArray = File.ReadAllLines(inputPath).Select(x => int.Parse(x)).ToArray();
            bool[] boolArray = new bool[intArray.Length];
            for (int i = 0; i < boolArray.Length; i++)
            {
                boolArray[i] = intArray[i] >= 0;
            }

            var boolArrayString = boolArray.Select(x => x.ToString()).ToArray();
            File.WriteAllLines(outputPath, boolArrayString);
        }
    }
}