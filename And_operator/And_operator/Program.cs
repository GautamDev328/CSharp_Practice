using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace And_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 30;
            int y = 100;
            int sub = x - y;
            if (sub == 30 && sub == 20)
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("Hi");
            }
            Console.ReadLine();
        }
    }
}
