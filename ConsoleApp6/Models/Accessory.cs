using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techshop.Enums;

namespace Techshop.Models
{
    enum Color { Red, Green, Blue, Yellow, Orange }
    internal class Accessory : Product
    {
        protected Color _color;
        protected bool _isWireless;

        public Color Color
        {
            get => _color;
        }

        public bool IsWireless
        {
            get => _isWireless;
        }

        public Accessory()
        {

        }

        public Accessory(string Name, Brand Brand, decimal Price, Color Color, uint Quantity, string Size, bool IsWireless)
        {
            _name = Name;
            _brand = Brand;
            _price = Price;
            _color = Color;
            _quantity = Quantity;
            _size = Size;
            _isWireless = IsWireless;
            Console.WriteLine("Accessory was created");
        }
    }
}
