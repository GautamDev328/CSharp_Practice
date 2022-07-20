using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    public class Program
    {
        public  void show()
        {

        }
        public  void show(int x)
        {
            Console.WriteLine("india");
        }
        public  void show(int x,int y)
        {
            Console.WriteLine("Bharat");
        }
        public void show(int x,int y,int z)
        {
            Console.WriteLine("MahaBharat");
        }
        public void show(int x,int y,int z,string m)
        {
            Console.WriteLine("hindustan");

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.show();
            p.show(0);
            p.show(0, 1);
            p.show(0, 1, 2);
            p.show(0,1, 2,"3");
            Console.ReadLine();

            }
        }
    }