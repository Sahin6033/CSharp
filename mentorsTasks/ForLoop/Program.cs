using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vurma cedveli

            
           int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int pow = 1;
            for (int i = 1; i <= number; i++)
            {

                sum += i;
                pow *= i;
               
            }
            Console.WriteLine(pow - sum);

            
           

        }

        
    }
}
