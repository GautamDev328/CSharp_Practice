using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_Month
{
   // class MyNum { 
    enum Month
    {
        january,
        feburary,
        March,
        April,
        May,
        June,
        July,
        August,
        september,
        october,
        november,
        december
    }
   class MyNum
   {

        static void Main()
        {

            int myNum = (int)Month.september;
            Console.WriteLine(myNum);
        }
    }
}
