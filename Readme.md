# Ask user to input ProductNam and Product Price
# Calculate the total product value with GST
# GST can be 18% of product Price
# if the total value is exceeding 70000 then give a discount of 1000
# to the console print message :"your Ordered product is :: Your Bill is::{}"

Ans 
            Console.WriteLine("Enter your Productname::");
            string pdtName = Console.ReadLine();
            Console.WriteLine("Enter your productPrise");
            double pdtPrise = double.Parse(Console.ReadLine());
            double totalPrise = pdtPrise + pdtPrise * 0.18;
            if (totalPrise > 70000)
            {
                totalPrise = totalPrise - 1000;
                Console.WriteLine($"your Ordered product is ::{pdtPrise} Your Bill is::{totalPrise}");
            }
            else
            {
                Console.WriteLine($"your Ordered product is ::{pdtPrise} Your Bill is::{totalPrise}");
            }


#  Illustrate the difference between anonymous type and dynamic type with an example
Ans  
--Anonymous types 
Its allow you to create objects without having to explicitly define their types ahead of time, 
while maintaining static type checking. You can use the var keyword to declare a local variable that holds an anonymous type, 
and the compiler will infer the type based on the properties you assign to the object. 
Anonymous types are useful when you need to work with data that is only relevant within a limited scope, 
For example:
var person = new { Name = "Alice", Age = 25 };

Console.WriteLine($"Hello, {person.Name}. You are {person.Age} years old.");
---Dynamice Types
Dynamic types allow you to work with objects whose type is not known at compile time, but is determined at runtime. 
You can use the dynamic keyword to declare a variable that can hold any type of object, 
and the compiler will defer the type checking and method resolution until the code is executed. 
Dynamic types are useful when you need to interact with objects that are dynamic by nature, such as COM objects, JSON data, or reflection. 
For example:
dynamic person = new Object();
person.Name = "Bob";
person.Age = 30;
Console.WriteLine($"Hello, {person.Name}. You are {person.Age} years old.");

# Daniel is working for a telecommunication company , he would like to collect the feed back from his customers on the 
# quality of their companies' service, he has not decided the parameters that contribute to the feedback 
# Which type of variable should he create. Illustrate with an example.

 Ans 
 If Daniel wants to collect feedback from his customers on the quality of their company’s service, he should create a dynamic type variable. 
 A dynamic type variable can hold any type of object, and its type is determined at runtime. 
 This means that Daniel can add or remove properties to the variable as he decides the parameters that contribute to the feedback.
 For Example:
dynamic feedback = new Object();


feedback.CustomerName = "John";
feedback.ServiceRating = 4;
feedback.Comments = "Good service, but slow response time.";

Console.WriteLine($"Customer name: {feedback.CustomerName}");
Console.WriteLine($"Service rating: {feedback.ServiceRating}");
Console.WriteLine($"Comments: {feedback.Comments}");

#As a member of a team that is developing toys for JoyToys, Inc., 
you have been assigned the task of creating a bike module that accepts and displays bike details. 
Declare the Bike class and its member functions. The member function that accepts bike details should display
the message “Accepting Bike Details”. Similarly, the member function to display bike details on the screen 
should display the message “Displaying Bike Details”

