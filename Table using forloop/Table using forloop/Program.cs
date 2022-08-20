using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_using_forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            for (; i <= 20; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
