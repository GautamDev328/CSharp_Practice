﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciseriesusingwhileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i = 2, num;
            Console.WriteLine("Enter a number:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(n1 + " " + n2 + " ");
            while (i < num)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
                i = i + 1;


            }
            Console.ReadLine();

        }
    }
}