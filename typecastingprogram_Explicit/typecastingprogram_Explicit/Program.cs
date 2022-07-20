using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typecastingprogram_Explicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Add Number:");
            Console.Write("Enter a firstNumber:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter  a secondNumber:");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter a Result:");
            int add = x + y;
            Console.WriteLine(add);
            Console.ReadLine();

        }
    }
}
