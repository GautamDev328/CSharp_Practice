using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)// 9 tk chelga
            //for(int i=1;i<10;i++)//9tk chlega
            //if(i==10)//9 tk chlega
            {
                if (i == 10)// 9 tk chlege
                {
                    break;
                }
                Console.WriteLine("program done");
            }
            Console.ReadLine();
        }
    }
}
