using System;
namespace ClassTypeConversionApp
{
    class CLanguage
    {
        public bool Equal(object obj)
        {
            if (obj is CLanguage)
                return true;
            else
                return false;
        }
    }
    class CSharp : CLanguage
    {
        new public bool Equal(object obj)
        {
            return (obj is CSharp) ? true : false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CLanguage c = new CLanguage();
            CSharp cs = new CSharp();
            if (c.Equal(cs))
                Console.WriteLine("casting up is valid.");
            else
                Console.WriteLine("casting up is not valid.");
            if (cs.Equal(c))
                Console.WriteLine("casting down is valid.");
            else
                Console.WriteLine("casting down is not valid.");
        }
    }
}