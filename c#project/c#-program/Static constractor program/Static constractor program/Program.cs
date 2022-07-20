using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_constractor_program
{
    internal class Program
    {
        public static float pi = 8.55f;
        public static int cube(int n)
        {
            return n * n * n;
        }
    }
    class Test { 

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a cube Program:");
            Console.WriteLine("Value of Pi:" + Program.pi);
            Console.WriteLine("cube of 3is:" + Program.cube(4));
            Console.ReadLine();
        }
        
        }
    }

