using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_constructor
{
    public class Program
    {
        int x;
        public Program(int i)
        {
            x = i;
            Console.WriteLine(x);
        }
        public Program(Program p)
        {
            x = p.x;

        }




        static void Main()
        {
          //  Program p2 = new Program(p);
            Program p = new Program(10);
           Program p2 = new Program(p);
            Console.ReadLine();
        }
    }
}