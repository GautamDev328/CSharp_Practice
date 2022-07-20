using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace SwitchCase_Month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a week :");
            String Week = Console.ReadLine();
            switch (Week)
            {
                case "monday":
                    Console.WriteLine("Monday");
                    break;
                case "tuesday":
                    Console.WriteLine("Tuesday");
                    break;
                case "wednesday":
                    Console.WriteLine("wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("Thursday");
                    break;
               case "Friday":
                    Console.WriteLine("Friday");
                    break;
                case "saturday":
                    Console.WriteLine("saturday");
                        break;
                case "sunday":
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Week");
                    break;
            }
            Console.ReadLine();
        }
    }
}
