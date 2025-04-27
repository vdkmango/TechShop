using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techshop
{
    internal class Laptop : Device
    {
        public Laptop()
        {
            Console.WriteLine("Laptop was created");
        }

        public Laptop(string Name, Brand Brand, decimal Price, uint RAM, uint Quantity, string Size)
            : base(Name, Brand, Price, RAM, Quantity, Size)
        {
            _name = Name;
            _brand = Brand;
            _price = Price;
            _ram = RAM;
            _size = Size;
            _quantity = Quantity;
            Console.WriteLine("Laptop was created");
        }

        public override void Sale()
        {
            _price *= 0.8m;
        }
    }
}
