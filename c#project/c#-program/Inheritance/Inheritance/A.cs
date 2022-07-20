using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class A
    {
        // static void Main(string[] args)
        public float age = 30;
        
      //  Console.WriteLine("age");
        
}
    class B : A
    {
        public static void Main(String[] args)
        {
            B a = new B();
            //a.age;
            Console.WriteLine(a.age);
            Console.ReadLine();
        }
      
    }
    }

