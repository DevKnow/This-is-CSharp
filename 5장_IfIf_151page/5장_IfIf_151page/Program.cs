using System;

namespace _5장_IfIf_151page
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요: ");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number > 0)
            {
                if ((number % 2) == 0)
                    Console.WriteLine("0보다 큰 짝수");
                else
                    Console.WriteLine("0보다 큰 홀수");
            }
            else
                Console.WriteLine("0보다 작거나 같은 수");
        }
    }
}
