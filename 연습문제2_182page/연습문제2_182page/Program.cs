using System;

namespace 연습문제2_182page
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5 - i; j > 0; j--)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}