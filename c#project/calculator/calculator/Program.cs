using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a  number : ");
            int num = Convert.ToInt32 (Console.ReadLine());
        

            switch(num)
            {
                case 1:
                    int a = 10;
                    int b = 20;
                    Console.WriteLine(a + b);  break;

                case 2:
                    int c = 20;
                    int d = 12;
                    Console.WriteLine(c-d);
                      break;
                case 3: int e = 22;
                    int  f= 10;
                    Console.WriteLine(e-f);  break;
                default :
                    Console.WriteLine("it is default "); break;
                  
            }

          
        }
    }
}
