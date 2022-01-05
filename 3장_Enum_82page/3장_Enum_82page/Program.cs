using System;

namespace _3장_Enum_82page
{
    class Program
    {
        enum DialogResult { YES,NO,CANCEL,CONRITM,OK}

        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONRITM);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}