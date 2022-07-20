using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, rev = 0, rem;
            Console.WriteLine("Enter a Reverse program:");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n /= 10;

            }
            Console.Write("Reverse Number:" + rev);
        }
    }
}
/*output
 * Enter a Reverse program:
          12345
      Reverse Number:54321
*/

