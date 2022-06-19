using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCharIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindCharIndex("salam",'z'));
        }
        public static int FindCharIndex(string word, char symbol)
        {
            
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    return i;
                    

                }
            }
            return -1;
        }
    }
}
