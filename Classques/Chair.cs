using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classques
{
    internal class Chair:FurnitureItem
    {
        public bool HasArmrest { get; set; }

        // Constructor to initialize properties for Chair
        public Chair(string name, double price, string material, bool hasArmrest)
            : base(name, price, material)
        {
            HasArmrest = hasArmrest;
        }

        // Override method to display information about the chair
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call the base class method

            // Display additional information specific to Chair
            Console.WriteLine($"Has Armrest: {HasArmrest}");
        }

    }
}
