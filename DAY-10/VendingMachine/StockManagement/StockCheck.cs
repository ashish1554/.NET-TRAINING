using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.StockManagement
{
    public class StockCheck:IStockCheck
    {
        public bool Stock(Dictionary<string, int> stock, string productName)
        {
            if (stock[productName] <= 0) 
            {
                Console.WriteLine("Out of stock");
                return false;
            }
            if(stock.ContainsKey(productName.ToLower()) )
            {
                stock[productName]--;
            }
            return true;
            
        }
        
    }
}
