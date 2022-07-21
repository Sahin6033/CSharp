using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApp
{
    enum CurrencyType
    {
        EUR,
        USD,
        TR
    }
    internal  class ValutaExchanger
    {

        public static Dictionary<CurrencyType, double> Curencies = new Dictionary<CurrencyType, double>()
      {
          {CurrencyType.USD,1.70},
          { CurrencyType.TR,0.096},
          {CurrencyType.EUR,1.73 }

      };

        public static void Exchange(CurrencyType ctype, double money)
        {
            double exchanged = money * Curencies[ctype];
            Console.WriteLine(money+ " AZN to "+ctype +" = "+ exchanged);
        }
        public static void ExchangeRev(CurrencyType ctype, double money)
        {
            double exchanged = money /Curencies[ctype];
            Console.WriteLine(money + " "+ctype + "to AZN   = " + exchanged);
        }

    }

   
    
}
