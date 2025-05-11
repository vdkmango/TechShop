using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techshop.Enums;

namespace Techshop.Models
{
    abstract class Device : Product, IDiscountable, IComparable<Device>
    {
        protected uint _ram;

        public uint RAM
        {
            get => _ram;
            set => _ram = value;
        }
        public Device()
        {
            Console.WriteLine("Device was created");
        }
        public Device(string Name, Brand Brand, decimal Price, uint RAM, uint Quantity, string Size)
            : base(Name, Brand, Price, Quantity, Size)
        {
            _name = Name;
            _brand = Brand;
            _price = Price;
            _quantity = Quantity;
            _size = Size;
            _ram = RAM;
            Console.WriteLine("Device was created");
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Brand: {Brand}, " +
                $"Price: {Price}, RAM: {RAM} Amount: {Quantity}.");
        }

        abstract public void Sale();

        public int CompareTo(Device? other)
        {
            if (RAM < other.RAM) return -1;
            else if (RAM > other.RAM) return 1;
            else return 0;
        }

        public virtual void Sale(decimal percentage)
        {
            Price -= Price *= percentage;
        }
    }

}
