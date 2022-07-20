using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class A
    {
        public virtual void show()
        {
            Console.WriteLine("Hello India");
        }
    }
    class B : A
    {
        public override void show() {
            Console.WriteLine("Hii.. Welcome");

        }
    }
    class C : B
    {
        public override void show()
        {
            Console.WriteLine("Welcome India");
        }
    }
    class program
    {
        static void Main()
        {
            A aA = new A();
            A bB = new B();
            A cC = new C();

            aA.show();
            bB.show();
            cC.show();
            Console.ReadLine();
        }
       
    }
}

    
