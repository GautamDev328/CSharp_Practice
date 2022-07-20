using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilabel_inheritance
{
    internal class Program
    {
        public int b = 20;
        public int a = 10;
    }
    class A : Program
    {
        public int b = 20;
        public void show()
        {
            Console.WriteLine("Hello india");
            {

            }
        }
    }
    class B: A//Program child ko nhi likkhe or parent 
                 // class ko likkhe to galat ho jayega parent
                 // class ke place pr child class ko dena h 
    {
        public static void Main()
        {
            B p = new B();
            p.show();
            Console.WriteLine(p.b);
            Console.WriteLine(p.a);
           Console.WriteLine(p.b);
        }
    }


}



