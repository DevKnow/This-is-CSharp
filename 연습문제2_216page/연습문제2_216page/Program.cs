using System;

namespace 연습문제2_216page
{
    class Program
    {
        static void Main(string[] args)
        {

            Mean(1, 2, 3, 4, 5, out double mean);

            Console.WriteLine("평균: {0}", mean);
        }

        public static void Mean(double a, double b, double c, double d, double e, out double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}