using System;

namespace _11장_ConstraintsOnTypeParameters_416page
{
    class StructArray<T> where T : struct
    {
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }

    class RefArray<T> where T : class
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }

    class Base
    {
        public Base()
        {
            Console.WriteLine("Invoke Base()");
        }
        public Base(int a)
        {
            Console.WriteLine("Invoke Base(int a)");
        }

        public virtual void Print()
        {
            Console.WriteLine("Invoke Base.Print()");
        }
    }

    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Invoke Derived()");
        }
        public Derived(int a)
        {
            Console.WriteLine("Invoke Derived(int a)");
        }

        public override void Print()
        {
            Console.WriteLine("Invoke Derived.Print()");
        }
    }
    class BaseArray<U> where U : Base
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }

        public void CopyArray<T> (T[] Source) where T : U
        {
            Source.CopyTo(Array, 0);
        }
    }

    interface IInterface
    {
        public void One();
    }

    class Something<T> where T : IInterface, new()
    {
        public void Number()
        {
            T a = new T();
            a.One();
        }
    }

    class SomethingTwo : IInterface
    {
        public void One()
        {
            Console.WriteLine("Invoke SomethingTwo.One()");
        }
    }

    class Program
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 0;
            a.Array[1] = 1;
            a.Array[2] = 2;

            Console.WriteLine("<a Array Result>");

            for (int i = 0; i < a.Array.Length; i++)
            {
                Console.WriteLine($"a.Array[{i}] = {a.Array[i]}");
            }
            Console.WriteLine();

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1005);

            Console.WriteLine("\n<b Array Result>");

            for (int i = 0; i < b.Array.Length; i++)
            {
                Console.WriteLine($"b.Array[{i}].Array.Length = {b.Array[i].Array.Length}");
            }
            Console.WriteLine();

            Console.WriteLine("\n<Invoke c Array Constructor>");

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            Console.WriteLine("\n<c Array Result>");

            for (int i = 0; i < c.Array.Length; i++)
            {
                Console.Write($"c.Array[{i}] = ");
                c.Array[i].Print();
            }
            Console.WriteLine();

            Console.WriteLine("\n<Invoke d Array Constructor>");

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived(5);
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>();

            Console.WriteLine("\n<d Array Result>");

            for (int i = 0; i < d.Array.Length; i++)
            {
                Console.Write($"d.Array[{i}] = ");
                d.Array[i].Print();
            }
            Console.WriteLine();

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);

            Console.WriteLine("\n<e Array Result>");

            for (int i = 0; i < e.Array.Length; i++)
            {
                Console.Write($"e.Array[{i}] = ");
                e.Array[i].Print();
            }
            Console.WriteLine();

            Console.WriteLine("\n<f Array Result>");

            Something<SomethingTwo> f = CreateInstance<Something<SomethingTwo>>();
            f.Number();
        }
    }
}