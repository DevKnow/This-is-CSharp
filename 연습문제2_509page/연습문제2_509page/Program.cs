using System;

namespace 연습문제2_509page
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 44, 55 };

            foreach(int a in array)
            {
                Action action = () => Console.WriteLine(a * a);
                action.Invoke();
            }
        }
    }
}
