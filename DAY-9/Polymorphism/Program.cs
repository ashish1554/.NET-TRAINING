using System;
using System.Threading.Channels;

public class PaymentProcessor
{
   
    //methods to be overriden into creditcard and upi 
   public virtual void ProcessPayment(string name,double upiId)
    {
        Console.WriteLine("Payment using Upi");
    }
    public virtual void ProcessPayment(double from,double to,string sender,string receiver)
    {
        Console.WriteLine("Payment using credit card");
    }


    //Extra overloaded method for showing demo how overloading works
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"You processing payment using amount only.. amount is :{amount}");
    }
    public void ProcessPayment(double amount,double payid)
    {
        Console.WriteLine($"You processing payment using amount and payid.. amount is :{amount} payid is : {payid}");
    }
    public void ProcessPayment(double amount,double payid,DateTime timeAndDate)
    {
        Console.WriteLine($"You processing payment using amount,payid and Current date and time.. amount is :{amount} payid is : {payid} current date and time is : {timeAndDate} ");
    }
    public void ProcessPayment(double amount, double payid, DateTime timeAndDate,string name)
    {
        Console.WriteLine($"You processing payment using amount,payid,current date and time and name.. amount is :{amount} payid is : {payid} current date and time is : {timeAndDate} name:{name} ");
    }
    
}

public class CreditCard:PaymentProcessor
{
    public override void ProcessPayment(double from, double to, string sender, string receiver)
    {
        Console.WriteLine("Payment using credit card");
        Console.WriteLine($"From Ac: {from}");
        Console.WriteLine($"To Ac: {to}");
        Console.WriteLine($"Sender name: {from}");
        Console.WriteLine($"Reciever name: {receiver}");

    }
}
public class Upi : PaymentProcessor
{
    public override void ProcessPayment(string name,double upiId)
    {
        Console.WriteLine("Your mode of payment is Upi");
        Console.WriteLine($"your upiId is : {upiId}");
        Console.WriteLine($"your name is : {name}");

    }
}
public class Program
{
    public static void Main(string[] args)
    {
        PaymentProcessor processor = new PaymentProcessor();
        Console.WriteLine("Demo for overloaded methods");
        Console.WriteLine("--------------------------------------------------------------------------");

        processor.ProcessPayment(5000);
        processor.ProcessPayment(5000,220280107109);
        processor.ProcessPayment(5000,220280107154,DateTime.Now);
        processor.ProcessPayment(5000, 220280107154, DateTime.Now,"Ashish");

        Console.WriteLine("--------------------------------------------------------------------------");

        PaymentProcessor creditCard = new CreditCard();
        creditCard.ProcessPayment(220280107159, 220280107454, "Ashish", "Aman");
        Console.WriteLine("--------------------------------------------------------------------------");

        PaymentProcessor upi = new Upi();
        upi.ProcessPayment("Ashish",2202878978787787878);




    }
}