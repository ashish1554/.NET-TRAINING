using System;

public delegate void Calculator(double a, double b);
public class DelegateEx
{
	public static void Add(double a,double b)
	{
		Console.WriteLine("Sum is : " + (a+b));
	}
    public static void Sub(double a, double b)
    {
        Console.WriteLine("Subtraction is : " + (a - b));
    }
    public static void Mul(double a, double b)
    {
        Console.WriteLine("Multiplication is : " + (a * b));
    }
    public static void Div(double a, double b)
    {
        if (b == 0) Console.WriteLine("Can not divide by zero");
        else Console.WriteLine("Division is : " + (a / b));
     
    }

    public static void Main(string[] args)
	{
        Console.WriteLine("I created calculator delegate");

        string? userinput;

        Console.WriteLine("Enter number 1 : ");
        userinput = Console.ReadLine();
    if (!double.TryParse(userinput, out double num1))
    {
        Console.WriteLine(" Invalid input");
        return;
    }

        Console.WriteLine("Enter number 2 : ");
        userinput = Console.ReadLine();
    if (!double.TryParse(userinput, out double num2))
    {
        Console.WriteLine("Invalid input");
        return;
    }

    Calculator CalDel = Add;
        CalDel += Sub;
        CalDel += Mul;
        CalDel += Div;
        CalDel(num1, num2);

    }
}
