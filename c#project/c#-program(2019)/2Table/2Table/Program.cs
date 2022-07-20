using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Table:");
            Console.Write("Enter a user first TableNumber:");
            int i;
           
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter a user last TableNumber:");
            int a;

            a = int.Parse(Console.ReadLine());
           Console.Write("End Table:");
           int n = int.Parse(Console.ReadLine());


            for (; i<=a; i = i+n)
            {
                Console.WriteLine("Serial table Number:" +i);
                
            }

            Console.ReadLine();
        }
    }
}
