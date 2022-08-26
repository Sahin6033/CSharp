using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KassaDelegete.ValutaExchanger;

namespace KassaDelegete
{

    public static class ValutaExchanger
    {
        public delegate double EcxchangerDelegare(double value, CurrencyType currency);

        public static double Converter(double value, CurrencyType currency)
        {
            switch (currency)
            {
                case CurrencyType.EUR:
                    return value / 1.74;
                    break;
                case CurrencyType.USD:
                    return value / 1.70;
                    break;
                case CurrencyType.TRY:
                    return value / 0.11;
                    break;
                default:
                    return value;
                    break;
            }
        }


    }
    public enum CurrencyType
    {
        EUR,
        USD,
        TRY
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EcxchangerDelegare Exch  = (ValutaExchanger.Converter);
            double value = 100;
            Console.WriteLine(Exch(value, CurrencyType.TRY));
        }
    }
}
