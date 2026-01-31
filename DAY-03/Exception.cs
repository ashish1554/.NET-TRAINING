using System;

public class InsuffieientBalanceException : Exception
{
    public InsuffieientBalanceException(string message) : base(message) { }
}
public class Exc
{

	public static void CheckBalance(ref int withdraw,ref int balance)
	{
		
            if (withdraw > balance)
            {
				throw new InsuffieientBalanceException("Insufficient Balance");
            }
			else
			{
			balance = balance - withdraw;
			}	
        
	}
	public static void Main(string[] args)
	{
		int balance = 2000;
		string? userinput;
		Console.WriteLine("Balance in your Account is : " + balance);
		
		try
		{
			Console.WriteLine("Enter amount to withdraw");
            userinput = Console.ReadLine();
            if (!int.TryParse(userinput,out int withdraw))
			{
			Console.WriteLine("Enter valid number");
			}
            CheckBalance(ref withdraw,ref balance);
		}
		catch(InsuffieientBalanceException Ex)
		{
			Console.WriteLine("Exception : " +  Ex.Message);
		}
		finally
		{
			Console.WriteLine("Remaining Amount is : " + balance);
		}
	}
}
