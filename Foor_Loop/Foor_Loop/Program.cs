using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foor_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1;--i)// for(int i=1;i<=5;i++)
            {                           // {{
                for (int j = 1; j <= i; j++)// for(int j=1;j<=i;j++)
                                            //{
                {
                        Console.Write("*");// console.Write("*");
                    }
                    Console.WriteLine(); // console.WriteLine();
                }
                Console.ReadLine(); // console.ReadLine();
            }
        }
    }



