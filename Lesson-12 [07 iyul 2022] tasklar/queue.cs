using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            int keyCode = 0;
            
            
            while (keyCode != 27)
            {
                
                
                
                if(q.Count > 10)
                {
                    q.Dequeue();
                    Console.WriteLine("Reqem daxil edin");
                    int n = Convert.ToInt32(Console.ReadLine());
                    q.Enqueue(n);   
                }
                else
                {
                    Console.WriteLine("Reqem daxil edin");
                    int n = Convert.ToInt32(Console.ReadLine());
                    q.Enqueue(n);
                }

                Console.WriteLine("Davam etm'k ucun istenilen duymeni bas;n \n axtarishi dayand;rmaq ucun ESC duymesini basin");
                
                ConsoleKey key = Console.ReadKey().Key;
                keyCode = (int)key;
                Console.WriteLine();
            }

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

        }
    }
}
