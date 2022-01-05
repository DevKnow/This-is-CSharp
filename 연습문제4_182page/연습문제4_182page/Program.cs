using System;

namespace 연습문제4_182page
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            do
            {
                Console.Write("반복 횟수를 입력하세요 : ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num <= 0) Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.\n");
            } while (num<=0);

            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}