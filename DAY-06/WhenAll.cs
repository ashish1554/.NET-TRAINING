using System;
using System;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

public class WhenAllEx
{
     public static async Task AsyncDemo()
{
    await Task.Delay(2000);
}
public static async Task Main(string[] args)
{
    Stopwatch sw = new Stopwatch();
    sw.Start();

    //in this Task.WhenAll i explore that when i use .WhenALl() method then all async method start at the same time but if i dont use .WhenAll() then one by one async methods are executes means it looks like sync behaviour 
    Task t1 = AsyncDemo();
    Task t2 = AsyncDemo();
    Task t3 = AsyncDemo();
    await Task.WhenAll(t1, t2, t3);
    sw.Stop();
    Console.WriteLine("Time for asyn execution is : " + sw.ElapsedMilliseconds + "ms");

}

       

}
