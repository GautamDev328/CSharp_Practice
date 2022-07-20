using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Number_to_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0, r;
            Console.WriteLine("Enter a Number to character:");
            i = int.Parse(Console.ReadLine());
            while (i > 0)
            {
                r = i % 10;
                sum = sum * 10 + r;
                i = i / 10;

            }
            i = sum;
            while (i > 0)
            {
                r = i % 10;
                switch (r)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    default:
                        Console.WriteLine("Invalid convert number to character:");
                        break;
                }
                i = i / 10;

            }
            Console.ReadLine();
        }
    }
}
