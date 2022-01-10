using System;
using System.Linq;

namespace _15장_From_516page
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

            var result = from n in numbers
                         where n % 2 == 0
                         orderby n
                         select n;

            Console.Write("numbers 배열에서 짝수는: ");

            foreach (int n in result)
                Console.Write($"{n} ");
        }
    }
}