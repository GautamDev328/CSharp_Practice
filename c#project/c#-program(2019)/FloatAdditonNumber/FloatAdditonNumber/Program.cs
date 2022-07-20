using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatAdditonNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a all operator float type:");
            Console.Write("Enter a first float Number:");
            float f = float.Parse(Console.ReadLine());
            Console.Write("Enter a second float Number:");
            char g = char.Parse(Console.ReadLine());
            float ee = (float)g;
            Console.Write("Enter a third flaot Number:");
            int a = int.Parse(Console.ReadLine());
            float h = (float)a;
            Console.WriteLine("Enter a Result :");
            Console.WriteLine("Enter a Add:" + (f + ee));
            Console.WriteLine("Enter a substract:" + (ee - h));
            Console.WriteLine("Enter a multiplication :" + (f * h));
            Console.WriteLine("Enter a divide :" + (f / h));
            Console.WriteLine("Enter a modulus:" + (ee % f));
            Console.ReadLine();
            
        }
    }
}
