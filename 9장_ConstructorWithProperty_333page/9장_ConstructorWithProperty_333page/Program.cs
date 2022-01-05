using System;

namespace _9장_ConstructorWithProperty_333page
{
    class Program
    {
        class BirthdayInfo
        {
            public string Name
            {
                get;
                set;
            }

            public DateTime Birthday
            {
                get;
                set;
            }
            public int Age
            {
                get
                {
                    return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
                }
            }
        }

        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "서현",
                Birthday = new DateTime(1991, 6, 28)
            };

            Console.WriteLine($"Name: {birth.Name}");
            Console.WriteLine($"Birthday: {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age: {birth.Age}");
        }
    }
}