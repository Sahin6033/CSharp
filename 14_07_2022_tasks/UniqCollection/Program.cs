using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,string> list = new SortedList<int, string>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"id = {i}: add string value");
                list.Add(i, Console.ReadLine());
            }

        
            foreach (KeyValuePair<int, string> i in list)
            {
                Console.WriteLine(i);   
            }


        }
    }
}
