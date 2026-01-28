using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
   public class AppConfig
    {
        private readonly string AppName;
        private readonly float Version;
        private readonly DateTime CreatedDate;

        public AppConfig(string AppName,float Version,DateTime CreatedDate)
        {
            this.AppName = AppName;
            this.Version = Version;
            this.CreatedDate = CreatedDate;
        }

        public void Display()
        {
            Console.WriteLine($"Appname : {AppName}");
            Console.WriteLine($"Version : {Version}");
            Console.WriteLine($"CreatedDate : {CreatedDate}");
            Console.WriteLine("-------------------------");


        }
        //this is not allowed we can not change the value once we initialize using constructor
        //public void Change()
        //{
        //    AppName = "newApp";
        //}
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            AppConfig Obj = new AppConfig("Facebook", 10.4f, DateTime.Now);
            AppConfig Obj2 = new AppConfig("Instagram", 9.2f, DateTime.Now);

            Obj.Display();
            Obj2.Display();


        }
    }
}
