using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, i, c, n, j;
            Console.Write("Enter the Fibonacci Triangle: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                a = 0;
                b = 1;
                Console.Write(b + "\t");
                for (j = 1; j < i; j++)
                {
                    c = a + b;
                    Console.Write(c + "\t");
                    a = b;
                    b = c;
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
/* output:Enter the Fibonacci Triangle: 5
1
1       1
1       1       2
1       1       2       3
1       1       2       3       5
*/
