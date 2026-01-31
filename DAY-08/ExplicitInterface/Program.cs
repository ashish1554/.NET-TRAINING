using System;

interface ILogging
{
    void Common();
   
}


interface IAuditing
{
    void Common();
    
}

class A:ILogging,IAuditing
{
    void IAuditing.Common()
    {
        Console.WriteLine("Method for IAuditing");
    }
    void ILogging.Common()
    {
        Console.WriteLine("Method for Iloggin");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Call using interfaces as reference");
        IAuditing i1= new A();
        i1.Common();

        ILogging i2 = new A();
        i2.Common();
        Console.WriteLine("----------------------------------------------------");

        Console.WriteLine("Using explicit conversion we can also call method");
        A obj = new A();
        ((IAuditing)obj).Common();
        ((ILogging)obj).Common();

        //This is not valid  
        //A obj2 = new A();
        //obj2.Common();

    }
}