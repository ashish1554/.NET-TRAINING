using System;
using System.ComponentModel;

public class DisposeEx:IDisposable
{
    private StreamWriter write;
    public DisposeEx()
    {
         write = new StreamWriter("Ex.txt",true);
        write.WriteLine("Content is added  At :" + DateTime.Now);

    }
    public void Dispose()
    {
        Console.WriteLine("Proof that Dispose method is called via using block");
        write.Dispose();
    }
}
public class Ex
{
    public static void Main(string[] args)
    {

        //this is the normal way in which we explicitly call the dispose or close method
        //StreamWriter write = new StreamWriter("Ex.txt", true);
        //write.WriteLine("Content Added to ex file");
        //write.Close(); pr write.Dispose();


        //this is method that make use of using block in which dispose method is called autmotatically
        //here we create object of StreamWriter that internally convrted into try finally block and in finally blcok it automatically calls the dispose method 
        //using (StreamWriter write=new StreamWriter("Ex.txt",true))
        //{
        //    write.WriteLine("Content is added through using block At :"+DateTime.Now);
        //    //here we dont include close or dispose method using block automatically calls dispose method for us
        //}


        //in this approach we created our own class to explore how dispose is call in our own class  through using block
        Console.WriteLine("Main method start...");
        using (DisposeEx d = new DisposeEx())
        {
            Console.WriteLine("Calling dispose method...");
        }
        Console.WriteLine("Main ends");

    }
}