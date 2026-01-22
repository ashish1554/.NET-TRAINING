using System;
using System.Linq;


public static class ExtensionExample
{
	public static string ConverttoUpper(this string s)
	{
		string append = "How Are You?";
		return s.ToUpper() + " " + append;
	}
	public static string ConvertFirstLetterUpperCase(this string s)
	{
		string str = "";
		s.ToLower().Split(' ').ToList().ForEach(x =>
		{
			str +=char.ToUpper(x[0])+x.Substring(1)+" ";
		});
			return str;
	}
}
public class ExtensionMethod
{
	public static void Main(string[] args)
	{
		 string name = "ashish pateliya";

		Console.WriteLine("First Method is for converting uppercase and append some string");
		string ans=name.ConverttoUpper();
		Console.WriteLine(ans);

		Console.WriteLine("Second Method is for converting the first letter capital ");
        string ans2 = name.ConvertFirstLetterUpperCase();
        Console.WriteLine(ans2);


    }
}
