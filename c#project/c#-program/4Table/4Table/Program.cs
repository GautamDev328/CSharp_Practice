using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a table:");
           // int Number, Mult;
           // Number = int.Parse(Console.ReadLine());
            for (int Mult = 3; Mult <= 30; Mult= Mult+3)
               // for(int Mult=1;Mult<=10;Mult++)
            {
                // Console.WriteLine("{0}*{1}={2}", Number, Mult, (Number * Mult));
                Console.WriteLine(Mult);
            }
            Console.WriteLine("thanks");
            Console.ReadLine();
          

            }
           

        }
    }
