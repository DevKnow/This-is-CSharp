using System;

namespace _12장_KillingProgram_433page
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            for(int i=0; i<5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("종료");
        }
    }
}