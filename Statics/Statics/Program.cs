using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    public static class Data { 
    static Data()
    {
        Console.WriteLine("Hi");
    }
    static void Test()
    {
        Console.WriteLine("India");
    }


    class Book
    {
        static void Main()
        {

            // Program.Test();

            Data.Test();
            Console.WriteLine("I am fine");
            Console.WriteLine("I am also fine");
            Console.ReadLine();
        }
    }
}
}
