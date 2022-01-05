using System;

namespace _7장_SealedMethod_267page
{
    class Base
    {
        public virtual void SealMe()
        { }
    }

    class Derived : Base
    {
        public sealed override void SealMe()
        { }
    }

    class WantToOverride : Derived
    {
        public override void SealMe()
        { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}