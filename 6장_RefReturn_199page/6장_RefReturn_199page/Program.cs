using System;

namespace RefReturn
{
    class Product
    {
        private int price = 100;
        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price: {price}");
        }
    }
}

namespace _6장_RefReturn_199page
{
    class Program
    {
        static void Main(string[] args)
        {
            RefReturn.Product carrot = new RefReturn.Product();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price: {ref_local_price}");
            Console.WriteLine($"Normal Local Price: {normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price: {ref_local_price}");
            Console.WriteLine($"Normal Local Price: {normal_local_price}");
        }
    }
}