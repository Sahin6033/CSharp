using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("4 reqemli eded daxil edin");
            int num =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(Convert.ToInt32( sumValues(num)));*/
            Console.WriteLine("4 reqemli eded daxil edin");
            string num = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(sumValues(num)));


            Console.ReadKey();
        }


        /* public static int sumValues(int num)
         {
             int sum = 0;
             for (int i = 0; i < 4; i++)
             {
                 sum += num % 10;
                 num /= 10;
             }


             return sum;
         }*/

        public static int sumValues(string num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum+= Int32.Parse(num[i].ToString());
                Console.WriteLine(Int32.Parse(num[i].ToString()));
            }


            return sum;
        }


    }
}
