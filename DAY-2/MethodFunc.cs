using System;

public class Class1
{
    //Arithmetic Methods
	public static void Add(double a,double b)
	{
		Console.WriteLine("Addition is {0}",a+b);
	}
    public static void Sub(double a, double b)
    {
        Console.WriteLine("Substraction is {0}", a - b);
    }
    public static void Mul(double a, double b)
    {
        Console.WriteLine("Multiplication is {0}", a * b);
    }
     
    //Methods Using Out Paramters

    public static void Interest(double p,double r,double n,out double si,out double ci)
    {
        si = (p * r * n) / 100;
        ci = p * Math.Pow((1 + r), n) - p;

    }

    //Methods Using Optional Paramters

    public static void Display(string name,string message="hii")
    {
        Console.WriteLine(message+ " "+name);
    }

    public static double InputCheck(string message)
    {
        double value;
        Console.WriteLine(message);
        while(!double.TryParse(Console.ReadLine(),out value))
        {
            Console.WriteLine("invalid input enter again");
        }
        return value;
    }


    static void Main()
    {
        double si, ci;
        Console.WriteLine("Method and Function Assignment");

        double a, b;
         a = InputCheck("Enter Number 1");
         b = InputCheck("Enter Number 2");



        Add(a, b);
        Sub(a, b);
        Mul(a, b);

        double p,r,n;
        p = InputCheck("Enter Principal Amount");
        r = InputCheck("Enter Rateof Interest");
        n = InputCheck("Enter TimeDuration");



        Interest(p, r, n, out si, out ci);
        Console.WriteLine("Simple Interest is {0}", si);
        Console.WriteLine("Compound Interest is {0}", ci);


        Display("Ashish");
        Dislay("Ashish","Hello")


    }


}
