using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outofparameterprogramin_square
{
    internal class Program
    {
        void show(out int message)
        {
            int square = 10;
            message = square;
            message *= message;
        }
        static void Main(string[] args)
        {
            int message = 10;
            // Console.WriteLine("value of out of parament:" + message);
            Program pro = new Program();
            Console.WriteLine("value of out of parament:" + message);
            pro.show(out message);
                
                Console.WriteLine("value of parameter:" + message);
                Console.ReadLine();
            
        }
    }
}
