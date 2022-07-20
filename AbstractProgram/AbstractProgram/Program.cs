using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProgram
{
    public abstract class A
    {
        public abstract void Rond();
    }
    
        public class B : A {
            public override void Rond()
            {
                Console.WriteLine("20");
            }
        }
        class Test {
            static void Main()
            {
                A a = new B();
                a.Rond();
            Console.ReadLine();

            }
        }
    }
