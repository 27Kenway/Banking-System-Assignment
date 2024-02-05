using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classques
{
    internal class FurnitureItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Material { get; set; }

        // Constructor to initialize common properties
        public FurnitureItem(string name, double price, string material)
        {
            Name = name;
            Price = price;
            Material = material;
        }

        // Method to display information about the furniture item
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Furniture Item: {Name}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Material: {Material}");
        }
    }
}
