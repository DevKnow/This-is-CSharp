﻿using System;
using MyExtension;

namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        { return myInt * myInt; }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
                result *= myInt;
            return result;
        }
    }

    public static class StringExtension
    {
        public static string Append(this string myStr, string exponent)
        {
            return myStr + exponent;
        }
    }
}

namespace _7장_ExtensionMethod_278page
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2: { 3.Square()}");
            Console.WriteLine($"3^4: { 3.Power(4)}");
            Console.WriteLine($"2^10: { 2.Power(10)}");

            string hello = "Hello";
            Console.WriteLine(hello.Append(", World!"));
        }
    }
}
