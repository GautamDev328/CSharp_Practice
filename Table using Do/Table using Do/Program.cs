using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_using_Do
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine(i);
                i = i + 2;

            } while (i <= 20);
                Console.ReadLine();
        }
    }
}
