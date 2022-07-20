using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a input Number:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.Write("Even Number");
            else
                Console.Write("odd Number");
            Console.ReadLine();
        }
      


    }
}
