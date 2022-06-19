using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characterCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Proqramalaşdırma nə qədər çox şey bildiyinizlə yox, bildiyinizlə ortaya çıxardığınız işlərlə maraqlanır";
            string str2 = "hh h d";
            CharacterCount(str);
            CharacterIsNotWhiteCount(str);
            string[] vs = WordsToArray(str2);
            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine(vs[i]);
            }
        }
        public static void CharacterCount (string str)
        {
            int count  = 0; 
            foreach (char c in str)
            {
                count++;    
            }
            Console.WriteLine(count);
        }

        public static void CharacterIsNotWhiteCount(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c != ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public static int WhiteSpase(string str)
        {
            int count = 0;
            foreach (var item in str)
            {
                if(item == ' ')
                {
                    count++;
                }
                
            }
            return count;
        }

        public static string[] WordsToArray(string str)
        {
            string[] words = new string[WhiteSpase(str) +1];
            int index = 0;
            int arrayIndex = 0;
            for (int i = 0; i < str.Length; i++)
            {

            
                if (str[i] == ' ')
                {
                    words[arrayIndex] = str.Substring(index, i);
                    index = i ;
                    arrayIndex++;
                }
            }
            words[arrayIndex] = str.Substring(index,str.Length-1);

            return words;

        }


    }
}
