using System;

public class EnumStruct
{
	//Enum for OrderStatus
	public enum OrderStatus
	{ 
		pending,
        delivered,
		shipping,
		canceled=404,
		delayed
    }

	//Struct
	public struct Coordinate
	{
		public int x, y;
		public Coordinate(int x,int y)
		{
			this.x = x;
			this.y = y;
		}
		public void Method()
		{
			Console.WriteLine($"Coordinate : { x} , {y}");
		}
	}
	public static void Main()
	{
		Console.WriteLine("All Order Stauts Are");
		OrderStatus s = OrderStatus.shipping;
        Console.WriteLine(s);
		Console.WriteLine(OrderStatus.pending);
        Console.WriteLine(OrderStatus.delayed);
        Console.WriteLine(OrderStatus.delivered);
        Console.WriteLine(OrderStatus.canceled);

		//by default if we dont assign any integer values to our enum structure then it starts with 0
		Console.WriteLine("OrderStatus For pending is(default) : " + (int)OrderStatus.pending);

		//we can explicitly also give value to our enum named constant
		Console.WriteLine("OrderStatus For canceled is : " + (int)OrderStatus.canceled);
		Console.WriteLine("OrderStatus with code 404 is : " + (OrderStatus)404);

		Coordinate obj= new Coordinate(4,5);
		obj.Method();

    }
}
