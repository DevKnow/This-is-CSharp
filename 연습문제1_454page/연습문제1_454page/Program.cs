using System;

namespace 연습문제1_454page
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            try
            {
                for (int i = 0; i < 10; i++)
                    arr[i] = i;
                for (int i = 0; i < 11; i++)
                    Console.WriteLine(arr[i]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}