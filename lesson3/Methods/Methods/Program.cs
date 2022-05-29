using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a :");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b :");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter c :");
            double c = Convert.ToDouble(Console.ReadLine());

            SquareEquality(a,b,c);
        }

        public static void SquareEquality(double a, double b, double c)
        {
            if (a != 0)
            {
                double D = b * b - (4 * a * c);
                if (D < 0)
                {
                    Console.WriteLine("The equation has no root");
                }
                else if (D == 0)
                {
                    Console.WriteLine("x = " + (b * b) / (2 * a));
                }
                else
                {
                    Console.WriteLine("x1 = " + ((b * b) - Math.Sqrt(D)) / (2 * a));
                    Console.WriteLine("x2 = " + ((b * b) + Math.Sqrt(D)) / (2 * a));
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"It is a linear equation  : {-c / b}");
            }



        }
    }
}



              

       


