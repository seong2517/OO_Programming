using System;
namespace FractionApp
{
    class Fraction
    {
        int numerator;  // 분자 필드
        int denominator;    // 분모 필드

        public Fraction(int num, int denom)
        {   // 생성자
            numerator = num;
            denominator = denom;
        }

        public void PrintFraction()
        {   // 출력 메소드
            Console.WriteLine(numerator + "/" + denominator);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 2);
            f1.PrintFraction();

            var f2 = new Fraction(2, 5);
            f2.PrintFraction();

        }
    }
}