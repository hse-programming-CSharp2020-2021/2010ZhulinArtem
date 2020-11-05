using System;
using static System.Console;

namespace Task_1
{
    class Birthday
    {
        private int _year;
        private int _month;
        private int _day;

        public int Year
        {
            get => _year;
            set
            {
                if (value.GetType() != typeof(int) || value < 1)
                {
                    throw new ArgumentException("Incorrect input.");
                }

                _year = value;
            }
        }

        public int Month
        {
            get => _month;
            set
            {
                if (value.GetType() != typeof(int) || value < 1 || value > 12)
                {
                    throw new ArgumentException("Incorrect input.");
                }

                _month = value;
            }
        }

        public int Day
        {
            get => _day;
            set
            {
                switch (Month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (value.GetType() != typeof(int) || value < 1 || value > 31)
                        {
                            throw new ArgumentException("Incorrect input.");
                        }

                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (value.GetType() != typeof(int) || value < 1 || value > 30)
                        {
                            throw new ArgumentException("Incorrect input.");
                        }

                        break;
                    case 2:
                        if (value.GetType() != typeof(int) || value < 1 || value > 28)
                        {
                            throw new ArgumentException("Incorrect input.");
                        }

                        break;
                }

                _day = value;
            }
        }

        public Birthday()
        {
            Year = 1970;
            Month = 1;
            Day = 1;
        }

        public void BirthDay()
        {
            WriteLine($"Birthday: {new DateTime(Year, Month, Day).ToLongDateString()}");
        }

        public void NextBirthDay()
        {
            var thisDay = DateTime.Today;
            var nextBirthday = new DateTime(thisDay.Year, Month, Day);
            if (DateTime.Compare(thisDay, nextBirthday) == 1)
            {
                nextBirthday = new DateTime(thisDay.Year + 1, Month, Day);
            }

            WriteLine($"Next birthday: {nextBirthday.ToLongDateString()}");
            WriteLine($"Today: {thisDay.ToLongDateString()}");
            WriteLine($"Next birthday in: {nextBirthday.Subtract(thisDay).Days} days");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                MainMenu();

                WriteLine("\nEnter ESC - to exit, other keys to continue...");
            } while (ReadKey(true).Key!=ConsoleKey.Escape);
        }

        private static void MainMenu()
        {
            try
            {
                var personBirthday = new Birthday();

                Write("Enter your year birthday: ");
                personBirthday.Year = int.Parse(ReadLine());

                Write("Enter your month birthday: ");
                personBirthday.Month = int.Parse(ReadLine());

                Write("Enter your day birthday: ");
                personBirthday.Day = int.Parse(ReadLine());

                personBirthday.BirthDay();
                personBirthday.NextBirthDay();
            }
            catch (Exception exception)
            {
                WriteLine($"Error: {exception.Message}");
                WriteLine();
                WriteLine("Try again.Enter any key...");
                ReadKey();
                Clear();
                MainMenu();
            }
        }
    }
}