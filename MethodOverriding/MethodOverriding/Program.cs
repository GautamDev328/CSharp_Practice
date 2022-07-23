using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Program
    {
        public virtual void sum()
        {

            Console.WriteLine("hello");
        }
    }

    class Tution : Program
    {
        public override void sum()
        {
            Console.WriteLine("India");
        }

        static void Main(string[] args)
        {
            Tution t = new Tution();
            t.sum();
           Program p = new Tution();
            p.sum();
            Console.ReadLine();
        }
    }
}

