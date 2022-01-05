using System;

namespace _7장_ReadonlyMethod_286page
{
    struct ACSetting
    {
        public double currentInCelsius; //현재 온도
        public double target; // 희망 온도

        public readonly double GetFahrenheit()
        {
            target = currentInCelsius * 1.8 + 32;
            return target;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}