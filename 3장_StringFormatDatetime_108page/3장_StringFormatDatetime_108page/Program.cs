using System;
using System.Globalization;
using static System.Console;

namespace _3장_StringFormatDatetime_108page
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 3, 23, 18, 22);

            WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            WriteLine("24시간 형식: {0:yyyy-MM-dd HH:mm:ss (ddd)}", dt);
            WriteLine();

            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (ddd)", ciKo));
            WriteLine(dt.ToString(ciKo));

            CultureInfo ciEn = new CultureInfo("en-US");
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (ddd)", ciEn));
            WriteLine(dt.ToString(ciEn));
        }
    }
}