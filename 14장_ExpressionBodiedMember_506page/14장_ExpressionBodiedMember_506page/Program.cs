using System;
using System.Collections.Generic;

namespace _14장_ExpressionBodiedMember_506page
{
    class FrinedList
    {
        private List<string> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach (var s in list)
                Console.WriteLine(s);
        }

        public FrinedList() => Console.WriteLine("FrinedList()");
        ~FrinedList() => Console.WriteLine("~FrinedList()");

        // public int Capacity => list.Capacity; 읽기전용
        public int Capacity
        {
            get => list.Capacity;
            set => list.Capacity=value;
        }

        // public string this[int index] => list[int index]; 읽기전용
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            FrinedList obj = new FrinedList();
            obj.Add("Eeny");
            obj.Add("Meeny");
            obj.Add("Miny");
            obj.Remove("Eeny");
            obj.PrintAll();

            Console.WriteLine($"{obj.Capacity}");
            obj.Capacity = 10;
            Console.WriteLine($"{obj.Capacity}");

            Console.WriteLine($"{obj[0]}");
            obj[0] = "Moe";
            obj.PrintAll();
        }
    }
}
