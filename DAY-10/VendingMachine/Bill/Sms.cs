using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Bill
{
    public class Sms:IBill
    {
        public void Message()
        {
            Console.WriteLine("Bill is send to your sms");
        }
    }
}
