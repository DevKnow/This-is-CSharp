using System;

namespace _14장_SimpleLambda_489page
{
    class Program
    {
        delegate int Calculate(int a, int b);
        static void Main(string[] args)
        {
            Calculate cal = (a, b) => a + b;

            Console.WriteLine($"{3} + {4} = {cal(3, 4)}");
        }
    }
}