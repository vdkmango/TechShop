using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Techshop.Enums;


namespace Techshop.Models
{
    internal class SmartPhone : Device
    {
        public SmartPhone()
        {
            Console.WriteLine("Smartphone was created");
        }

        public SmartPhone(string Name, Brand Brand, decimal Price, uint RAM, uint Quantity, string Size)
            : base(Name, Brand, Price, RAM, Quantity, Size)
        {
            _name = Name;
            _brand = Brand;
            _price = Price;
            _ram = RAM;
            _quantity = Quantity;
            _size = Size;
            Console.WriteLine("Smartphone was created");
        }

        public override void Sale()
        {
            _price *= 0.8m;
        }
    }
}
