using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_odd_using_whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctrl = 0;
            //int num;
            int Even = 0;
            int odd = 0;
            while (ctrl < 5)
            {
                Console.WriteLine("Enter a  number: ");
                 int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                    Even++;
                else
                    odd++;

                        ctrl = ctrl + 1;


            }
            Console.WriteLine(" Even Result: "+Even);
            Console.WriteLine(" Odd Result: "+odd);
            Console.ReadLine();
        }
    }
}
