using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callbyvalueprogram
{
    internal class Program
    {
        void show(int message)
            {
                message *= message;
                Console.WriteLine("Value of message" + message);
            }
            static void Main()
            {
                int message = 100;
                Program p = new Program();
                Console.WriteLine("message value" + message);
                p.show(message);
                Console.WriteLine("value message pass:" + message);
            Console.ReadLine();
            }
        }
    }
    
