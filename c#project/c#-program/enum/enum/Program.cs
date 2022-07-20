using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
 class Program
    {
        enum Level
        {
            Low,
            medium,
            High
        }
        static void Main(string[] args)
        {
            Level myVar = Level.medium;
            Level myvar1 = Level.Low;
            Level myvar2 = Level.High;
            Console.WriteLine(myVar);
            Console.WriteLine(myvar1);
            Console.WriteLine(myvar2);
        }
    }
}
