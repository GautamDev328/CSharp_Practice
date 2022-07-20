using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace override_program
{
    public class A
    {
        public virtual void Sum()
        {
            Console.WriteLine("Hello");
        }
        public class B : A
        {
            public override void Sum()
            {
                Console.WriteLine("Interent");
            }
        }
       
            public class Test
            {
                public static void Main()
                {
                    B b = new B();
                    A a = new B();
                    b.Sum();
                    a.Sum();

                    Console.ReadLine();
                }
            }
        }
    }

       
        
    

