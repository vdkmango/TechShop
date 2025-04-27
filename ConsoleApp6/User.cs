using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class User : LoginInformation
    {

        public User()
        {

        }
        public User(string Username, string Password, string Email, string Address, int ZipCode)
            :base(Username, Password, Email, Address, ZipCode)
        {
            _username = Username;
            _password = Password;
            _email = Email;
            _address = Address;
            _zipcode = ZipCode;
            Console.WriteLine("Succesfully logged in");
        }

        public void GetUserInfo()
        {
            Console.WriteLine($"User: {_username}, Password: {_password}, Email: {_email}, Adress: {_address}, ZipCode: {_zipcode}");
        }
    }
}
