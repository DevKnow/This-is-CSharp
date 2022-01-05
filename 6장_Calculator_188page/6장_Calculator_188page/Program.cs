using System;

namespace Method
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
}

namespace _6장_Calculator_188page
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Method.Calculator.Plus(3, 4);
            Console.WriteLine(result);

            result = Method.Calculator.Minus(5, 2);
            Console.WriteLine(result);
        }
    }
}