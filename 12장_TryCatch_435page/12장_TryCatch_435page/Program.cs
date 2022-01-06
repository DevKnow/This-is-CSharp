using System;

namespace _12장_TryCatch_435page
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"예외 발생: {e.Message}");
            }
            
            Console.WriteLine("종료");
        }
    }
}