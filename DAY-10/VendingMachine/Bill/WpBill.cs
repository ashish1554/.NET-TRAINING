using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Bill;

namespace VendingMachine.Status
{
    public class WpBill:IBill
    {
        public void Message()
        {
            Console.WriteLine("Bill is send to your wp...");
        }
    }
}
