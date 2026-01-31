using System;
using System.Collections.Generic;

public class GenericRepo<Gen>
{
	List<Gen> ll = new List<Gen>();
	public void Insert(Gen value)
	{
		ll.Add(value);
	}
	public void RemoveItem(Gen value)
	{
		ll.Remove(value);
	}

	public void Display()
	{
		foreach (var item in ll)
		{
			Console.Write(item + " ");
		}
	}
}
public class Generic
{

	public static void Swap<Gen>(ref Gen val1, ref Gen val2)
	{
		Gen temp;
		temp = val1;
		val1 = val2;
		val2 = temp;
	}
	public static void Main(string[] args)
	{
		int a = 12, b = 100;
		Console.WriteLine("1.Integer swap using Swap<Gen> method");
		Console.WriteLine($"Value Before Call : {a} , {b}");
		Swap(ref a, ref b);
		Console.WriteLine($"Value After Call : {a} , {b}");


		string name1 = "Ashish",name2="Amit";
		Console.WriteLine("2.String swap using same Swap<Gen> method");
		Console.WriteLine($"Value Before Call : {name1} , {name2}");
		Swap(ref name1, ref name2);
		Console.WriteLine($"Value After Call : {name1} , {name2}");

		GenericRepo<int> obj1 = new GenericRepo<int>();
		obj1.Insert(1);
		obj1.Insert(2);
		obj1.Insert(3);
		obj1.Insert(4);
		obj1.Insert(5);

		obj1.RemoveItem(4);
		obj1.RemoveItem(1);

		GenericRepo<string> obj2 = new GenericRepo<string>();
		obj2.Insert("Ashish");
		obj2.Insert("Amit");
		obj2.Insert("Ajay");
		obj2.Insert("Anita");
		obj2.Insert("Rakesh");

		obj2.RemoveItem("Amit");
		obj2.RemoveItem("Rakesh");

		Console.WriteLine("\nContent of the list for integer are : ");
		obj1.Display();
		Console.WriteLine("\nContent of the list for string are : ");
		obj2.Display();

	}
}