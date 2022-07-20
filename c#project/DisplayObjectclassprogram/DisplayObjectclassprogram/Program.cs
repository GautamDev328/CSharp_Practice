using System;
namespace single
{
    internal class Program
    {
       public  int id;
       public  string name;
        void insert(int i, string n)
        {
            id = i;
            name = n;
        }
       public void display()
        {
            Console.WriteLine(id + " " + name);
        }
    }
        public class TestProgram { }
       public static void Main()
        {
        Program p = new Program();
        Program p2 = new Program();
        p.insert(102, "Amit");
        p2.insert(110, "Gautam");
        p.display();
        p2.display();
        console.ReadLine();
    }
  
    }
