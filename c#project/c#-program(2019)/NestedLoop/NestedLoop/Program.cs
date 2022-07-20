using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Entr a second Number:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter a third Nmber:");
            int c = int.Parse(Console.ReadLine());
            if((a>=b) && (b <= a))
            {
                Console.WriteLine("it is same");
            }
            else if((a<=c) || (a <= b))
            {
                Console.WriteLine("equal");
            }
            else if ((a >= c) && (b <= c))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadLine();

        }
    }
}
