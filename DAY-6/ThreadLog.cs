using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.Collections.Concurrent;
public class ThreadLog
{
    static List<int> ll = new List<int>();
    static ConcurrentBag<int> ll2 = new ConcurrentBag<int>();

    public static void Method()
    {

        for(int i=0;i<10000;i++)
        {
            ll.Add(i);
        }
             

    }
    public static void Method2()
    {
        for (int i = 0; i < 10000; i++)
        {
            if (ll.Count > 0)
            {
                ll.RemoveAt(0);
            }
        }
    }
     public static void Method3()
    {
        for (int i = 0; i < 10000; i++)
        {
            
                ll2.Add(i);
          
        }
    }

    public static void Method4()
    {
        for (int i = 0; i < 10000; i++)
        {
            ll2.TryTake(out _);

        }
    }


public static void Main(string[] args)
{

    Thread th1 = new Thread(Method);
    Thread th2 = new Thread(Method2);
        
    Thread th3 = new Thread(Method3);
    Thread th4 = new Thread(Method4);

        th1.Start();
        th2.Start();
        th3.Start();
        th4.Start();

        th1.Join();
        th2.Join();
        th3.Join();
        th4.Join();

        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Program that demonstrack the behaviour of how 10000 elements are added and removed using 2 thread ");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Expected output : 0 because as we use one thread for adding item and one thread for removing item but in case of List<> we got unexpected behaviour and in Concurrent Collection it ensure one thread access at one time");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("First count is for Generic Collection List<>: " + ll.Count);
        Console.WriteLine("Secound count is for Concurrent Collection ConcurrentBag<>: " + ll2.Count);
}
}
