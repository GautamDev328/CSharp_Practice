using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloadingprogram
{
    public class Program
    {
        public virtual void show()
        {
            Console.WriteLine("Hello");
        }
    }
   public class A : Program
    {
        public override void show()
        {
            Console.WriteLine("this is a man");

        } }

      public  class Test {
         public   static void Main()
            {
                Program b = new Program();
                b.show( );
                Console.ReadLine();
            }
        }
    }
