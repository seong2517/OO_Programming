using System;
namespace StaticConstructorApp
{
    class StaticConstructor
    {
        static int staticWithInitializer = 100;
        static int staticWithNoInitializer;
        StaticConstructor()
        { // 매개변수와 접근 수정자를 가질 수 없다.
            staticWithNoInitializer = staticWithInitializer + 100;
        }
        public static void PrintStaticVariable()
        {
            Console.WriteLine("field 1 = {0}, field 2 = {1}",
            staticWithInitializer, staticWithNoInitializer);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            StaticConstructor.PrintStaticVariable();
        }
    }
}