using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace Ex
{
    public class EmailIsNotValidException : Exception
    {
        public EmailIsNotValidException(string message) : base(message) { }
    }
    
   

    public class UserProfileEx
    {

        public string username;
        private string email;
        private string password;
        private string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

        public void Display()
        {
            Console.WriteLine("your name is : " + username);
            Console.WriteLine("your email is : " + email);
            Console.WriteLine("your pass is : " + password);

        }
        public string Email
        {

            get { return email; }
            private set
            {
                if (!Regex.IsMatch(value, pattern)) throw new EmailIsNotValidException("Email is not valid");
                else email = value;
            }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public UserProfileEx(string username, string email, string password)
        {
            this.username = username;
            Email = email;
            Password = password;

        }


    }
    public class Program
    {

        public static void Main(string[] args)
        {
         
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine() ?? "abc@123gmail.com";
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine() ?? "abc@123";
            Console.WriteLine("Enter Your Name : ");
            string name = Console.ReadLine() ?? "adam";

            try
            {
                UserProfileEx Obj = new UserProfileEx(name, email, password);
                Obj.Display();
            }
            catch (EmailIsNotValidException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    //What breaks if everything is public
    //if everything is public then email anyone can add any value like obj.email=123 is allowes means no validataion is allowed
    //it invalids the bypass logics 
    //it allows obj.email="djkhfjkhd" or anything
}