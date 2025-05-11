using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techshop.Enums;

namespace Techshop.Models
{
    internal class Product
    {
        protected string _name;
        protected Brand _brand;
        protected decimal _price;
        protected uint _quantity;
        protected string _size;

        public uint Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        public string Name
        {
            get => _name;
            init => _name = value;
        }

        public Brand Brand
        {
            get => _brand;
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (_price < 0)
                {
                    Console.WriteLine("Invalid Input!");
                }
                _price = value;
            }
        }

        public string Size
        {
            get => _size;
        }
        public Product()
        { }
        protected Product(string Name, Brand Brand, decimal Price, uint Quantity, string Size)
        {
            _name = Name;
            _brand = Brand;
            _price = Price;
            _quantity = Quantity;
            _size = Size;
        }
    }
}
