using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.StockManagement
{
    public class PriceCheck:IPriceCheck
    {
        public bool Price(Dictionary<string,int> price,ref int money,string productName)
        {
            if (!price.ContainsKey(productName))
            {
                Console.WriteLine("Item is not in the vending machine");
                return false;
                
            }
            else if (money >= price[productName])
            {
                money = money - price[productName];
            }

            else
            {
                Console.WriteLine("You entered the less amount than original");
                return false;
            }
            return true;
        }
    }
}
