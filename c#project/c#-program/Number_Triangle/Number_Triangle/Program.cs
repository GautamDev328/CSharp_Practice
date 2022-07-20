using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l, n;
            Console.WriteLine("Enter a Range= ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for (k =1; k<= i; k++)
                {
                    Console.Write(k);
                }
                for (l = i - 1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
/*
 * Enter a Range=
      5
    1
   121
  12321
 1234321
123454321
*/