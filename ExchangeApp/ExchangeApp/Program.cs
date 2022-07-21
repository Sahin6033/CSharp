using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string req = "";
            while (req != "n" && req != "N")
            {
                Console.WriteLine("Exchange emeliyyatini secin");
                Console.WriteLine("1: AZN to USD");
                Console.WriteLine("2: AZN to EUR");
                Console.WriteLine("3: AZN to TR");
                Console.WriteLine("4: USD TO AZN");
                Console.WriteLine("5: EUR TO AZN");
                Console.WriteLine("6: TR TO AZN");
                int changeNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cevirmek istediyiniz  meblegi yazin");
                double money = Convert.ToDouble(Console.ReadLine());
                switch (changeNum)
                {
                    case 1:
                        ValutaExchanger.Exchange(CurrencyType.USD, money);
                        break;
                    case 2:
                        ValutaExchanger.Exchange(CurrencyType.EUR, money);
                        break;
                    case 3:
                        ValutaExchanger.Exchange(CurrencyType.TR, money);
                        break;
                    case 4:
                        ValutaExchanger.ExchangeRev(CurrencyType.USD, money);
                        break;
                    case 5:
                        ValutaExchanger.ExchangeRev(CurrencyType.EUR, money);
                        break;
                    case 6:
                        ValutaExchanger.ExchangeRev(CurrencyType.TR, money);
                        break;
                    default:
                        Console.WriteLine("Ele secim movcud deyil");
                        break;



                }

                Console.WriteLine("Yeniden Exchange emeliyyati etmek ucun Y duymesini basin \n !!! Eks halda N duymesini basin !!!");
                req = Console.ReadLine();
            }

            
        }
    }
}
