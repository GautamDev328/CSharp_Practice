using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_user_tale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a table:");
            Console.Write("Enter a user first table Number:");
            int i;
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter a user last table number:");
            int a;
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter a finalNumber :");
            int c;
            c = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("serial Table Number:" + i);
                i = i + c;
            } while (i <= a);
            Console.ReadLine();

        }
    }
}
