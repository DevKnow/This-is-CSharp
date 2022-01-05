using System;

namespace _5장_While_163page
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            while (i > 0)
                Console.WriteLine($"i: { i--}");
        }
    }
}