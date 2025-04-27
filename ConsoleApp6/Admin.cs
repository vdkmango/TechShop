using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Admin : LoginInformation
    {
        public Admin() { }

        public Admin(string Username, string Password, string Email, string Address, int ZipCode)
            : base(Username, Password, Email, Address, ZipCode)
        {
            _username = Username;
            _password = Password;
            _email = Email;
            _address = Address;
            Console.WriteLine("Succesfully logged in");
        }

        
    }
}
