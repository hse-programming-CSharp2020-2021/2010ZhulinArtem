using System;

namespace Task_4
{
    internal class Robot
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public char[,] Map;
        public Point CurrentPoint => new Point {X = X, Y = Y};

        internal class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public override string ToString() => $"X = {X}; Y = {Y}";
        }

        public Robot(uint length, uint wide)
        {
            Map = new char[length, wide];
        }

        public void Right()
        {
            if (CurrentPoint.X + 1 >= Map.GetLength(0))
            {
                throw new ArgumentException("Out of bounds");
            }

            Map[CurrentPoint.Y, CurrentPoint.X] = '+';
            X++;
        }

        public void Left()
        {
            if (CurrentPoint.X - 1 < 0)
            {
                throw new ArgumentException("Out of bounds");
            }

            Map[CurrentPoint.Y, CurrentPoint.X] = '+';
            X--;
        }

        public void Forward()
        {
            if (CurrentPoint.Y + 1 >= Map.GetLength(1))
            {
                throw new ArgumentException("Out of bounds");
            }

            Map[CurrentPoint.Y, CurrentPoint.X] = '+';
            Y++;
        }

        public void Backward()
        {
            if (CurrentPoint.Y - 1 < 0)
            {
                throw new ArgumentException("Out of bounds");
            }

            Map[CurrentPoint.Y, CurrentPoint.X] = '+';
            Y--;
        }

        public string Position() => $"The Robot Position: {CurrentPoint}";

        public void DrawMap()
        {
            for (var i = 0; i < Map.GetLength(0); i++, Console.WriteLine())
            {
                for (var j = 0; j < Map.GetLength(1); j++)
                {
                    if (j == CurrentPoint.X && i == CurrentPoint.Y)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write('*');
                        continue;
                    }

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(Map[i, j] != (char) 0 ? Map[i, j] : ' ');
                }
            }
        }
    }

    internal class Program
    {
        private delegate void Steps();

        private static void Main()
        {
            var robot = CreateRobot();
            do
            {
                try
                {
                    Console.Clear();
                    robot.DrawMap();
                    Console.WriteLine(robot.Position());


                    var steps = GetSteps(robot);
                    steps?.Invoke();

                    robot.DrawMap();
                    Console.WriteLine(robot.Position());
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }

                Console.WriteLine("Enter ESC - to exit, or another - to repeat...");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static Robot CreateRobot()
        {
            uint lengthMap, wideMap;
            do
            {
                Console.Write("Enter the length of map: ");
            } while (!uint.TryParse(Console.ReadLine(), out lengthMap));

            do
            {
                Console.Write("Enter the wide of map: ");
            } while (!uint.TryParse(Console.ReadLine(), out wideMap));

            var robot = new Robot(lengthMap, wideMap);
            return robot;
        }

        private static Steps GetSteps(Robot robot)
        {
            Steps stepDel = null;

            Console.Write("Enter steps (EX: \"LR\" -> Left - Right): ");
            var steps = Console.ReadLine();

            if (steps == null) return null;

            foreach (var step in steps.ToLower())
            {
                stepDel += step switch
                {
                    'l' => robot.Left,
                    'r' => robot.Right,
                    'f' => robot.Forward,
                    'b' => robot.Backward,
                    _ => throw new ArgumentException("Incorrect input")
                };
            }

            return stepDel;
        }
    }
}