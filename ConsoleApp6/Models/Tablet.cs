using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Techshop.Enums;


namespace Techshop.Models
{
    abstract class Tablet : Device
    {
        public Tablet()
        {
            Console.WriteLine("Tablet was created");
        }

        public Tablet(string Name, Brand Brand, decimal Price, uint RAM, uint Quantity, string Size)
            : base(Name, Brand, Price, RAM, Quantity, Size)
        {
            _name = Name;
            _brand = Brand;
            _price = Price;
            _ram = RAM;
            _quantity = Quantity;
            _size = Size;
            Console.WriteLine("Tablet was created");
        }

        public override void Sale()
        {
            _price *= 0.8m;
        }
    }
}
