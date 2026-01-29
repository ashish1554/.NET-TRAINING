
using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndMethodOverriding
{
    public class Base
    {
        public Base(int x):this()
        {
            Console.WriteLine("Base class paramterrized constructor is called");
        }
        public Base()
        {
            Console.WriteLine("Base constructor start logging");
        }


    }
    public class Derived : Base
    {
        public Derived():base(56)
        {
            Console.WriteLine("Base Constructor finish logging");

            Console.WriteLine("Derived class now start..");

            string name = "ashish";
            Console.WriteLine("Derived class now start working");
            Console.WriteLine("Derived class constructor initializes new field name : "+name);
        }
    }
    public class baseEx
    {
        public static void Main(string[] args)
        {
            
            Base bd = new Derived();
        }
    }
}
