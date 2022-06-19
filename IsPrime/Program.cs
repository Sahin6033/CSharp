using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(17));
            Console.WriteLine(IsPrime(18));

        }
        public static bool IsPrime(int number)
        {
            int div = 0;
            for (int i = 2; i < number/2+1; i++)
            {
                if(number%i == 0)
                {
                    div++;
                }
            }
            if (div > 0)
            {
                return false;
            }
            else
            {
                return true;    
            }

        }
    }
}
