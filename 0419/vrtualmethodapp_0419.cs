using System;
namespace VirtualMethodApp
{
    class BaseClass
    {
        virtual public void MethodA()
        {
            Console.WriteLine("Base MethodA");
        }
        virtual public void MethodB()
        {
            Console.WriteLine("Base MethodB");
        }
        virtual public void MethodC()
        {
            Console.WriteLine("Base MethodC");
        }
    }
    class DerivedClass : BaseClass
    {
        new public void MethodA()
        {
            Console.WriteLine("Derived MethodA");
        }
        override public void MethodB()
        {
            Console.WriteLine("Derived MethodB");
        }
        public void MethodC()   // add override or new
        {
            Console.WriteLine("Derived MethodC");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass s = new DerivedClass();
            s.MethodA();
            s.MethodB();
            s.MethodC();
        }
    }
}