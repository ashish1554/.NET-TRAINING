using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MyApp
{
    public partial class Student
    {
        private string name;
        private int age;
        private string gender;
        private string city;
        private string phone;


        public Student(string name,string gender,string city,string phone,int age,int id,string division,double cgpa,string clg)
        {
            Name= name;
            Gender= gender;
            City= city;
            Phone= phone;
            Age = age;
            Id = id;
            Division = division;
            Cgpa = cgpa;
            Clg = clg;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { if (value>0) age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { if (value.Length == 10) phone = value; }
        }

        public  void Display()
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Personal info:-");
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Academic info:-");
            Console.WriteLine("Id: "+id);
            Console.WriteLine("Id: " + division);
            Console.WriteLine("Id: " + cgpa);
            Console.WriteLine("Id: " + clg);



        }
        public static void Main(string[] args)
        {
            Student s= new Student("Amit","Male","Ahmedabad","8758854578",23, 101, "A", 9.87,"LDCE");
            s.Display();
        }

    }

      

}