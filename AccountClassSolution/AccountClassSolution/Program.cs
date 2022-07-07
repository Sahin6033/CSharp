using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClassSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> Accounts = new List<Account>();

            Account acc1 = new Account("Shahin", "Aa123456");
            Account acc2 = new Account("Shahin2", "2A123456");
            Account acc3 = new Account("Shahin3", "3Aa123456");
            Accounts.Add(acc1);
            Accounts.Add(acc2);
            Accounts.Add(acc3);
            foreach (var item in Accounts)
            {
                Console.WriteLine($"ID : {item.id} , username : {item.usernameP}  password : {item.passwordP}");

            }


        }
    }
}
