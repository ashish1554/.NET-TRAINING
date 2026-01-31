using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.StockManagement
{
    public interface IPriceCheck
    {
        bool Price(Dictionary<string, int> price, ref int money, string productName);
    }
}
