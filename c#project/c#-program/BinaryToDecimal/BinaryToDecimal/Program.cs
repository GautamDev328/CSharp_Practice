using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, binVal, decval = 0, baseval = 1, rem;
            //  n = 102;
            Console.WriteLine("Enter a  Binary to decimal: ");
            n = int.Parse(Console.ReadLine());
            binVal = n;
            while (n > 0)
            {
                rem = n % 10;
                decval = decval + rem * baseval;
                n = n / 10;
                baseval = baseval * 2;
            }
            Console.WriteLine("Binary Number: " + binVal);
            Console.WriteLine("Decimal: " + decval);
            Console.ReadLine();
        }
    }
}
/*output:
 * Enter a  Binary to decimal:
124
Binary Number: 124
Decimal: 12*/
