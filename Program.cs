using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppercaseProgram
{
    class Program
    {
        static void upperchar()
        {
            string s1;
            char ch;
            Console.WriteLine("Enter string:");
            s1 = Console.ReadLine();
          int  l = s1.Length;
            for ( int i = 0; i < l; i++)
            {
                ch = s1[i];
                if (char.IsLower(ch))

                    Console.Write(char.ToUpper(ch));

                else
                    Console.Write(ch);
            }
        }
        static void Main(string[] args)
        {
           upperchar();
            Console.ReadLine();
        }
    }
}
