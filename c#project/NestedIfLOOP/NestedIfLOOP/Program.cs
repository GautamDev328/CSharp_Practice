using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIfLOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 40;
            int add = x + y;
            int sub = x - y;
            if (add == 50 && sub == 30)
            {
                Console.WriteLine("Android");

            }
            else
            {
                Console.WriteLine("PLEASE");
            }
            {
                if (add == sub)
                {
                    Console.WriteLine("Android");
                }
                else
                {
                    Console.WriteLine("window");
                }
                Console.ReadLine();
            }
        }
    }
}
