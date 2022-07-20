using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier
{
    public class Program
    {
        public void Test()
        {
            Console.WriteLine("guys");

        }
        private void Test1()
        {
            Console.WriteLine("hello India");
        }
        protected void Test2()
        {
            Console.WriteLine("hindu");
        }
        protected internal void Test3()
        {
            Console.WriteLine("hello");

        }
        internal void Test4()
        {
            Console.WriteLine("gautam");
        }
    }
    class Demo:Program
    {

        static void Main(string[] args)
        {
            Demo p = new Demo();
           // Program p = new Program();
            p.Test();
          / p.Test1();//private -other class me run nhi krta h wh apne class me hi only run krta h
          p.Test2(); //do
            p.Test3();
            p.Test4();
            Console.ReadLine();
        }

    }
}


