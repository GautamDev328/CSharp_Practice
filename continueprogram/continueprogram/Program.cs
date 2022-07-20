using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continueprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 50; i++)
            {
                if (i == 40)// 40 ko skip kr ke aage badna h 50 tk

                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
