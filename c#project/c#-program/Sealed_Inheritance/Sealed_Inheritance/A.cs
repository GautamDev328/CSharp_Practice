using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Inheritance
{
   class A// sealed-> sealed jo dusre person ko property 
          // nhi dene ke liye sealed lagaya jata
    {
        public int age = 20;

        // static void Main(string[] args)
        // {
        class B : A
        {
            static void Main(string[] args)

            {
                B b = new B();
                Console.WriteLine(b.age);
            }
        }

    }
}
//}
