using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.ProductManagement
{
    public class Data
    {
        public Dictionary<string, int> price = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            {"Chocalate",50 },
            {"Icecream",100 },
            {"Candy",45 },
            {"Bananachips",80 },
            {"Potatochips",60 },
            {"Thumsup",30 },
            {"Sprite",40 },
            {"Maaza",50 }
        };


        public Dictionary<string, int> stock = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            {"Chocalate",5 },
            {"Icecream",10 },
            {"Candy",4 },
            {"Bananachips",8 },
            {"Potatochips",6 },
            {"Thumsup",3 },
            {"Sprite",4 },
            {"Maaza",5 }
        };

        public void ItemList()
        {
            Console.WriteLine("Availabale Items in the Vending Machine");
            foreach(var item in stock)
            {
                string productName = item.Key;
                int qnty = item.Value;

                int productPrice = price[productName];

                Console.WriteLine($"Product : {productName} | Price:{productPrice} | Stock : {qnty}");
            }
           
        }
    }
}
