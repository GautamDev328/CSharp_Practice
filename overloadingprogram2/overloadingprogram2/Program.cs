using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadingprogram2
{
    public  class Program
    {
        public void test()
        {
            Console.WriteLine("Hello");
        }
         void test(int a,int b)
        {
            Console.WriteLine("India");

        }
         void test(int a, int b, string c)
        {
            Console.WriteLine("Bharat");
        }
        static void Main()
        {
            Program p = new Program();
            p.test();
            p.test(0,1);
            p.test(0,1,"gautamdev");
            Console.ReadLine();
        }
    }
}
