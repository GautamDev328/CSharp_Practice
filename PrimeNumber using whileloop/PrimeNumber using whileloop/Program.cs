using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber_using_whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 2, num, flag = 1;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            int ctrl = 0;
            int num1;
            int count1 = 0;
            while (ctrl > 5)
            {
                Console.WriteLine("Enter a number");
                num1 = int.Parse(Console.ReadLine());
                if (num1 * num1 * num1 > 100)
                    //   count++
                

            while (count < num / 2)
                    {
                        if (num % count == 0)
                        {
                            Console.WriteLine("Not prime");
                            flag = 1;
                            break;

                        }

                        if (count1 == 0)


                            Console.WriteLine("prime Number");

                        count = count + 1;



                    }
                count++;
            }
            Console.WriteLine("count values:"+ count);
            Console.ReadLine();
          
        }
    }
}

