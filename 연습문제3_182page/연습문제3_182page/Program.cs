using System;

namespace 연습문제3_182page
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j=0;

            while(i<5)
            {
                Console.Write("*");
                if(++j > i)
                {
                    i++;
                    Console.WriteLine();
                    j = 0;
                }
            }

            Console.WriteLine();

            i = 0;
            j = 0;

            do {
                Console.Write("*");
                j++;
               
                if (5-j <= i)
                {
                    j = 0;
                    Console.WriteLine();
                    i++;
                }
            } while (i < 5);
        }
    }
}
