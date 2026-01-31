using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Payment
{
    internal class Coin:IPayment
    {
        public void Pay(ref int money)
        {
            Console.WriteLine("Payment is done using coin");
        }
    }
}
