using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 reqemli eded daxil edin : ");
            int num = Convert.ToInt32(Console.ReadLine());
            SingleNumber(num);
        }

        public static void SingleNumber(int num)
        {
            
            for (int i = 0; i < 4; i++)
            {
                int newNum = num % 10;
                if ( newNum % 2 != 0)
                {
                    Console.WriteLine(newNum +" ");
                }
                num /= 10;
            }


            
        }
    }
}
