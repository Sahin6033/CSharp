using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable countries = new Hashtable();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Olke adini qeyd edin");
                string country = Console.ReadLine().ToUpper();
                Console.WriteLine("Seher adini qeyd edin");
                string city = Console.ReadLine().ToUpper();
                countries.Add(country, city);
            }
            Console.WriteLine();
            int keyCode = 13;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Axtarish sozunu yazin");
                string search = Console.ReadLine();
                SearchCapitalOfCountry(countries, search);
                Console.WriteLine("Davam etm'k ucun istenilen duymeni bas;n \n axtarishi dayand;rmaq ucun ESC duymesini basin");
                ConsoleKey key = Console.ReadKey().Key;
                keyCode = (int)key;
                Console.WriteLine();
            } while (keyCode != 27);

        }
        public static void SearchCapitalOfCountry(Hashtable ctr, string countryS)
        {
            countryS = countryS.ToUpper();

            if (countryS == "ALL")
            {
                foreach (DictionaryEntry de in ctr)
                {
                    Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
                }
            }
            else
            {

                Console.WriteLine("axtarishion neticesi  : "+ctr[countryS]);
            }
        }

    }
}
