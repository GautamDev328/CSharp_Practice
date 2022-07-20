using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProgram_whileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 1;
            while (i <= 10) {
     
               // Console.Write("*");
                // Console.WriteLine();
                i++;

                while (j <= i)

                    Console.Write("*");
                // Console.WriteLine();
                j++;


                Console.ReadLine();

            }
        }
    }
}