using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Techshop.Enums;


namespace Techshop.Models
{
    internal class Toaster : Product
    {
        public Toaster()
        {

        }
        public Toaster(string Name, Brand Brand, decimal Price, uint Quantity, string Size)
            : base(Name, Brand, Price, Quantity, Size)
        {
            _name = Name;
            _brand = Brand;
            _price = Price;
            _quantity = Quantity;
            _size = Size;
            Console.WriteLine("Toaster created.");
        }
    }
}
