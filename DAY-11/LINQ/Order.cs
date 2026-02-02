using System;
using System.Collections.Generic;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class OrderItem
{
    public string ProductName { get; set; }
    public double Price { get; set; }
}
namespace LINQ
{
    public class Order
    {

        public int OrderID { get; set; }
        public string CustomerName { get; set; } 

        public List<OrderItem> OrderItems=new List<OrderItem>();

        public static List<Order> GetData()
        {
            return new List<Order>
                {
                  new Order
                  {
                        OrderID=1001,
                        CustomerName="Aman",
                        OrderItems =
                      {
                          new OrderItem {ProductName="Keyboard",Price=2500},
                          new OrderItem {ProductName="mouse",Price=500},

                      }
                  },
                    new Order
                  {
                        OrderID=1002,
                        CustomerName="Amit",
                        OrderItems =
                      {
                          new OrderItem {ProductName="mousepad",Price=200},
                          new OrderItem {ProductName="pen",Price=10},

                      }
                  },
                      new Order
                  {
                        OrderID=1003,
                        CustomerName="aniket",
                        OrderItems =
                      {
                          new OrderItem {ProductName="laptop",Price=50000},
                          new OrderItem {ProductName="Pendrive",Price=530},
                      }
                  },
                         new Order
                  {
                        OrderID=1004,
                        CustomerName="mohit",
                        OrderItems =
                      {
                          new OrderItem {ProductName="Watch",Price=5000},
                          new OrderItem {ProductName="belt",Price=300},
                      }
                  }
                }; 
        }
    }
}
