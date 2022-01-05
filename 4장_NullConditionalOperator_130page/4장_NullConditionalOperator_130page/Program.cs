using static System.Console;
using System.Collections;

namespace _4장_NullConditionalOperator_130page
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구"); // a가 null을 반환하므로 Add()는 호출되지 않음
            a?.Add("축구");
            WriteLine($"Count: {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            a = new ArrayList(); // a는 더이상 null상태가 아님
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count: {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");
        }
    }
}