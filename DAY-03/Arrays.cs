using System;
using System.Collections;
using System.Collections.Generic;

public class Arrays
{
	public class Student
	{
		public int id;
		public string name;
		public double cpi;

		public Student(int id,string name,double cpi)
		{
			this.id = id;
			this.name = name;
			this.cpi = cpi;
		}
    }
	public static void Main(string[] args)
	{
		//Using Array
		Student[] student = new Student[3];

		//Adding the data
		Console.WriteLine("Arrays Task");
		Console.WriteLine("==================================");

		student[0] = new Student(101, "Ashish",9.29);
        student[1] = new Student(102, "Aman",9.10);
        student[2] = new Student(103, "Ajay",8.98);

		//search
		Console.WriteLine("Search");
		for(int i=0;i<student.Length;i++)
		{
			if (student[i].id==102)
			{
				Console.WriteLine("Found at id : " + student[i].id  + "name:" + student[i].name);
			}
		}

		//update
		Console.WriteLine("=========================================");
		Console.WriteLine("Update");
        for (int i=0;i<student.Length;i++)
		{
            if(student[i].id == 103)
            {
                Console.WriteLine("Before Update name is : " + student[i].name);
                student[i].name = "Anisha";
                Console.WriteLine("Update name at id : " + student[i].id);
				Console.WriteLine("After Update name is : " + student[i].name);
            }
        }


		//Using List

		Console.WriteLine("==================================");
		Console.WriteLine("List Task");
        Console.WriteLine("==================================");

        List<Student> ll = new List<Student>();
		
		//adding to list
		ll.Add(new Student(101,"Ankit",9.87));
        ll.Add(new Student(101, "Anita", 8.87));

		//Search
		Student SearchResult=ll.Find(x => x.id == 101); //this will return  first matching object
		int inx = ll.IndexOf(SearchResult); //this will return the index of that object
		Console.WriteLine("Searched for id : " + ll[inx].id + " name:" + ll[inx].name);
        Console.WriteLine("==================================");


        //Update 
        if (inx!=-1)
		{
            Console.WriteLine("Before Update name is : " + ll[inx].name);
            ll[inx].name = "kajal";
            Console.WriteLine("After Update name is : " + ll[inx].name);
        }


		//using dictionary

		Console.WriteLine("Dictinory Assignment");

		Dictionary<int,Student> dic = new Dictionary<int,Student>();

		//Add
		dic.Add(101,new Student(101,"Ketan",7.87));
        dic.Add(102, new Student(102, "Amit", 8.87));


		//Update and Searching
		//using ContainsKey
		if(dic.ContainsKey(101))
		{
			dic[101].name = "Rahul";
		}
		//using dic[specific inx]
		dic[102] = new Student(102,"Deep",7.98);

		//using trygetvalue

		if (dic.TryGetValue(101, out Student s))
		{
			dic[101].name = "Kartik";
			Console.WriteLine("Found : "+ s.name);
		}
		else
		{
			new Student(101,"Pankaj",9.78);
		}
		
    }
}
