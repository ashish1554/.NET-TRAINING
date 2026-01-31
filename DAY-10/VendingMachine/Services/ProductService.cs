using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Payment;
using VendingMachine.StockManagement;
using VendingMachine.Status;
using VendingMachine.Bill;
using VendingMachine.ProductManagement;

namespace VendingMachine.Serices
{
     public class ProductService
    {
        private IPayment payment;
        private IStockCheck stockCheck;
        private IPriceCheck priceCheck;
        private IBill bill;
        private Data dic;
       
      
        public ProductService(IPayment payment,IPriceCheck priceCheck,IStockCheck stockCheck, IBill bill,Data dic)
        {
            this.payment = payment;
            this.priceCheck = priceCheck;
            this.stockCheck = stockCheck;
            this.bill= bill;
            this.dic= dic;
        }

 
        public void PlaceOrder(string productName,ref int  money)
        {
             if(!priceCheck.Price(dic.price,ref money,productName)) return;
             if(!stockCheck.Stock(dic.stock, productName)) return;
               
             payment.Pay(ref money);
             bill.Message();
                
            
        }

    }
}
