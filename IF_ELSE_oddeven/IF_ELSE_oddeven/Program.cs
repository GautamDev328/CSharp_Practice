using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_oddeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Even number:" + a);
            }
            else
            {
                Console.WriteLine("Odd number:" + a);
            }
            Console.ReadLine();
        }
    }
}
