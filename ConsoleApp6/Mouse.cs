using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techshop
{
    internal class Mouse : Accessory
    {
        public Mouse()
        {
            Console.WriteLine("Smartphone was created");
        }

        public Mouse(string Name, Brand Brand, decimal Price, Color Color, uint Quantity, string Size, bool IsWireless)
            : base(Name, Brand, Price, Color, Quantity, Size, IsWireless)
        {
            _name = Name;
            _brand = Brand;
            _price = Price;
            _color = Color;
            _quantity = Quantity;
            _size = Size;
            _isWireless = IsWireless;
            Console.WriteLine("Mouse was created");
        }
    }
}
