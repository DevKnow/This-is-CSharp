using System;

namespace Vitamin8_2_312page
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    class Car : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Run!");
        }
    }

    class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly!");
        }
    }

    class FlyingCar : IRunnable, IFlyable
    {
        Car car = new Car();
        Plane plane = new Plane();

        public void Run()
        {
            car.Run();
        }

        public void Fly()
        {
            plane.Fly();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}