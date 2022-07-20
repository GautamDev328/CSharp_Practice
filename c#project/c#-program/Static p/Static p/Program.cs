using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_p
{
    public class Program
    {
        public int id;
        public String name;
        public String fathername;
        public static float rateofinterest;
        public Program(int i, String n, String fn)
        {
             id = i;
             name = n;
             fathername = fn;
            // Console.Write("hi");
          //  Console.WriteLine(i + " " + n + " " + fn + " " + rateofinterest);
        }
        static Program()
        {
             rateofinterest = 99.5f;
        }
        public void show()
        {
             Console.WriteLine(id + " " + name + " " + fathername+" "+rateofinterest);
          //  Console.WriteLine(i + " " + n + " " + fn + " " + rateofinterest);
        }
        static void Main()
        {
            Program p = new Program(102, "Gautam Dev", "Bhashkar Bihar");
            Program p1 = new Program(104, "Anmol", "Ashok Kumar shirvastav ");
            Program p2 = new Program(105, "Anushka", "Ashok kumar");
           p.show();
            p1.show();
            p2.show();
            Console.ReadLine();

        }
    }
}

     