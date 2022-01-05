using System;

namespace _3장_FloatConversion_73page
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 69.6875f;
            Console.WriteLine("a: {0}", a);

            double b = (double)a;
            Console.WriteLine("b: {0}", b);
            Console.WriteLine("69.6875==b:{0}", 69.6875 == b);

            float x = 0.1f;
            Console.WriteLine("x: {0}", x);

            double y = (double)x;
            Console.WriteLine("x: {0}", y);
            Console.WriteLine("0.1==y:{0}", 0.1 == y);
        }
    }
}