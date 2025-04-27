using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
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
        }

        public Brand Brand
        {
            get => _brand;
        }

        public decimal Price
        {
            get => _price;
            set => _price = value;
        }

        public string Size
        {
            get => _size;
        }
        public Product()
        { }
        protected Product(string Name, Brand Brand, decimal Price, uint Quantity, string Size)
        {
            this._name = Name;
            this._brand = Brand;
            this._price = Price;
            this._quantity = Quantity;
            this._size = Size;  
        }
    }
}
