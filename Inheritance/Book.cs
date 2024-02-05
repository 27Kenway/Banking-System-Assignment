using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Book:Publication
    {
        //public int BookName { get; set; }
        public string AuthorName { get; set; }
        // public int PageCount { get; set; }
        //public decimal Price { get; set; }

        //create book constructor

        public Book(string name, int pagecount, decimal price, string authoreName) : base(name,pagecount,price) 
        {
            authoreName = AuthorName;
        }
        public void ViewBookDetails(string name,int pageCount)
        {
            Console.WriteLine($"Name::{Name}\t pagecount::{pageCount}");
        }
        public void ViewBookDetails(string name, int pageCount,string author)
        {
            Console.WriteLine($"Name::{Name}\t pagecount::{pageCount}\t Author::{AuthorName}");
        }
        public override void GetDetail() 
        {
            Console.WriteLine($"Name::{Name}\t PageCount::{pageCount}\t Price::{Price}\t AuthorName::{AuthorName}");
        }

    }
}
