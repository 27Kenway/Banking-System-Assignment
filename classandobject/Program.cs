using classandobject.Model;

namespace classandobject
{

    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1,"bharat","Delhi");
            //user.userId = 100;
            //user.userName = "Bharat";
            //user.city = "Delhi";
            //Console.WriteLine($"Id::{user.UserId}\t Name::{user.UserName}\t City::{User.city}");
            //user.SetId(200);
            //Console.WriteLine($"User id ::{user.GetId()}");
            //user.UserId = 200;
            //Console.WriteLine($"Id::{user.UserId}");
            //user.UserId = 100;
            //user.UserName = "Bharat";
            //user.City = "Delhi";
            user.GetUserDetail();
            Product.GetProductDetail();


        }
    }
}
