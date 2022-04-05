using System;
namespace DelegateCallApp
{
    delegate void DelegateOne(); // delegate with no params
    delegate void DelegateTwo(int i); // delegate with 1 param
    class DelegateClass
    {
        public void MethodA()
        {
            Console.WriteLine("In the DelegateClass.MethodA ...");
        }
        public void MethodB(int i)
        {
            Console.WriteLine("DelegateClass.MethodB, i = " + i);
        }
    }
    class Program
    {
        public static void Main()
        {
            DelegateClass obj = new DelegateClass();
            DelegateOne d1 = new DelegateOne(obj.MethodA);
            DelegateTwo d2 = new DelegateTwo(obj.MethodB);
            d1(); // invoke MethodA() in DelegateClass
            d2(10); // invoke MethodB(10) in DelegateClass
        }
    }
}