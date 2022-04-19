using System;

namespace HiddenNameApp
{
    class BaseClass
    {
        protected int a = 1;
        protected int b = 2;
    }
    class DerivedClass : BaseClass
    {
        new int a = 3;
        new double b = 4.5;
        public void Output()
        {
            Console.WriteLine("BaseClass : a={0}, DerivedClass:a={1}", base.a, a);
            Console.WriteLine("BaseClass : b={0}, DerivedClass:b={1}", base.b, b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.Output();
        }
    }
}