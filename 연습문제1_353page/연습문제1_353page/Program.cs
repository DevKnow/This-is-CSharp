using System;

namespace 연습문제1_353page
{
    class NameCard
    {
        private int age;
        private string name;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard();

            MyCard.Age=24;
            MyCard.Name="상현";

            Console.WriteLine("나이: {0}", MyCard.Age);
            Console.WriteLine("이름: {0}", MyCard.Name);
        }
    }
}