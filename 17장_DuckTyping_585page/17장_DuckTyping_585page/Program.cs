using System;

namespace _17장_DuckTyping_585page
{
    class Duck
    {
        public void Walk()
        {
            Console.WriteLine(this.GetType() + ".Walk()");
        }

        public void Swim()
        {
            Console.WriteLine(this.GetType() + ".Swim()");
        }

        public void Quack()
        {
            Console.WriteLine(this.GetType() + ".Quack()");
        }
    }

    class Robot
    {
        public void Walk()
        {
            Console.WriteLine(this.GetType() + ".Walk()");
        }

        public void Swim()
        {
            Console.WriteLine(this.GetType() + ".Swim()");
        }

        public void Quack()
        {
            Console.WriteLine(this.GetType() + ".Quack()");
        }
    }

    class Mallard : Duck { }

    class Program
    {
        static void Main(string[] args)
        {
            dynamic[] arr = new dynamic[] { new Duck(), new Mallard(), new Robot() };

            foreach(dynamic duck in arr)
            {
                Console.WriteLine(duck.GetType());
                duck.Walk();
                duck.Swim();
                duck.Quack();
                Console.WriteLine();
            }
        }
    }
}