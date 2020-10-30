using System;
using System.Text;

namespace Task_1
{
    class Program
    {
        private static string[] NameOfBranch = {"Quarter\\Branch", "West", "Central", "East"};

        private static int[,] Sales =
        {
            {27, 24, 25},
            {26, 20, 18},
            {23, 2, 24},
            {22, 19, 20}
        };

        private static string[] Quarter = {"I", "II", "III", "IV"};

        private static StringBuilder stringBuilder = new StringBuilder();

        private static void Main(string[] args)
        {
            Info();
        }

        private static void Info()
        {
            PrintTable();
            Console.WriteLine();
            Console.WriteLine($"General sales: {SumOfSales()}");
            Console.WriteLine();
            Console.WriteLine($"№||\tName\t||Best quarter\t||Sales\t||");
            for (var i = 1; i < NameOfBranch.Length; i++)
            {
                var index = IndexOfBranchMaxSales(i - 1);
                Console.WriteLine($"{i}||\t{NameOfBranch[i]}\t||\t{Quarter[index]}\t ||{Sales[index, i - 1]}\t||");
            }

            Console.WriteLine();
            var indexOfBestBranch = IndexOfBestBranch(out var salesOfBranch);
            Console.WriteLine(
                $"Best branch: {NameOfBranch[indexOfBestBranch + 1]}, Sales: {salesOfBranch[indexOfBestBranch]}");

            Console.WriteLine();
            var indexOfBestQuater = IndexOfBestQuarter(out var salesOfQuarter);
            Console.WriteLine(
                $"Best quarter: {Quarter[indexOfBestQuater]}, Sales: {salesOfQuarter[indexOfBestQuater]}");
        }

        private static void PrintTable()
        {
            foreach (var name in NameOfBranch)
            {
                stringBuilder.Append($"{name,15}||");
            }

            Console.WriteLine(stringBuilder);

            for (var i = 0; i < Sales.GetLength(0); i++)
            {
                stringBuilder.Remove(0, stringBuilder.Length);
                stringBuilder.Append($"{Quarter[i],15}||");

                for (var j = 0; j < Sales.GetLength(1); j++)
                {
                    stringBuilder.Append($"{Sales[i, j],15}||");
                }

                Console.WriteLine(stringBuilder);
            }
        }

        private static int SumOfSales()
        {
            var sum = 0;
            for (var i = 0; i < Sales.GetLength(0); i++)
            {
                for (var j = 0; j < Sales.GetLength(1); j++)
                {
                    sum += Sales[i, j];
                }
            }

            return sum;
        }

        private static int IndexOfBranchMaxSales(int indexOfBranch)
        {
            var index = 0;
            for (var i = 1; i < Sales.GetLength(0); i++)
            {
                if (Sales[i, indexOfBranch] > Sales[index, indexOfBranch])
                {
                    index = i;
                }
            }

            return index;
        }

        private static int IndexOfBestBranch(out int[] sumOfSales)
        {
            var index = 0;
            sumOfSales = new int[Sales.GetLength(1)];
            for (var j = 0; j < Sales.GetLength(1); j++)
            {
                for (var i = 0; i < Sales.GetLength(0); i++)
                {
                    sumOfSales[j] += Sales[i, j];
                }
            }

            for (var i = 1; i < sumOfSales.Length; i++)
            {
                index = sumOfSales[i] > sumOfSales[index] ? i : index;
            }

            return index;
        }

        private static int IndexOfBestQuarter(out int[] sumOfSales)
        {
            var index = 0;
            sumOfSales = new int[Sales.GetLength(0)];
            for (var i = 0; i < Sales.GetLength(0); i++)
            {
                for (var j = 0; j < Sales.GetLength(1); j++)
                {
                    sumOfSales[i] += Sales[i, j];
                }
            }

            for (var i = 0; i < sumOfSales.Length; i++)
            {
                index = sumOfSales[i] > sumOfSales[index] ? i : index;
            }

            return index;
        }
    }
}