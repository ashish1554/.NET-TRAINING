using System;
using VendingMachine.Bill;
using VendingMachine.Payment;
using VendingMachine.ProductManagement;
using VendingMachine.Serices;
using VendingMachine.Status;
using VendingMachine.StockManagement;

public class Ex
{
    public static void Main(string[] args)
    {
        
         IPayment paymode = new Upi();
        //IPayment paymode = new Coin();
        //IPayment paymode = new CreditCard();

        IBill bill = new WpBill();
        //IBill bill = new Email();
        //IBill bill = new Sms();


        IStockCheck stockCheck = new StockCheck();
        IPriceCheck priceCheck = new PriceCheck();
        Data dic = new Data();

        int x;
        do
        {
            dic.ItemList();
            Console.WriteLine("Enter product name : ");
            string productName = Console.ReadLine().ToLower();
            Console.WriteLine("Enter amount : ");
            int money = int.Parse(Console.ReadLine());

            ProductService order = new ProductService(paymode, priceCheck, stockCheck, bill, dic);
            order.PlaceOrder(productName, ref money);

            Console.WriteLine("Enter 1 to continue");
            x=int.Parse(Console.ReadLine());
        } while (x==1);
    }
}