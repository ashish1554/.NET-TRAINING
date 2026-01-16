using System;
class Program4
{
    readonly int orderId;
    public Program4(int id)
    {
        orderId = id;
    }
    static void Main()
    {
        const int c = 5;
        //c = 6; //error const cant change
        Program4 obj = new Program4(12);
        Console.WriteLine(obj.orderId);
    }
}