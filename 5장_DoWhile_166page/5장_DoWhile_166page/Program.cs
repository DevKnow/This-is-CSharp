using System;

namespace _5장_DoWhile_166page
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                Console.WriteLine("a) i: {0}", i--);
            } while (i > 0);

            do
            {
                Console.WriteLine("b) i: {0}", i--);
            } while (i > 0);
        }
    }
}