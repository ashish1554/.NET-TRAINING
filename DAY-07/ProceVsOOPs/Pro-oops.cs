using System;
using System.Xml.Linq;

using Ex;

class UsingOops
{
    private double balance; //only modified objects can changes this by creating object
    public string name;
    public double AccNo;
    public string Acctype = "Saving";

    public UsingOops(double balance, string name, double AccNo)
    {
        this.balance = balance;
        this.name = name;
        this.AccNo = AccNo;
    }

    public void DepositOops(double amount)
    {
        balance += amount;

    }

    public void WithDrawOops(double amount)
    {
        if (amount < balance) balance -= amount;
        else
        {
            Console.WriteLine("Not have suffiecint balance");
            return;
        }

    }
    public void Display()
    {
        Console.WriteLine($"Name:{name}");
        Console.WriteLine($"AccNo : {AccNo}");
        Console.WriteLine($"Balance : {balance}");
        Console.WriteLine($"Accounttype : {Acctype}");

    }
}
class Program
{
    static void Deposit(string name, double AccNo, ref double balance, double amount)
    {
        balance += amount;

    }
    static void Withdraw(string name, double AccNo, ref double balance, double amount)
    {
        balance -= amount;
    }
    static void Display(string name, double AccNo, double balance)
    {
        Console.WriteLine($"Name:{name}");
        Console.WriteLine($"AccNo : {AccNo}");
        Console.WriteLine($"Balance : {balance}");
    }
    public static void Main(string[] args)
    {
        //User:1
        double AccNo1;
        string name1;
        double balance1;

        AccNo1 = 220280107109;
        name1 = "Ashish";
        balance1 = 10000;

        Deposit(name1, AccNo1, ref balance1, 500);
        Withdraw(name1, AccNo1, ref balance1, 1500);
        Display(name1, AccNo1, balance1);

        //User:2
        double AccNo2;
        string name2;
        double balance2;

        AccNo2 = 220280107189;
        name2 = "Kartik";
        balance2 = 15000;

        Deposit(name2, AccNo2, ref balance2, 500);
        Withdraw(name2, AccNo2, ref balance2, 1500);
        Display(name2, AccNo2, balance2);


        double AccNo3;
        string name3;
        double balance3;

        AccNo3 = 220280107179;
        name3 = "Raj";
        balance3 = 15700;

        Deposit(name3, AccNo3, ref balance3, 500);
        Withdraw(name3, AccNo3, ref balance3, 1500);
        Display(name3, AccNo3, balance3);


        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Using Oops : ");
        //User:1
        UsingOops Obj = new UsingOops(10000, "Amit", 220280107111);
        Obj.DepositOops(500);
        Obj.WithDrawOops(540);
        Obj.Display();

        //User:2

        UsingOops Obj2 = new UsingOops(15000, "Ajay", 220280107511);
        Obj2.DepositOops(1500);
        //Obj2.WithDrawOops(45540); this will invalid
        Obj2.WithDrawOops(4540);
        Obj2.Display();

        UsingOops Obj3 = new UsingOops(10000, "Mahi", 220280107181);
        Obj3.DepositOops(5500);
        Obj3.WithDrawOops(8540);
        Obj3.Acctype = "Current"; //if we want to change from default we can change it
        Obj3.Display();


        //Summary
        //As using oops concept we set balance as private field so it is not global means no one can change it with wrong balance only specified object instance that hase access to it can change
        //Imorove code reusibility as we create a classs UsingOops and declare all the variables like name,accno,balance we dont require to create new variables for each user every time that we create in normal approch
        //if we want to add new extra field ex.Accounttype than if we using oops than we add directly inside the class string Accounttype but if we use procedural language then we need to create new variable for each user
        //this increase the code redability 




    }
}
