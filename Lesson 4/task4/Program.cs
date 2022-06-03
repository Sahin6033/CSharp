using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yashinizi daxil edin :");
            int age  =  Convert.ToInt32(Console.ReadLine());

            if (age > 0 && age < 30)
            {
                Console.WriteLine(Math.Pow(age, 2));
            }
            else if (age < 40 && age > 30)
            {
                Console.WriteLine(age % 10);
            }
            else if (age < 0 || age > 100)
            {
                Console.WriteLine(" Duzgun melumat daxil etmemsiniz");
            }
        }
    }
}
