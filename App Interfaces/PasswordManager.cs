using System;

namespace AppInterfaces
{
    class PasswordManager : IDisplayable, IResetable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
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
    }
}