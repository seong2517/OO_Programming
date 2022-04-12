using System;
namespace DelegateOperationApp
{
    delegate void MultiDelegate();
    class DelegateClass
    {
        public void MethodA()
        {
            Console.WriteLine("In the DelegateClass.MethodA ...");
        }
        public void MethodB()
        {
            Console.WriteLine("In the DelegateClass.MethodB ...");
        }
        public void MethodC()
        {
            Console.WriteLine("In the DelegateClass.MethodC ...");
        }
    }
    class Program
    {
        public static void Main()
        {
            DelegateClass obj = new DelegateClass();// 클래스 객체 생성
            MultiDelegate dg1, dg2, dg3; // 델리게이트 선언
            dg1 = new MultiDelegate(obj.MethodA); // 델리게이트 객체 생성
            dg2 = new MultiDelegate(obj.MethodB); // 델리게이트 객체 생성
            dg3 = new MultiDelegate(obj.MethodC); // 델리게이트 객체 생성
                                                  // ...
            dg1 = dg1 + dg2; // 메소드 추가
            dg1 += dg3; // 메소드 추가
            dg2 = dg1 - dg2; // 메소드 제거
            dg1();
            Console.WriteLine("After dg1 call ...");
            dg2();
            Console.WriteLine("After dg2 call ...");
            dg3();
        }
    }
}