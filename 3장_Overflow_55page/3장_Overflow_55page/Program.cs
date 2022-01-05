using System;

namespace _3장_Overflow_55page
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
        }
    }
}