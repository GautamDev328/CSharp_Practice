using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectprogram
{
    internal class Program
    {
        /*  int a = 10;
         // int b = 20;
         // int c = 25;
         // int add = a + c;
         // int sub = c - b;


         String y = "Ram"; */
        int a;
        int b;
      //  int add = a + b; 
        //String b;

        static void Main()
        {
            Program p = new Program();
            p.a = 10;
            p.b = 20;
           // p.add = 10 + 20; ;
            Console.WriteLine(p.b);
            Console.WriteLine(p.a);
           // Console.WriteLine(p.add);
            Console.ReadLine();
        }
    }
}
