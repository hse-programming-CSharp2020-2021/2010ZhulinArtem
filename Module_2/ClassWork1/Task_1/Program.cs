using System;

namespace Task_1
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            InfoOfArray(CreateArrayOfArray());
        }

        static char[] CreateCharArray(int value)
        {
            var charArray = new char[value];
            for (var i = 0; i < charArray.Length; i++)
            {
                charArray[i] = (char) random.Next(33, 127);
            }

            return charArray;
        }

        static char[][] CreateArray(int value, int[] lengthOfArray)
        {
            var array = new char[value][];
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = CreateCharArray(i);
            }

            return array;
        }

        static char[][][] CreateArrayOfArray()
        {
            var arrayOfArray = new char[3][][];
            var lengthOfArray = new[] {3, 2, 1};
            var lengthOfCharArray = new[] {new []{ 2, 3, 4 } , new[] { 2, 3 }, new[] { 4 } };

            for (var i = 0; i < arrayOfArray.Length; i++)
            {
                arrayOfArray[i] = CreateArray(lengthOfArray[i],lengthOfCharArray[i]);
            }

            return arrayOfArray;
        }

        
        static void InfoOfArray(char[][][] array)
        {
            Console.WriteLine($"Rank: {array.Rank}");
            Console.WriteLine($"Number of elements: {array.GetLength(0)}");
        }
    }
}
