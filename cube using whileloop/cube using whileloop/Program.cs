using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cube_using_whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctrl = 0;
            int num;
            int count = 0;
            while (ctrl < 5)
            {
                Console.WriteLine("Enter a number:");
                num =covert.ToInt32( console.ReadLine());
                if (num * num * num > 100)
                    count++;

                ctrl = ctrl + 1;
            }
            Console.WriteLine("count values:" + count);
            Console.ReadLine();
        }
      
    }
}
