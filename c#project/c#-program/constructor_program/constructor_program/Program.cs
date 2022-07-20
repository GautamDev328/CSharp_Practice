using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_program
{
    public class Program
    {
        String Mon;
        String Tue;
        String Wed;
        String Thu;
        String Fri;
        String sat;
        String sun;
        public Program(String M, String T, String W, String Th, String F, String Sa, String S) { 
        
     Console.WriteLine ("Enter a 1st day:" + M + " \n" + "Enter a 2nd day: "+T+"\n"+"Enter a 3rd day:"+W+"\n"+"Enter a 4th day:"+Th+"\n"+"Enter a 5th day:"+F+"\n"+"Enter a 6th day:"+Sa+"\n"+"Enter a 7th day:"+S );



           /*  Console.WriteLine("Enter a  1st  day:" + M);
           Console.WriteLine("Enter   a  2nd  day:" + T);
           Console.WriteLine("Enter   a  3rd  day:" + W);
           Console.WriteLine("Enter   a  4th  day:"+ Th);
           Console.WriteLine("Enter   a  5th  day:"+  F);
           Console.WriteLine("Enter   a  6th  day:"+  Sa);
           Console.WriteLine("Enter   a  7th  day:"+  S);*/
        }
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter all weekday:");
                Program p = new Program("Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday");
                Console.ReadLine();
            }
        }
    } 
}
