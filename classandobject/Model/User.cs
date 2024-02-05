

namespace classandobject.Model
{
    internal class User
    {
        //int userId = 100;
        //string userName;
        //string city;

        //Fields with public access modifier
        //public int userId;
        //public string userName;
        //public string city;

        #region Getter and Setter
        //Trasitional Getter and Setter Methods

        //public int GetId() 
        //{ 
        //    return userId; 
        //}
        //public void SetId(int id)
        //{ 
        //    userId = id; 
        //}
        #endregion
        #region Properties
        //public int UserId 
        //{
        //    get { return userId; }
        //    set { userId = value; }
        //}

        #endregion
        #region Auto Implemented Properties
        //prop+tab key
        public int UserId { get; set; }//Readonly Property
        public string UserName { get; set; }
        public string City { get; set; }
        #endregion
        //public DateTime CreatedAt { get; set; } = DateTime.Now;

        //Construtor
        //ctor+tabkey
        //public User()
        //{
            
        //}

        public User(int id,string name,string city) 
        {
            UserId = id;
            UserName = name;
            City = city;
        }


        public void GetUserDetail()
        {
            Console.WriteLine($"UserId::{UserId}\t UserName::{UserName}\t City::{City}");
        }
    }
}
