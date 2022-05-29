using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
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
            double radius;
            if(TriangleExistenceCondition(a, b, c))
            {
                radius =  FindRadius(a, b, c);
                Console.WriteLine($"Radisu  =\t {radius}");
                Console.WriteLine($"Area of e circle  =\t {AreaOfCircle(radius)}");
                Console.WriteLine($"Perimetr of e circle  =\t {PerimetrOfCircle(radius)}");



            }
            else
            {
                Console.WriteLine("Triangle does not exist");
            }
            

        }
        public static bool TriangleExistenceCondition (double a,double b ,double c)
        {
            bool condision = true;
            if(a+b <= b || a+c <=b || b+c<=a)
            {
                condision = false;
            }
            return condision;
        }

        public static double FindRadius(double a, double b, double c)
        {

            double p = (a + b + c) / 2;
            double radius = Math.Sqrt(((p-a)*(p-b)*(p-c))/p);

            return radius;
        }

        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI*Math.Pow(radius, 2);  
            return area;
        }

        public static double PerimetrOfCircle(double radius)
        {
            double perimetr =2* Math.PI *radius;
            return perimetr;
        }
    }
}
