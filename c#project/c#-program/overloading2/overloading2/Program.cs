using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading2
{
    public class Program
    {
        public void show()
        {
            Console.WriteLine("hi");
        }
        public void show(int x, int y)
        {
            Console.WriteLine("Internet");
        }
        public void show(int x, int y, string z)
        {
            Console.WriteLine("Gautam");
        }
       /* class Test
        {
           public static void Main()
            {
                Program p = new Program();
                p.show();
                p.show(0, 1);
                p.show(0, 1, "2");
                Console.ReadLine();
            }



        }*/
    }
}
