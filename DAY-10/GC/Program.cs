using System;

public class A
{ 
    public A()
    {
        Console.WriteLine("Constructor is called...");
    }
    ~A() //finalizer
    {
        Console.WriteLine("this is finalizer");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        for(int i=0;i<100;i++)
        {
           A obj= new A();
        }
        Console.WriteLine("Force GC");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        //GC.Collect();

    }
}