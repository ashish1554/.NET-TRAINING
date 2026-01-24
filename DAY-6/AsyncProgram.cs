using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
public class AsyncEx
{
    public static string SyncMethod()
    {
        Console.WriteLine("sync method start");
        Thread.Sleep(4000);
        return "after waiting 4 sec sync data returned";
    }
  

    public static async Task ApiExCall()
    {
        Console.WriteLine("Star Fetching Api Data");
        await Task.Delay(4000);
        Console.WriteLine("Data is fetched from api");
    }

    public static async Task Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        Console.WriteLine("Async call start");
        Task apiResponse = ApiExCall();

        for(int i=0;i<=9;i++)
        {
            Console.WriteLine("doing backgroud work");
            await Task.Delay(1000);
        }
        await apiResponse; //this is for if after completing the looop even though we dont get data then wait untill we got the data

        sw.Stop();
        Console.WriteLine("Time for async execution is : "+sw.ElapsedMilliseconds + "ms");
        sw.Restart();
        
        Console.WriteLine("sync excecution");

        sw.Start();
        string syncResult = SyncMethod();
        Console.WriteLine(syncResult);
         
        for(int i=0;i<=9;i++)
        {
        Console.WriteLine("BackGround Process start after waiting");
        await Task.Delay(1000);
        }
    sw.Stop();
    Console.WriteLine("Time for sync execution is : " + sw.ElapsedMilliseconds + "ms");

    }
}