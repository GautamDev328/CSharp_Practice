using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclass1
{
    public abstract class source
    
    {
        public void tution()
        {
            Console.WriteLine("India");
        }
        public abstract void Sum();
    }
   
    public  class Test : source
    {
        public override void Sum()
        {
            Console.WriteLine("Hello");
        }
     static void Main(string[] args)
        {
            source s = new Test();
            s.Sum();
            s.tution();
            Console.ReadLine();
        }
    }
}
