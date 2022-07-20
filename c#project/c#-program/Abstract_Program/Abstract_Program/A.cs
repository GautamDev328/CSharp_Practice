using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Program
{
    abstract class A
    {
        public abstract void show();
        // static void Main(string[] args)
        public void Test()
        {
            Console.WriteLine("this is a pen");
        }
    }
    class B : A
    {
        public override void show()
        {
            Console.WriteLine("this is my book");

        }
    }
    class Program
    {
        static void Main()
        {
            B b = new B();
            b.show();
            b.Test();

        }


    }
}
    
