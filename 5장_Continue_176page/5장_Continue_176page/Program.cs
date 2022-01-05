using System;

namespace _5장_Continue_176page
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i < 10;i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine($"{i}: 홀수");
            }
        }
    }
}