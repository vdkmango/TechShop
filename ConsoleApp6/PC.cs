using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techshop
{
    internal class PC : Device
    {
        public PC()
        {
            Console.WriteLine("PC was created");
        }

        public PC(string Name, Brand Brand, decimal Price, uint RAM, uint Quantity, string Size)
            :base (Name, Brand, Price, RAM, Quantity, Size)
        {
            _name = Name;
            _brand = Brand; 
            _price = Price;
            _ram = RAM;
            _size = Size;
            _quantity = Quantity;
            Console.WriteLine("PC was created");
        }

        public override void Sale()
        {
            _price *= 0.8m;
        }
    }
}
