# SOLID PRINCIPLE


## S – Single Responsibility Principle (SRP)

### One class = one responsibility

Here how my code achive this

productdata => ProductData

pricevalidation =>PriceCheck

Stock update=>StockCheck

Payment=>Upi, Coin, CreditCard

Bill notification=>Email, Sms, WpBill

ProcessFlow=>ProductService

here i make sure one class is used for one single logic 

## O – Open / Closed Principle (OCP)

### Open for extension but closed for modification

if my requirement changes later i want pushBill than i can create pushBill.cs:IBill if i want to add new payment mode gpay.cs then i can easily add this without modify the my productService

without OCP i need to manually check for payment like 

```
if (paymentType == "UPI") { ... }
else if (paymentType == "CARD") { ... }
else if (paymentType == "COIN") { ... }
```




## L – Liskov Substitution Principle (LSP)

### Child class must replace parent safely

At anypoint if i want payment i can simply use Ipayment paymentmode;

i can easily pass my all my payment behaviour correctly like new Upi(),new Coin(),new CreditCard() 





---

## I – Interface Segregation Principle (ISP)

i make separate interfaces for seprate task so no class force to implement usused methods

### Ex.
IPayment=>for payment

IBill=>For bill 

IPriceCheck=>for price logic

IStockChange=>for stock logic



## D– Dependency Inversion Principle (DIP)

### High-level modules should not depend on low-level modules.Both should depend on abstractions (interfaces).

In my project in productService i use

```
private IPayment payment;
private IBill bill;
private IPriceCheck priceCheck;
private IStockCheck stockCheck;

```
 lets simply takes the example of the IPayment

 if i use private  Upi payment = new Upi(); inside ProductService than myProductService lock with Upi mode only so in future if i want to switch to coin() then i need to update my ProductService code also means it is tightly coupled 

 if i use only IPayment than productService dont know  about Upi,Coin,Card it only knows to do payment no matter how .
