using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadingprogram2
{
    public class Program
    {
        public void test(int a)
        {

            int b = ++a;
            Console.WriteLine(b);
        }


        public void test(int a, int b)
        {

            int c = a + b;
            Console.WriteLine(c);

        }
        public void test(int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine(d);
        }
        static void Main()
        {
            Console.WriteLine("Enter  a two number add in third party show the result:");
            Program p = new Program();
            p.test(10);
            p.test(0, 1);
            p.test(12, 13, 21);
            //   p.test(0,1,"gautamdev");
            Console.ReadLine();
        }
    }
}
