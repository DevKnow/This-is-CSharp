using System;

namespace _7장_ThisConstructor_243page
{
    class MyClass
    {
        int a, b, c;

        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }

        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MyClass(int {b})");
        }

        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass(int {b}, int {c})");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a: {a}\nb: {b}\nc: {c}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            Console.WriteLine();

            MyClass c = new MyClass(10,20);
            c.PrintFields();
            Console.WriteLine();
        }
    }
}