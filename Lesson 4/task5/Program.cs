using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[15];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1,100);  
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            
            Console.WriteLine("  Max value: "+MaxInArray(arr));
            Console.WriteLine("  Mix value: " + MinInArray(arr));


        }

        public static int MaxInArray(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int MinInArray(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
