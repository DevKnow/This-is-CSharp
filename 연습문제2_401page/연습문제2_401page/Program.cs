using System;

namespace 연습문제2_401page
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrA = new int[2, 2] { { 3, 2 }, { 1, 4 } };
            int[,] arrB = new int[2, 2] { { 9, 2 }, { 1, 7 } };
            int[,] result = new int[2, 2];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = arrA[i, 0] * arrB[0, j] + arrA[i, 1] * arrB[1, j];
                }
            }

            for (int i = 0; i < result.GetLength(0); i++)
            { 
                for (int j = 0; j < result.GetLength(1); j++)
                    Console.Write($"{result[i, j]} ");
                Console.WriteLine();
            }
        }
    }
}