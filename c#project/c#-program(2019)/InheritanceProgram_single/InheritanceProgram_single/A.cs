using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProgram_single
{
    public class A
    {
          public void Test()
          {
              Console.WriteLine("Method");
              Console.WriteLine("Hero");
          }
     //   public int x = 20;
    }
    class B : A
    {
    public static void Main(string[] args)
        {
            A a = new A();
          a.Test();
            // Console.WriteLine(a.Test;
            Console.ReadLine();
        }
    }
}
