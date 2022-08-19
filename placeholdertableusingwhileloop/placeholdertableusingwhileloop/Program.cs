using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace placeholdertableusingwhileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a  number");
            int num = Convert.ToInt32(Console.ReadLine());

            int ctrl = 1;
            while (ctrl <=10)
            { 
                 Console.WriteLine( num +" * "+ctrl + " = "+ ctrl *num);
                  ctrl = ctrl + 1;

            }
            Console.ReadLine();
        }
    }
}
