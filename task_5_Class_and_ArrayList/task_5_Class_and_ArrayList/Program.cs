using System;
using System.Collections.Generic;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5_Class_and_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList books = new ArrayList();
            int keyCode = 0;
            while (keyCode != 27)
            {
                Console.WriteLine(" Search ==> 1");
                Console.WriteLine(" Create ==> 2");
                int keycode2 = 0;
                ConsoleKey key1 = Console.ReadKey().Key;
                Console.WriteLine();
                keycode2 = (int)key1;


                Console.WriteLine("----------------------------");
                if (keycode2 == 97 || keycode2 == 49)
                {
                    Console.WriteLine("Select : 1");
                    Console.WriteLine("================ Search Book ==============");
                    Console.WriteLine("Search Book Name: ");
                    string search = Console.ReadLine();

                    SearchByBookNmae(books, search);

                }
                else if (keycode2 == 98 || keycode2 == 50)
                {
                    Console.WriteLine("Select : 2");
                    Console.WriteLine("================ Create Book ==============");
                    Console.Write("Book Name :");
                    string bn = Console.ReadLine();
                    Console.Write("Book PageSize :");
                    int ps = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Book Price :");
                    double pr = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Book AuthorName :");
                    string auth = Console.ReadLine();
                    Book book = new Book(bn, ps, pr, auth);
                    books.Add(book);    
                }



                Console.WriteLine("Press any key for continue the prossess !!!\n Press ESC for exit");
                ConsoleKey key2 = Console.ReadKey().Key;
                keyCode = (int)key2;

            }

        }

        public static void SearchByBookNmae(ArrayList al, string bn)
        {
            foreach (Book b in al)
            {
                if (b.Name.Contains(bn))
                {
                    Console.WriteLine("=============");
                    Console.WriteLine($"Book Name : {b.Name}");
                    Console.WriteLine($"Book PageSize : {b.PageSize}");
                    Console.WriteLine($" Book Price : {b.Price}");
                    Console.WriteLine($"Book AuthorName : {b.AuthorName}");

                }
            }
        }
    }
}
