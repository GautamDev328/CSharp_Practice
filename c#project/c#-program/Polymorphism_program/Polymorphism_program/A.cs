using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_program
{
    class A
    {
        public void Test()
        {
            Console.WriteLine("Hello");
        }
    }
    class B : A
    {
        public void Test()
        {
            Console.WriteLine("Hiii...");
        }

    }
    class C : A
    {
        public void Test()
        {
            Console.WriteLine("It is a good plant");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A aA = new A();
            A bB = new B();
            A cC = new C();
            aA.Test();
            bB.Test();
            cC.Test();
            //  a.Test();
            // a.Testing();

        }
    }
}


      
        
