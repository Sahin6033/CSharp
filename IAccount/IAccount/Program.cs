using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace IAccount
{
    interface IAccount
    {

        bool PasswordChecker();
        void ShowInfo();
    }

    class User : IAccount
    {
        private string Fullname;
        private string Email;
        private string Password;
        public User(string fn, string email, string ps)
        {
            this.Fullname = fn;
            this.Email = email;
            this.Password = ps;
            if (PasswordChecker())
            {
                this.Password = ps;
            }
            else
            {
                this.Password = "";
                Console.WriteLine("Incorrent type password !!!");
            }

        }
      

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname : {Fullname} Password : {Password}");
        }

        public bool PasswordChecker( )
        {
            string ps = this.Password;
            bool valid = false;
            bool big = false;
            bool small = false;
            bool digit = false;
            if (ps.Length >= 8)
            {
                foreach (char c in ps)
                {
                    if (65 <= c && c <= 90)
                    {
                        big = true;
                    }
                    if (97 <= c && c <= 122)
                    {
                        small = true;
                    }
                    if (48 <= c && c <= 57)
                    {
                        digit = true;
                    }
                }
            }
            valid = big && small && digit;

            return valid;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Shahin Muradli", "sahin007.sm@gmail.com", "qwSS11udhqwd");
            user.ShowInfo();
        }
    }
}
