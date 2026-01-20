using System;
using System.Collections;
public class Loops
{
    public static bool Check(int n)
    {
       
        int count = 0;
        for(int i=1;i<=n;i++)
        {
            if(n%i==0)
            {
                count++;
            }
        }
        if(count==2)
        {
            return true;
        }
        return false;
        
            
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Loops Assignment");

        string? userinput;
        Console.WriteLine("Enter Number of terms");
        userinput = Console.ReadLine();
        if (!int.TryParse(userinput, out int num))
        {
            Console.WriteLine("Enter valid input");
        }
        //prime numbers
        for (int i=2;i<=num;i++)
        { 
          if(Check(i))
            {
                Console.WriteLine(i+ " ");
            }
        }

        //guesing game
        Console.WriteLine("Welcome to the guess Game");
        Random random = new Random();
        int targetNumber = random.Next(1, 11);

        int n=-1;
        while(n!=targetNumber)
        {
            Console.WriteLine("Guess The Number");
            userinput = Console.ReadLine();
            if (!int.TryParse(userinput, out  n))
            {
                Console.WriteLine("Enter valid input");
            }
        }


        //for each to iterate collections

        List<int> ll = new List<int>();
        ArrayList arr = new ArrayList();
        arr.Add(100);
        arr.Add("Ashish");
        arr.Add("Aman");

        Console.WriteLine("Members inside the ArrayList");
        foreach(var i in arr)
        {
            Console.Write(i + " ");
        }

        ll.Add(1);
        ll.Add(2);
        ll.Add(3);
        ll.Add(4);
        ll.Add(5);
        ll.Add(6);
        ll.Add(7);
        ll.Add(8);

        Console.WriteLine("\nList of numbers :");
        foreach(int i in ll)
        {
            Console.Write(i + " ");
        }

    }
}
