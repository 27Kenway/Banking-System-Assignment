//ShortCut Key
//cw+tab----- Console.writeline
//ctrl+kw ----- commening multi lines at a time
//ctrl+KD----Alignemnt
using Microsoft.VisualBasic;
using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp1
{
    //SOLID-Design principles
    internal class Program
    {
        //write the above function using tuple
        static (int, int) Func3(int num1, int num2) {
            return (num1,num2);
        }
        
        #region Method
        //public static float ConvertMileToKM(float miles)
        //{
        //    float result = miles * 1.5f;
        //    return result;
        //}
        //static void AddPrefix(string str, string prefix)
        //{
        //    Console.WriteLine($"{str} {prefix}");
        //}
        //static void Func1(ref int num1)
        //{
        //    num1 += 100;
        //    Console.WriteLine($"{num1}");
        //}
        //static void Funt2(int num1,int num2, out int sum, out int product)
        //{
        //    sum = num1 + num2;
        //    product = num1 + num2;
        //}
        #endregion
        enum Categories
        {
            Eectronics = 1,
            Fashion,
            household
        }
        static void Main(string[] args)
        {
            #region variable and Datatypes
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("C# Training Day1");

            //int userId; //declare a variable

            ////Explicit type declaration
            //userId = 200;
            //int UserId = 100;
            //string userName = "Bharat";
            //float userExpenditure = 10000.243f;
            //double userSalary = 50000.1800;
            //decimal userCredit = 500.190m;

            ////Implicit Type decalaration
            //var productId = 500;
            //var ProductName = "prodcut1";
            //var productPrice = 4000;
            //Console.WriteLine(productId);
            //Console.WriteLine($"UserID is :{UserId}\t UserName is :{userName}");
            //Console.WriteLine(userId);
            #endregion
            #region Taking User Input
            //Console.WriteLine("Enter userID::");
            //int userID = int.Parse(Console.ReadLine());
            //int userEnteredId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your name :");
            //string userName = Console.ReadLine();
            //Console.WriteLine($"UserID::{userID}\n userName::{userName}");
            #endregion
            #region Anonymous types
            //int a = default;

            //bool b = default;
            //string c = default;
            //int? f = null;
            //string name = null;
            //bool? check = null;
            //int? d = null;
            //int j = d ?? 0;

            //Console.WriteLine($"Default value are ::{a},{b},{c},{f},{name},{check}");
            //var user = new { Id = 1, Name = "Bharat" };
            //Console.WriteLine($"UserId::{user.Id}\n name::{user.Name}");
            #endregion
            #region Boxing
            //Boxing and unboxing
            //boxing --value type to object type
            //unboxing-- object type to value
            //int i = 450;
            //boxing
            //object o = i;
            //unboxing
            //i = (int)o;
            //int i==450;
            /*stack     heap
             * i=450     object --address--object value */
            #endregion
            #region Operators
            //Ask user to input his name and password
            //if the input value are matching the predefined values then print some meaning full

            //string userNameInfo = "Bharat";
            //string pwdInfo = "Bharat@123";
            //Console.WriteLine("Enter your name::");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Enter your password");
            //string pwd = Console.ReadLine();
            //if(userName==userNameInfo && pwd == pwdInfo)
            //{
            //    Console.WriteLine("Login Successfull");

            //}
            //else
            //{
            //    Console.WriteLine("Login fails");
            //}
            #endregion

            //---------------------------CLASS QUESTION----------------------
            //Ask user to input ProductNam and Product Price
            //Calculate the total product value with GST
            //GST can be 18% of product Price
            //if the total value is exceeding 70000 then give a discount of 1000
            //to the console print message :"your Ordered product is :: Your Bill is::{}"
            
            
            //Console.WriteLine("Enter your Productname::");
            //string pdtName = Console.ReadLine();
            //Console.WriteLine("Enter your productPrise");
            //double pdtPrise = double.Parse(Console.ReadLine());
            //double totalPrise = pdtPrise + pdtPrise * 0.18;
            //if (totalPrise > 70000)
            //{
            //    totalPrise = totalPrise - 1000;
            //    Console.WriteLine($"your Ordered product is ::{pdtPrise} Your Bill is::{totalPrise}");
            //}
            //else {
            //    Console.WriteLine($"your Ordered product is ::{pdtPrise} Your Bill is::{totalPrise}");
            //}

            #region Dynamic Datatype

            //var userSalary = 20000;
            //dynamic salary = 20000;
            ////userSalary = "ave"; //not allowed with var
            //salary = "def"; //allowed with dynamic datatype
            //dynamic mark;
            //mark = 100;
            //Console.WriteLine(userSalary);
            //Console.WriteLine(salary);
            //Console.WriteLine(salary.GetType());
            #endregion
            #region enum use
            Categories categories = Categories.Eectronics;
            Console.WriteLine(categories);
            #endregion
            #region stringAndStringBuilder
            //string msg = "sringsConcept";
            //string msg1 = "String are immutable";
            //string msg3 = msg1 + " " + msg;//
            //Console.WriteLine(msg3);//
            //stringBuilder
            //declare a stringBuilder

            //StringBuilder sb = new StringBuilder();
            //sb.Append(msg); //stringConcept
            //sb.Append('\t');//gives tab space
            //sb.Append(msg1);//string concept string are immutable
            //Console.WriteLine(sb);
            #endregion
            #region String and StrinBuilder
            //Difference with String and StringBuilder

            //DateTime startDate;
            //DateTime endDate;
            //TimeSpan totalTime;
            //string sampleString = "";
            //startDate = DateTime.Now;
            //for (int i = 0; i < 10000; i++)
            //{
            //    sampleString += i; 
            //}
            //endDate = DateTime.Now;
            //totalTime = endDate - startDate;
            //Console.WriteLine($"Total Time taken is::{totalTime.TotalSeconds}");//0.155454

            //StringBuilder with long runningloop
            //StringBuilder sb2 = new StringBuilder();
            //startDate = DateTime.Now;
            //for (int i = 0; i < 10000; i++)
            //{
            //    sb.Append(i);
            //}
            //endDate = DateTime.Now;
            //totalTime = endDate - startDate;
            //Console.WriteLine($"Total Time taken is::{totalTime.TotalSeconds}"); //0.0032911
            #endregion

            //DateTime dt = DateTime.Now;//gets current date and time
            //Console.WriteLine(dt);
            //DateTime date = DateTime.Today;//current date
            //Console.WriteLine(date);

            #region Switch
            //Ques Design an application to provid user with choices fro login, Rigester and logout functionality
            //Depending on user input print the respective message on to console
            //string userName = "Bharat";
            //String menu = @"Press1:: Register 
            //                Press2:: Login 
            //                Press3:: LogOut";
            //Console.WriteLine("Welcome to our Website \n Choose from the Below option to Continue ");
            //Console.WriteLine(menu);
            //Console.WriteLine("Enter Your choice");
            //int choice = int.Parse(Console.ReadLine());
            //Console.Clear();
            //switch (choice)
            //{
            //    case 1: Console.WriteLine("Enter your name: ");
            //        String registerUserName = Console.ReadLine();
            //        Console.WriteLine($"Hi, {registerUserName} registration Success");
            //        break;
            //    case 2: Console.WriteLine("Enter your name");
            //        String userEnteredName = Console.ReadLine();
            //        if(userName != userEnteredName)
            //        {
            //            Console.WriteLine("Register First");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Welcome {userEnteredName} Continue enjoying services");

            //        }
            //        break;
            //    case 3: Console.WriteLine("you have Successfull logged out");
            //        break;
            //    default: Console.WriteLine("Enter valid option");
            //        break;
            //}
            #endregion

            #region Demo loop
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"The value of i is {i}");
            //}
            ////while loop
            //int j =0;
            //while (j < 10)
            //{
            //    Console.WriteLine($"The value of j is ::{j}");
            //    j++;
            //}
            ////do while loop
            //int c = 0;
            //do
            //{
            //    Console.WriteLine($"The value of c is ::{c}");
            //    c++;
            //}
            //while (c < 10);
            #endregion
            #region Break Statement
            //for(int i =0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;

            //    }
            //    Console.WriteLine($"The value of i is ::{i}");
            //}
            #endregion
            #region jump statements
            //int counter  = 0;
            //login:
            //Console.WriteLine("Enter your password");
            //string password = Console.ReadLine();
            //if (password != "password")
            //{
            //    counter++;
            //    if (counter < 3)
            //    {
            //        Console.WriteLine("Wrong credentials, try again");
            //        goto login;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your account is blocked, try after 24 hrs");
            //    }
            //}
            //else 
            //{
            //    Console.WriteLine("logged in successful");
            //}
            #endregion
            #region string Functions
            //string userFirstName = "Bharat";
            //string userLastName = "Kumar";
            //Console.WriteLine(userFirstName.Clone());
            //compareing values
            //Console.WriteLine(userFirstName.CompareTo(userLastName));
            //whether string contain somevalue
            //Console.WriteLine(userFirstName.Contains("rat"));

            //Console.WriteLine(userLastName.IndexOf('m'));
            //Console.WriteLine(userLastName.Length);
            //Console.WriteLine(userLastName.StartsWith("K"));
            #endregion
            #region Math funtions
            //double number = -20.5;
            //double absNumber = Math.Abs(number);
            //Console.WriteLine(absNumber);//20.5
            //double value = 20.56;
            //double roundValue = Math.Round(value);
            //Console.WriteLine(roundValue);
            //decimal number1 = 20.56434M;
            //decimal roundNum1 = Math.Round(number1,2);
            //Console.WriteLine(roundNum1);
            //Console.WriteLine(Math.Pow(2,3));
            #endregion

            #region Declare Array
            //string[] customers;
            //string[] customersNames = new string[] { "Bharat", "Isha","Abhi" };
            //string[] customersPwd = { "123@", "456@" };

            //Individual vlaues
            //Console.WriteLine(customersNames[0]);//Bharat
            //Access all the elements of array and print ti console window
            //for loop
            //for(int i = 0; i < customersNames.Length; i++)
            //{
            //    Console.WriteLine(customersNames[i]);
            //}
            //for each loop
            //foreach (string name in customersNames)
            //{
            //    Console.WriteLine(name);
            //}
            //Inbuilt function of array
            //Array.Sort(customersNames);
            //foreach(var Name in customersNames)
            //    Console.WriteLine(Name);

            //Find an Element in Array
            //Console.WriteLine("-----Finding Element----");
            //string elementtobeSearched = "Isha";
            //string resultToBeSearched = Array.Find(customersNames, name => name == elementtobeSearched);
            //if(resultToBeSearched != null)
            //{
            //    Console.WriteLine(resultToBeSearched);
            //}
            //else
            //{
            //    Console.WriteLine("Element not found");
            //}
            #endregion
            //Two Dimensional Array
            //string[,] companies =
            //{
            //    {"Hexaware","TamilNadu" },
            //    {"HCL","Kar" }
            //};
            //Jagged Array
            //Array of array
            //int[][] jaggedArray = new int[2][];
            //jaggedArray[0] =  new int[2] {1, 2 };
            //jaggedArray[1] = new int[3] { 10, 11, 12 };

            //string[][] usersCities = new string[][]
            //{
            //    new string[] {"Bharat","Delhi"},
            //    new string[] {"Isha", "Haryana"}
            //};
            //foreach (string[] name in usersCities)
            //{
            //    foreach (string user in name)
            //    {
            //        Console.WriteLine(user);
            //    }

            //}

            //Method Declaration
            //<accessSpecifier><ReturnType> FunctionName(args){
            //}

            //Console.WriteLine(ConvertMileToKM(6.0f));
            //AddPrefix("c#Traning", "%");
            //AddPrefix(prefix: "%", str: "C#training");

            //int num1 = 10;
            //int num2 = 10;
            //Func1( ref num1);//110
            //Console.WriteLine($"{num1}");//10
            //int a, b;
            //Funt2(num1, num2, out a, out b);
            //Console.WriteLine($"{a},{b}");
            //(int a, int b) tup1 = (5, 10);
            //Console.WriteLine($"{tup1.a}\t {tup1.b}");
            //var tup2 = ("hello", 123);
            //Console.WriteLine($"{tup2.Item1}\t{tup2.Item2}");
            //Console.WriteLine(Func3(6, 10));
            (int, int) result = Func3(6, 10);
            Console.WriteLine($"sum::{result.Item1}\t product::{result.Item2}");


        }
    }
}