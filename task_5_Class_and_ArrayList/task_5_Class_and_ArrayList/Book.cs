using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5_Class_and_ArrayList
{
    internal class Book
    {
        private static int stId = 1;
        public int Id;
        public string Name;
        public int PageSize;
        public double Price;
        public string AuthorName ;
        public Book(string n,int ps, double p)
        {
            this.Name = n;
            this.PageSize = ps;
            this.Price = p;
            this.Id = stId++;
        }

        public Book(string n, int ps, double p ,string an)
        {
            this.Name = n;
            this.PageSize = ps;
            this.Price = p;
            this.AuthorName = an;
            this.Id = stId++;
        }


    }
}
