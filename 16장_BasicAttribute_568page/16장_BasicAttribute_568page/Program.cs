using System;

namespace _16장_BasicAttribute_568page
{
    class MyClass
    {
        [Obsolete("OldMethod()는 폐기되었습니다. NewMethod()를 이용하세요.")]
        public void OldMethod()
        {
            Console.WriteLine("I'm old");
        }

        public void NewMethod()
        {
            Console.WriteLine("I'm new");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            obj.OldMethod();
            obj.NewMethod();
        }
    }
}