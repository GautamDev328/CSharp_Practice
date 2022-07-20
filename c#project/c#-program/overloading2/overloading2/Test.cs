using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading2
{
    internal class Test

    {
        public static void Main()
        {

            Program P = new Program();
            P.show();
            P.show(0, 1);
            P.show(0, 1, "2");
            Console.ReadLine();
        }

    }
}

