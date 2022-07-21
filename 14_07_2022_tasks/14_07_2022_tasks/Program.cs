using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_07_2022_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                nums.Add(i);
            }
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Replace5Elements(nums);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

        }

        public static void Replace5Elements(List<int> num)
        {
            int maxIndex = num.Count - 1;
            for (int i = 0; i < 5; i++)
            {
                int temp   = num[i];
                num[i] = num[5 + i];
                num[5 + i] = temp;
            }
        }
    }
}
