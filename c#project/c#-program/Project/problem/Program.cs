using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem
{
    class Program
    {
        int x = 668;
        public Program(int xx,int yy)
        {
            Console.WriteLine(xx);
            Console.WriteLine(yy);
        }

        static void Main(string[] args)
        {
            Program p = new Program(30,40);
            Console.ReadLine();


        }
    }
}
