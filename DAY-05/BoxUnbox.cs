using System;

public class BoxUnbox
{
	public static void Main(string[] args)
	{
		int value = 5;

		Console.WriteLine("Initial value is : "+value);
		//boxing:boxing is like implicit conversion 
		object obj = value;
        Console.WriteLine("After Boxing");
        Console.WriteLine(obj);

		//unboxing:unboxing is explicit conversion means we need to explicitly define in which type we need to convert and it much match the type in which object is converted

		int a = (int)obj;
        Console.WriteLine("After unboxing");
        Console.WriteLine(a);
	}
}
