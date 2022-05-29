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
      int i = 1;
      while(i <= 10)
      {
        if(i % 2 == 0) { i++; continue; }
        Console.WriteLine(i + " ");
        i++;
      }
      Console.WriteLine();
    }
  }
}
