using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Publication
    {
        public string Name { get; set; }
        public int pageCount { get; set; }
        public decimal Price { get; set; }

        public Publication(string name, int pagecount, decimal price) 
            {
            Name = name;
            pageCount = pagecount;
            Price = price;
            }
        public virtual void GetDetail()
        {
            Console.WriteLine($"Name::{Name}\t PageCount::{pageCount}\t Price::{Price}\t");
        }
       
    }
}
