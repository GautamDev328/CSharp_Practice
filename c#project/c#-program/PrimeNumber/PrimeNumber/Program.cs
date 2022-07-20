using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n, i, m = 0, flag = 0;
            Console.WriteLine("Enter a prime number:");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Number is not prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is prime");
            Console.ReadLine();
        }
       
    }
}
/*output:
 Enter the Number to check Prime: 17  
Number is Prime.   
Enter the Number to check Prime: 57  
Number is not Prime.
//Enter a prime number:
12
Number is not prime*/