using System;

public abstract class Employee
{
    public float baseSalary;
    public float allowance;
    public float pf;
    public float tax;
    public int workHour;
    public float amountPerHour;
    public abstract void SalaryCalculation();

}

public class FullTimeEmployee : Employee
{

    float finalSalary;
    public override void SalaryCalculation()
    {
        finalSalary=(baseSalary+allowance)-(pf+tax);
        Console.WriteLine("Your base salary is : "+baseSalary);
        Console.WriteLine("Your Allowance is : " + allowance);
        Console.WriteLine("Your pf is : " + pf);
        Console.WriteLine("Your tax is : " + tax);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"You are full time employee and your salary is : {finalSalary}");
    }
  
}

public class ContractEmployee:Employee
{
    float finalSalary;
    public override void SalaryCalculation()
    {
        finalSalary = workHour * amountPerHour;
        Console.WriteLine("Your contract for working hour is : "+workHour);
        Console.WriteLine("Your  amount per hour is  : "+amountPerHour);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Your total salary at the end of contract is {finalSalary}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Details for full time employees:");
        Console.WriteLine("Give basesalary you want to give employee per month");
        float baseSalary = float.Parse(Console.ReadLine());
        Console.WriteLine("Give allowance you want to give employee per month");
        float allowance = float.Parse(Console.ReadLine());
        Console.WriteLine("Give pf you want to deduct  per month");
        float pf = float.Parse(Console.ReadLine());
        Console.WriteLine("Give tax you want to deduct  per month");
        float tax = float.Parse(Console.ReadLine());

        Employee fullTime =  new FullTimeEmployee();

        fullTime.baseSalary = baseSalary;
        fullTime.allowance = allowance;
        fullTime.pf = pf;
        fullTime.tax = tax;

        fullTime.SalaryCalculation();

        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Details for Contractbased time employees:");
        Console.WriteLine("Give the contract of total hours ex.140hr 150hr");
        int workHour = int.Parse(Console.ReadLine());
        Console.WriteLine("Give the amount that you want to give employee per hour ex.2000 ,3000 in inr");
        float amountPerHour = float.Parse(Console.ReadLine());

        Employee contractBase = new ContractEmployee();
        contractBase.workHour = workHour;
        contractBase.amountPerHour = amountPerHour;
        contractBase.SalaryCalculation();


    }
}