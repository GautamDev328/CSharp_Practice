using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFELSELADDERAGE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if (b > c)
            {
                Console.WriteLine("b is greater than c");
            }
            else if (c > a)
            {
                Console.WriteLine("c is greater than a");
            }
            else if ((a < b) || (b < c))
            {
                Console.WriteLine(" larger number");
            }
            else
            {
                Console.WriteLine("INVALID AGE");
            }
                 Console.ReadLine();
        }
    }
}
