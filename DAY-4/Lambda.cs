
using System;
using System.Collections.Generic;
public class Lambda
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8,16,298,282,122,34 };

        //Even Numbers 
        var ans = arr.Where(x => x % 2 == 0);
        Console.Write("Even Numbers are : ");
        foreach(var x in ans)
        {
            Console.Write(x + " " );
        }

        //Maximum finding
        int max = arr[0];
         Array.ForEach(arr,x => {
             if (x > max) max = x;
        });
          Console.WriteLine("\nMaximum Value is : "+max);

        //sorting the collection

        List<int> ll = new List<int> { 3, 4, 65, 1, 2, 4, 8 };
        ll.Sort((a, b) => a.CompareTo(b));
        
        foreach(var item in ll)
            {
                Console.Write(item + " ");
            }


    }

}
