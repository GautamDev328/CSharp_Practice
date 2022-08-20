using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_using_whilellop
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctrl = 1;
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            while (ctrl < 10)
            {
                Console.WriteLine(num+"*"+ctrl+ " = "+ ctrl*num);

                ctrl = ctrl + 1;

            }
            Console.ReadLine();
        }
    }
}
