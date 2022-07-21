using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptek
{
    internal class Medicine
    {
        public string Name;
        public double Price;
        public int Count = 0;
       private static int counter = 0;
        public int Id;
         


        public Medicine(string name, double price, int count)
        {
            Name = name.ToUpper();
            Price = price;
            Count = count;
            Id = counter++;

        }

    }
}
