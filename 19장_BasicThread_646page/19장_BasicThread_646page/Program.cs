using System;
using System.Threading;

namespace _19장_BasicThread_646page
{
    class Program
    {
        static void DoSomething()
        {
            for(int i=0; i<5; i++)
            {
                Console.WriteLine($"DoSomething: {i}");
                Thread.Sleep(10); // 밀리초 단위
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));

            Console.WriteLine("Starting thread...");
            t1.Start();

            for(int i=0; i<5; i++)
            {
                Console.WriteLine($"Main: {i}");
                Thread.Sleep(10); // 밀리초 단위
            }

            Console.WriteLine("Waiting until thread stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}