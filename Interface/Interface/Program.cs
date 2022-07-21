using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface Inter
    {
        void sum();
    }
    interface book {
        void sum2();
    }
  

    class A : Inter, book
    {
public  void sum()
        {
            Console.WriteLine("India");
        }
     public   void sum2()
        {
            Console.WriteLine("Bharat");
        }


        static void Main()
        {
            A a = new A();
            a.sum();
            a.sum2();
        //    a.tution();
            Console.ReadLine();
        }
    }

      
}
