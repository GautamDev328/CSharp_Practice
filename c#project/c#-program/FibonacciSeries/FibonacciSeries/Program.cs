using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3,i,Num;
            Console.WriteLine("Enter a FibonacciSeries:");
             Num = int.Parse(Console.ReadLine());
            Console.WriteLine(n1 + " " + n2);
            for (i = 2; i <= Num; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + "");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
            




        }
    }
}
/*output:
//Enter a FibonacciSeries:
10
0 1
1
2
3
5
8
13
21
34
55*/