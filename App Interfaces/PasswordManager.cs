using System;

namespace AppInterfaces
{
    class PasswordManager : IDisplayable, IResetable
    {
        public string password = "";
        private string Password
        { 
            get { return password; } 
            set
            {
                if (password.Length >= 8)
                {
                    password = value;
                }
                else
                {
                    password = "InvalidPassword";
                }
            }
        }

        public bool Hidden
        { get; private set; }

        public char HeaderSymbol
        { get; set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            char HeaderSymbol = '-';
            string Header = new string(HeaderSymbol, 10);
            Console.WriteLine(Header);
            Console.WriteLine("Password: ");
            if (!Hidden)
            {
                Console.WriteLine(Password);
            }
            else if (Hidden)
            {
                string hiddenPassword = new String('*', Password.Length);
                Console.WriteLine(hiddenPassword);
            }
        }

        public void Reset()
        {
            Password = "";
            Hidden = false;
        }

        public bool ChangePassword(string currentPassword, string newPassword)
        {
            if (currentPassword == Password)
            {
                Password = newPassword;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}