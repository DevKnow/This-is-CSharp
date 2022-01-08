using System;

namespace _14장_StateLambda_491page
{
    class Program
    {
        delegate string Concantenate(string[] args);

        static void Main(string[] args)
        {
            Concantenate concat = (arr) =>
             {
                 string result = "";
                 foreach (string s in arr)
                     result += s;
                 return result;
             };

            Console.WriteLine(concat(args));
        }
    }
}