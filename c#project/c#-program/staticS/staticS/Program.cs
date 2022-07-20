using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticS
{
    public class Account
    {

        public int accno;
        public String name;
        public static float rateOfInterest;
        public Account(int accno, String name)
        {
            this.accno = accno;
            this.name = name;
        }
         static Account() {
             rateOfInterest=10.4f;
    } 

        public void display()
        {
            Console.WriteLine(accno + " " + name + " " + rateOfInterest);
        }
    }
    class TestAccount
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account(101, "Sonoo");
            Account a2 = new Account(102, "Mahesh");
            Account a3 = new Account(103, "Gautam");
            a1.display();
            a2.display();
            a3.display();
            Console.ReadLine();

        }
    }
}
