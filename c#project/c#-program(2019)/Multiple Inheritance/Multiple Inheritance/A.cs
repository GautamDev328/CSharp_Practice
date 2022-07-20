using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance
{
    internal class A
    {
        public void Test()
        {
            Console.WriteLine("Hello india");
        }
    }
    class B : A
    {
        public void Try()
        {
            Console.WriteLine("Hello welcome");
        }
    }
    class subchild :B
    {
        static void Main()
        {
             subchild sc = new subchild();
           // A sc = new A();
          //  sc.Try();
           // sc.Test();
            sc.Try();
           sc.Test();
            Console.ReadLine();
        }
      
    }
}

