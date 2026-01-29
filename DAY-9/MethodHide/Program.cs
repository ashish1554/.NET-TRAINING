using System;

public class Base
{
    public virtual void Method()
    {
        Console.WriteLine("Thid is base class method");
    }
    public  void Method2()
    {
        Console.WriteLine("This is base class method2");
    }
}

public class Derived : Base
{
    public override void Method()
    {
        Console.WriteLine("This is the method using override");
    }
    public new void Method2()
    {
        Console.WriteLine("This is the method2 using override");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Base b = new Base();
        b.Method();
        b.Method2();
        Console.WriteLine("------------------------------------------------");


        Base b1 = new Derived();
        b1.Method();
        b1.Method2();
        Console.WriteLine("------------------------------------------------");

        Derived d1 = new Derived();
        d1.Method();
        d1.Method2();

    }
}