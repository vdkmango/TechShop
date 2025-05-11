using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techshop.Models
{
    internal class LoginInformation
    {
        protected string _username;
        protected string _password;
        protected string _email;
        protected string _address;
        protected int _zipcode;
        public string Username
        {
            get => _username;
        }
        public string Password
        {
            get => _password;
            set => _password = value;
        }
        public string Email
        {
            get => _email;
        }
        public string Address
        {
            get => _address;
        }
        public int ZipCode
        {
            get => _zipcode;
        }

        public LoginInformation() { }

        public LoginInformation(string Username, string Password, string Email, string Address, int ZipCode)
        {
            _username = Username;
            _password = Password;
            _email = Email;
            _address = Address;
            _zipcode = ZipCode;
            Console.WriteLine("User Created");
        }
    }
}
