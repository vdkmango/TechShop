using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techshop.Enums;


namespace Techshop.Models
{
    internal class Speaker : Accessory
    {
        public Speaker()
        {
            Console.WriteLine("Speaker was created");
        }

        public Speaker(string Name, Brand Brand, decimal Price, Color Color, uint Quantity, string Size, bool IsWireless)
            : base(Name, Brand, Price, Color, Quantity, Size, IsWireless)
        {
            _name = Name;
            _brand = Brand;
            _price = Price;
            _color = Color;
            _quantity = Quantity;
            _size = Size;
            _isWireless = IsWireless;
            Console.WriteLine("Speaker was created");
        }
    }
}
