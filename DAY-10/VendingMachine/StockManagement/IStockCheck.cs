using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.StockManagement
{
    public interface IStockCheck
    {
        bool Stock(Dictionary<string, int> stock, string productName);
    }
}
