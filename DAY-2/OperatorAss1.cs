using System;
public class Class1
{
  static void Main() {
	Console.WriteLine("Welcome to  Operator Assignment");
	Console.WriteLine("Enter first number:");
	int a = int.Parse(Console.ReadLine());
	Console.WriteLine("Enter second number:");
	int b = int.Parse(Console.ReadLine());
	Console.WriteLine("Enter Operator to use +,-,/,*,%");
	string op = Console.ReadLine();
	int result = a;

	switch (op)
	{
		case "+":
			{
				result += b;
				break;
			}
		case "-":
			{
				result -= b;
				break;
			}
		case "*":
			{
				result *= b;
				break;
			}
		case "/":
			{
				if (b == 0)
				{
					Console.WriteLine("Cannot divide by 0");
				}
				else
				{
					result /= b;
				}
				break;
			}
		case "%":
			{
				if (b == 0)
				{
					Console.WriteLine("Cannot divide by 0");
				}
				else
				{
					result %= b;
				}
				break;
			}

		default:
			Console.WriteLine("ENter valid operator");
			break;
			Console.WriteLine("The result is: " + result);
	}

}

}
