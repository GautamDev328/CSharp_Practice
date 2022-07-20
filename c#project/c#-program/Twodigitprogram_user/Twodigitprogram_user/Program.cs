using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twodigitprogram_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0,m;
            Console.WriteLine("Enter a Number:");
            n = int.Parse(Console.ReadLine());
            while(n > 0){
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.WriteLine("Sum is:" + sum);
        }
      
    }
}
/*output:
  Enter a Number:
1234
Sum is:10
Press any key to continue . . .

 */
