using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classques
{
    internal class Bike
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }


        public void AcceptBikeDetails()
        {
            Console.WriteLine("Accepting Bike Details");
            Console.Write("Enter Bike Model: ");
            Model = Console.ReadLine();

            Console.Write("Enter Bike Year: ");
            int.TryParse(Console.ReadLine(), out int year);
            Year = year;

            Console.Write("Enter Bike Price: ");
            double.TryParse(Console.ReadLine(), out double price);
            Price = price;
        }


        public void DisplayBikeDetails()
        {
            Console.WriteLine("Displaying Bike Details");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Price: ${Price}");
        }
    }
}
