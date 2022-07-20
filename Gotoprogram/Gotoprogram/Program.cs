using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotoprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter a age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 15)
            {
                goto invValid;
            }
            else
            {
                Console.WriteLine(" invalid");
            }
            Console.ReadLine();
        }
    }
}
