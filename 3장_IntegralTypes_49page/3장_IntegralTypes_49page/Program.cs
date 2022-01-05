using System;

namespace _3장_IntegralTypes_49page
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -10;
            byte b = 40;

            Console.WriteLine($"a={a},b={b}");

            short c = -30000;
            ushort d = 6000;

            Console.WriteLine($"c={c},d={d}");

            int e = -10_000_000;
            uint f = 300_000_000;

            Console.WriteLine($"e={e},f={f}");

            long g = -500_000_000_000;
            ulong h = 2_000_000_000_000_000_000;

            Console.WriteLine($"g={g},h={h}");

        }
    }
}
