using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Payment
{
    internal class CreditCard:IPayment
    {
        public void Pay(ref int money)
        {
            Console.WriteLine("Payment is done using credit card");
        }
    }
}
