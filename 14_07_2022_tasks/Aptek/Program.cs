using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pharmacy ph = new Pharmacy();
            ph.AddMedicine("pencilpn", 100, 4);
            ph.AddMedicine("pencilin", 2.36, 4);

            ph.FindMedicineByName("pen");
            ph.Sell("pencilpn", 5);
            ph.Sell("pencilpn", 5);
            ph.Sell("pencilpn", 5);
            ph.Sell("pencilpn", 5);
            ph.TotalIncome();
        }
    }
}
