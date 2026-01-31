using System;
using NameSpaceEx.Project1;
using NameSpaceEx.Project2;

public class Program
{
    public static void Main(string[] args)
    {
        //This is naming conflicts
        //Class1 Obj = new Class1();
        //If i use like this then it can not decide from which project to call the method
        //Class1.Method();
        NameSpaceEx.Project1.Class1.Method();
        NameSpaceEx.Project2.Class1.Method();

    }
}