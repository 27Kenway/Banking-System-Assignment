using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandobject.Model
{
    internal static class Product
    {
        public static int Id { get; set; }
        public static string? Name { get; set; }

        public static void GetProductDetail()
        {
            Console.WriteLine($"{Id}\t{Name}");
        }
    }

}
