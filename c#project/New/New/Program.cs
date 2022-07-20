using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 30;
           int add = x + y;
            int sub = x - y;
            int mult = x * y;
            int div = x / y;
            int mod = x % y;
            /*  Console.WriteLine("value of add:" + add);
              Console.WriteLine("value of sub:" + sub);
              Console.WriteLine("value of mult:" + mult);
              Console.WriteLine("value of div:" + mult);
              Console.WriteLine("value of mod:" + mod);*/
            Console.WriteLine("value of {0},{1},{2},{3},{4},{5}", add, sub, mult, div, mod);
         //   Console.WriteLine("value of {0},{1}",x, y);
            Console.ReadLine();

          }
       // Console.ReadLine();
    }
}
