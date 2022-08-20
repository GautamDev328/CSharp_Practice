using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialProgram_using_whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctrl = 1, fact = 1;
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            while (ctrl < 5)
            {
                fact = fact * ctrl;
                ctrl++;
            }
            Console.WriteLine("fact is:"+num+"is:"+ fact);
            Console.ReadLine();
        }
    }
}
