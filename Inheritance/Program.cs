namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Drived class object or child class object
            Book book = new Book("C#", 100, 200.59m, "Anders Hejlsberg");
            Console.WriteLine($"{book.Name}\t{book.Price}\t{book.AuthorName}\t{book.pageCount}");
            book.GetDetail();

            //Base classobject
            Publication publication = new Publication("C#", 100, 200.59m);
            publication.GetHashCode();

        }
    }
}
