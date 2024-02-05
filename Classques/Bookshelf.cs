using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classques
{
    internal class Bookshelf:FurnitureItem
    {
        public int Shelves { get; set; }

        // Constructor to initialize properties for Bookshelf
        public Bookshelf(string name, double price, string material, int shelves)
            : base(name, price, material)
        {
            Shelves = shelves;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call the base class method

            // Display additional information specific to Bookshelf
            Console.WriteLine($"Number of Shelves: {Shelves}");
        }
    }
}
