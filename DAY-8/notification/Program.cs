using System;
namespace DAY8.notification
{
interface INotification
{
    void Notification();
}

public class EmailNotification : INotification
{
    public void Notification()
    {
        Console.WriteLine("Email notification is running");
    }
}

public class SMSNotification : INotification
{
    public void Notification()
    {
        Console.WriteLine("Sms notification is running");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        INotification Obj = new SMSNotification();
        INotification Obj2 = new EmailNotification();
        Obj.Notification();
        Obj2.Notification();

    }
}
}