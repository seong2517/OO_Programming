using System;
namespace CallByReferenceApp
{
    class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x; x = y; y = temp;
            Console.WriteLine(" Swap: x = {0}, y = {1}", x, y);
        }
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            Console.WriteLine("Before: x = {0}, y = {1}", x, y);
            Swap(ref x, ref y);
            Console.WriteLine(" After: x = {0}, y = {1}", x, y);
        }
    }
}