using System;

namespace Task_1
{
    class Program
    {
        private static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
        }

        public static int[] CreateArray(uint length)
        {
            Random rand =new Random();
            int [] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(-100,101);
            }
            return array;
        }

        public static int [] ReplaceMax(int usernumber,int [] Array)
        {
            var max = MaxElemtnt(Array);
            for (int i = 0; i < Array.Length; i++)
            {
                if (max==Array[i])
                {
                    Array[i] = usernumber;
                }
            }
            return Array;
        }

        private static int MaxElemtnt(int[] Array)
        {
            int max = Array[0];
            for (int i = 1; i < Array.Length; i++)
            {
                if (Array[i] > max)
                {
                    max = Array[i];
                }
            }

            return max;
        }

        static void Main(string[] args)
        {
            uint value;
            int usernumber;
            do
            {
                Console.Write("Enter value: ");
            } while (!uint.TryParse(Console.ReadLine(), out value));

            int [] ArrA = CreateArray(value);

            Print(ArrA);
            do
            {
                Console.Write("Enter your number: ");
            } while (!int.TryParse(Console.ReadLine(), out usernumber));
            
            ArrA = ReplaceMax(usernumber, ArrA);
            Print(ArrA);

        }
    }
}
