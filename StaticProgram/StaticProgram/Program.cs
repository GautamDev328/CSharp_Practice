using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProgram
{
    public static class Program
    {
        static Program()
        {
            Console.WriteLine("hello india");
        }
         int x = 20;
        
        static void sum()
        {
            Console.WriteLine("hi");
            Console.ReadLine();
        }
        static void sum2()
        {
            Console.WriteLine("hello");
            Console.ReadLine();
        }
        static void Main()
        {
            Console.WriteLine("INDIA");
            Program.sum();
            Program.sum2();
            Console.WriteLine(Program.x);
            Console.ReadLine();
           

        }

    }
}
