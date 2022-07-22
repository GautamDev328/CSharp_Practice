using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyconstructor
{
    public  class Program
    {
        int id;
        string name;
        int date_of_birth;
        public Program(int i,string n, int dob)
        {
            Console.WriteLine("Hello india");
        }
        public Program(Program p)
        {
            Console.WriteLine("hi");
        }
       
        static void Main(string[] args)
        {
            Program p = new Program(101,"Gautam",07-03-1998);
            Program p2 = new Program(p);
            Console.ReadLine();

          
        }
    }
}
