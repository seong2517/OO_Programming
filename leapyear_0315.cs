using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string m;
      string x = "윤년";
      string y = "평년";
      while (true)
      {
        Console.Write("년도 입력 : ");
        int a = int.Parse(Console.ReadLine());
        m = (a % 4 == 0 && a % 100 != 0 || a % 400 == 0) ? x : y;
        Console.WriteLine(m);
      }
    }
  }
}
