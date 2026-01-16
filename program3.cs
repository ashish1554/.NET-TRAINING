using System;

class Program3
{
    static void Main()
    {

        int? age = null;
        //int? age = 32; // if we want to give value to age
        Console.WriteLine(age);

        if (age.HasValue)
        {
            Console.WriteLine("Age has value");
            Console.WriteLine(age.Value);
        }
        else
        {
            Console.WriteLine("Age is null");
        }

        int finalAge = age ?? 13;
        Console.WriteLine(age.HasValue);
        Console.WriteLine(finalAge);


        String? phoneNUmber = null;
        String finalPhone = phoneNUmber ?? "8758852343";
        Console.WriteLine(finalPhone);
    }
}