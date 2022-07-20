using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a age:");
            Console.Write("Enter a first age :");
          
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter a difference age:");
            int a = int.Parse(Console.ReadLine());
            if (age == a)
            {
                Console.WriteLine("Age is Valid in Adharcard is  any profit the government");

            }
            else
            {
                Console.WriteLine(" Age is Invalid in Adharcard is not any profit the government");
            }
            Console.ReadLine();
        }
    }
}
