using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladderi_elseif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 234;
            int b = 223;
            int add = a + b;
            int mult = a * b;
            if ((add == a && add == b) || (add == b || mult == a))
            {
                Console.WriteLine("Hello");

            }
            else if (mult == add || add == 234)
            {
                Console.WriteLine("Hi");
            }
            else if ((add == 234 && add == 457) || ((a == b) || (b == 220)))
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                if (add == 230 && mult == 223)
                {
                    Console.WriteLine("region");
                }

                else if (a == 234 && b == 223)
                {
                    Console.WriteLine("ok");
                }
                else if (mult == add || add == 223)
                {
                    Console.WriteLine("false");
                }

                Console.ReadLine();
            }
        }
    }
}
