using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refcallbyreferenceprogram
{
    internal class Program
    {

        void show(ref int shown)
        {
            shown *= shown;
            Console.WriteLine("reference of call by value:" + shown);

        }
        static void Main(string[] args)
        {
            int shown = 12;
            Program p = new Program();
            Console.WriteLine("value of reference" + shown);
            p.show(ref shown);
            Console.WriteLine("value of call by reference :" + shown);
            Console.ReadLine();
        }
    }
}
