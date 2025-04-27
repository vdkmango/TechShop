using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Techshop
{
    internal class Keyboard : Accessory
    {
        public Keyboard()
        {
            Console.WriteLine("Keyboard was created");
        }

        public Keyboard(string Name, Brand Brand, decimal Price, Color Color, uint Quantity, string Size, bool IsWireless)
            : base(Name, Brand, Price, Color, Quantity, Size, IsWireless)
        {
            _name = Name;
            _brand = Brand;
            _price = Price;
            _color = Color;
            _quantity = Quantity;
            _size = Size;
            _isWireless = IsWireless;
            Console.WriteLine("Keyboard was created");
        }
    }
}
