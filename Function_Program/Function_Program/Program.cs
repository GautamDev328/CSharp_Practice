using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Test
    {
       void so(int message)
        {
            Console.WriteLine("Hello " + message);
            // No return statement  
        }
        // Main function, execution entry point of the program  
        static void Main()
        {
             Test t=new Test(); // Creating Object  
            t.so(10);// Calling Function
            Console.ReadLine();
        }
       
    }
    }

