using System;

namespace _3장_SignedUnsigned_54page
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = (sbyte)a;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}