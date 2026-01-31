using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Payment
{
    public  interface IPayment
    {
        void Pay(ref int money);
    }
}
