using System;
using static System.Console;

namespace _3장_StringFormatBasic_102page
{
    class Program
    {
        static void Main(string[] args)
        {
            string fmt = "{0,-20}{1,-15},{2,30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "Sanghyun Park", "This is C#");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programmingn Language");
        }
    }
}
