using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number  = Convert.ToInt32(Console.ReadLine());  
            PrintNumbersOfNumber(number);
            Console.WriteLine();
           int[] arr =  ReturnArrayOfNumbers(number);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void PrintNumbersOfNumber(int number)
        {
          
        }

        public static int[] ReturnArrayOfNumbers(int number)
        {

            List<int> numList = new List<int>();
            while (number != 0)
            {
                numList.Add(number % 10);
                number /= 10;
            }  while(number != 0)
            {
                Console.WriteLine(number%10);
                number/=10; 
            }
            int[] arrOfNumbesr = numList.ToArray();

            return arrOfNumbesr;
        }
    
    }
}
