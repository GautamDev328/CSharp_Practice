using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Program
    {
        void show(string message)
        {
            Console.WriteLine("Hi body");
            return message;
        }
        static void Main()
        {
            Program p = new Program();
            string message = p.show("hello");
            Console.WriteLine("hi" + message);
            Console.ReadLine();
        }
    }
}

