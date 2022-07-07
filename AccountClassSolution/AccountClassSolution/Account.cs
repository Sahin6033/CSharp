using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClassSolution
{
    internal class Account
    {
        private static int counter = 1;
        public  int id;
        public string usernameP;
        public string passwordP;

       
        public Account(string username, string password )
        {
            if (IsUserNameValid(username))
            {
                this.usernameP = username;
            }
            else
            {
                Console.WriteLine("This username you entered does not meet the requirements ");
            }

            if (IsPasswordValid(password))
            {
                this.passwordP = password;
            }
            else
            {
                Console.WriteLine("This password you entered does not meet the requirements ");
            }


            id = counter++;
        }

        private bool IsUserNameValid(string username)
        {
            bool valid = true;
            for (int i = 0; i < username.Length; i++)
            {
                if (!((username[i] >=48 && username[i] <=57)||(username[i] >= 65 && username[i] <= 90) || (username[i] >= 97 && username[i] <= 122)))
                {
                    valid = false;  
                }
               
            }
            return valid;
           
        }

        private bool IsPasswordValid(string password)
        {
            bool valid = true;
            byte small = 0;
            byte big = 0;
            byte digit = 0;
            if (password.Length >= 8 && password.Length <= 25)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] >= 48 && password[i] <= 57)
                    {
                        digit++;
                    }
                    else if(password[i] >= 65 && password[i] <= 90)
                    {
                        big++;
                    }
                    else if (password[i] >= 97 && password[i] <= 122)
                    {
                        small++;
                    }
                }
            }
            else
            {
                valid = false;
            }
            return valid && small != 0 && big != 0 && digit != 0;
        }


    }
}
