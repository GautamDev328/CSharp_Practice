using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float floatvalue;
           // float floatnumber;
            Console.WriteLine("Enter a floatValue: ");
            floatvalue = float.Parse(Console.ReadLine());
         //   floatnumber = float.Parse(Console.ReadLine());
            if(floatvalue%2.0 == 0)
            {
                Console.WriteLine("even");

            }
            else
            {
                Console.WriteLine("odd");
            }
            Console.ReadLine();

        }
    }
}
