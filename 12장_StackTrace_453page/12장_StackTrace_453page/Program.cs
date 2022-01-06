using System;

namespace _12장_StackTrace_453page
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                Console.WriteLine(3 / --a);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}