using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typecastingprogram_implicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int x = 888;
           // double xx = x;
           /* Console.WriteLine(xx);
            Console.ReadLine();*/
      double y = 88.90;
            int yy = (int)y;
            Console.WriteLine(yy);
            Console.ReadLine();
        }
    }
}
