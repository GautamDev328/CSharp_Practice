using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter a ArmstrongNumber program:");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("It is Armstrong Number:");
                Console.WriteLine("Thanks!");
            }
            else
            {
                Console.WriteLine("it is not Armstrong Number:");
                Console.WriteLine("No thanks!");
            }
            
            Console.ReadLine();
        }
    
        // same program is fabnoserries..
        /*output
         Enter a ArmstrongNumber program:
       121
      It is Armstrong Number:
         Thanks!
        Enter a ArmstrongNumber program:
            123
            it is not Armstrong Number:
           No thanks!
              Thanks!

        */


    }// same program is fabnoseries...
}
