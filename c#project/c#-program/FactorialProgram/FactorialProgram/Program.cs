using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, num;
            Console.WriteLine("Enter a message:");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("fact :"+" " + num +" "+"is :"+" " + fact);
        }
    }
}    