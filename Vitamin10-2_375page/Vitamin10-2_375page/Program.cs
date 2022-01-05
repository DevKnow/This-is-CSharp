using System;

namespace Vitamin10_2_375page
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            foreach (int i in arr)
            {
                foreach (int j in arr)
                    Console.Write($"[{i}, {j}]: {arr[i, j]} ");
            }
            Console.WriteLine();

            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

            foreach (int i in arr2)
            {
                foreach (int j in arr2)
                    Console.Write($"[{i}, {j}]: {arr2[i, j]} ");
            }
            Console.WriteLine();

            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };

            foreach (int i in arr3)
            {
                foreach (int j in arr3)
                    Console.Write($"[{i}, {j}]: {arr3[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}