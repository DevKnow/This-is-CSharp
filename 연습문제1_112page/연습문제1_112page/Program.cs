using System;

namespace 연습문제1_112page
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string height = Console.ReadLine();

            //이곳에 사각형의 넓이를 계산하고 출력하는 루틴을 추가하세요
            Console.WriteLine("사각형의 넓이는 : {0}", int.Parse(width) * Convert.ToInt32(height));
        }
    }
}