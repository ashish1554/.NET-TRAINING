using System;
interface IUser
{
    void PrintName(string name);
    void PrintAge(int age);
    void Login();
    void Logout();
}
interface IAdminUser : IUser
{
    void PrintRole(string role);
    void PrintSalary(double salary);
}
class B : IUser
{
    public void PrintName(string name)
    {
        Console.WriteLine("I am UserInterface method for printing name : " + name);
    }
    public void PrintAge(int age)
    {
        Console.WriteLine("I am UserInterface method for printing age : " + age);
    }
    public void Login()
    {
        Console.WriteLine("User using login method");
    }
    public void Logout()
    {
        Console.WriteLine("User is logout");
    }
}

class A : IAdminUser
{
   public void PrintName(string name)
    {
        Console.WriteLine("I am UserInterface method for printing name : "+name);
    }
    public void PrintAge(int age)
    {
        Console.WriteLine("I am UserInterface method for printing age : "+age);
    }
    public void PrintRole(string role)
    {
        Console.WriteLine("I am AdminInterface method for printing role : "+role);
    }
    public void PrintSalary(double salary)
    {
        Console.WriteLine("I am AdminInterface method for printing salary : " + salary);
    }
    public void Login()
    {
        Console.WriteLine("Admin using login method");
    }
    public void Logout()
    {
        Console.WriteLine("Admin is logout");
    }
}



class Program
{
    public static void Main()
    {
        //A a = new A();
        //a.PrintName("Ashish");
        //a.PrintAge(21);
        //a.PrintSalary(120000);
        //a.PrintRole("HOE");
        IUser user = new B();
        user.Login();
        user.PrintAge(22);
        user.PrintName("Ashish");
        user.Logout();

        Console.WriteLine("-----------------------------");
        IAdminUser admin = new A();
        admin.Login();
        admin.PrintAge(40);
        admin.PrintName("Aman");
        admin.PrintRole("Team Lead");
        admin.PrintSalary(100000);
        admin.Logout();
        
    }
}
