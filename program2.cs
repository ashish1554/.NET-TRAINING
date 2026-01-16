using System;

class Program2
{
   
    static void ValueType(int a, int[] brr, ref int[] crr, ref int c)
    {
        a = 10;
        c = 500;
        brr[0] = 6; brr[1] = 7; brr[2] = 8;
        crr = new int[] { 6, 7, 8 };
    }
    static void Main()
    {
        int a = 5, b = 20;
        int[] arr = { 1, 2, 3, 4, 5 };
        int[] drr = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Variable before calling{a} [{string.Join(", ", arr)}]");
        ValueType(a, arr, ref drr, ref b);
        Console.WriteLine($"Variable after calling{a} [{string.Join(", ", arr)}]");
        Console.WriteLine($"Variable after calling{a} [{string.Join(", ", drr)}] ");
        Console.WriteLine($"value of b is after calling {b}");
    }
}