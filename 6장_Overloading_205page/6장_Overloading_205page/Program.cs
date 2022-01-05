using System;

namespace _6장_Overloading_205page
{
    class Program
    {
        static int Plus(int a,int b)
        {
            Console.WriteLine("Calling int Plus(int a,int b)...");
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int a,int b, int c)...");
            return a + b + c;
        }

        static double Plus(double a, double b)
        {
            Console.WriteLine("Calling double Plus(double a,double b)...");
            return a + b;
        }

        static double Plus(int a, double b)
        {
            Console.WriteLine("Calling double Plus(int a,double b)...");
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2,3));
            Console.WriteLine(Plus(1.0, 2.4));
            Console.WriteLine(Plus(1, 2.4));
        }
    }
}