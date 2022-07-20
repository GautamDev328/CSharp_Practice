using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deciaml_To_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int [] a= new int[10];
            Console.WriteLine("Enter a Decial to Binary:");
            n = int.Parse(Console.ReadLine());
            for(i = 0; n>i; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.WriteLine("Binary of the given Number:");
            for( i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            
        }
    }
}
