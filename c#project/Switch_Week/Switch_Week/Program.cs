using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a user Week:");
            string week = Console.ReadLine();
            switch (week)
            {
                case "sunday":

                    Console.WriteLine("7");
                    break;
                case "monday":
                    Console.WriteLine("1");
                    break;
                case "tuesday":
                    Console.WriteLine("2");
                    break;
                case "wednesday":
                    Console.WriteLine("3");
                    break;
                case "thursday":
                    Console.WriteLine("4");
                    break;
                case "friday":
                    Console.WriteLine("5");
                    break;
                case "saturday":
                    Console.WriteLine("6");
                    break;
                default:
                    Console.WriteLine("invalid week day");
                    break;

                   

            }
            Console.ReadLine();
        }
    }
}
