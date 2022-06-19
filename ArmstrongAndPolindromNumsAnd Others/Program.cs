using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 =Convert.ToInt32(Console.ReadLine());
            int num2 =Convert.ToInt32(Console.ReadLine());
            ArmstrongNumsInInterval(num1,num2);
            Console.WriteLine("+");
        }
        public static bool DivideBy2(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DivideBy3(int a)
        {
            if (a % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DivideBy7(int a)
        {
            if (a % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int SumAfter30(int a)
        {
            int result = 0;
            for (int i = 1; i < 30; i++)
            {
                result += (a + i);
            }
            return result;
        }
        public static bool SumDivideBy3(int a)
        {
            int sumOfNums = 0;
            while (a > 0)
            {
                sumOfNums += a % 10;
                a /= 10;
            }
            if (sumOfNums % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static int SubtractionAfter30(int a)
        {
            int start = a;
            int end = a - 30;
            for (int i = start; i <= end; i--)
            {
                a -= i;
            }
            return a;
        }
        public static long PowBy3(int a)
        {
            return a * a * a;
        }
        public static long MultiplicationAfter30(int a)
        {
            int start = a;
            int end = a + 30;
            long powNums = 1;
            for (int i = start; i <= end; i++)
            {
                powNums *= i;
            }
            return powNums;
        }
        public static bool isPolindrom(int a)
        {
            int numLenght = a.ToString().Length-1;
           
            int beforeNum = a;
           
            int afterNum = 0;
            while (beforeNum > 0)
            {
                afterNum += beforeNum%10 * Convert.ToInt32(Math.Pow(10, numLenght));
                beforeNum /= 10;
                numLenght--;
            }
            
            
            Console.WriteLine(a);
            Console.WriteLine(afterNum);
            if (a == afterNum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void ArmstrongNumsInInterval(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                int num = i;
                int arm = 0;
                int numLenght = i.ToString().Length;
                while (num > 0)
                {
                    arm += Convert.ToInt32(Math.Pow(num % 10, numLenght));
                    num /= 10;
                }
                if(arm == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
