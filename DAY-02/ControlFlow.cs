using System;

public class Class1
{
	static void IfElse(int marks)
	{
        Console.WriteLine("Using if else statement");
        if (marks >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade B");
        }
        else if (marks >= 40)
        {
            Console.WriteLine("Grade C");
        }
        else
        {
            Console.WriteLine("Grade F");
        }
    }
    static void SwitchCase(int marks)
    {
        Console.WriteLine("Using SwitchCase Statement");

        switch (marks)
        {
            case int m when  m >= 90:
                {
                    Console.WriteLine("Grade A");
                }
                break;
            case int m when m >= 60:
                {
                    Console.WriteLine("Grade B");
                }
                break;
            case int m when m >= 40:
                {
                    Console.WriteLine("Grade C");
                }
                break;
            default:
                {
                    Console.WriteLine("Grade F");
                }
                break;
        
        }
    }

    static void Main()
	{
        int marks;
		Console.WriteLine("Welcome to Control Flow Assignment");
        Console.WriteLine("Enter Your Marks:");
        if(!int.TryParse(Console.ReadLine(),out marks))
        {
            Console.WriteLine("Invalid Input");
        }
        IfElse(marks);
        SwitchCase(marks);

    }
}
