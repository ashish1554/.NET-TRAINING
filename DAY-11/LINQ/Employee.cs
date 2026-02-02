using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;


        public static List<Employee> GetData()
        {
            return new List<Employee>
            {
                new Employee { ID = 101 ,Name="Ashish",Salary=25000,Department="IT",City="Ahmedabad" },
                new Employee { ID = 102 ,Name="Ankit",Salary=75000,Department="IT",City="Gandhinagar" },
                new Employee { ID = 103 ,Name="Rahul",Salary=45000,Department="Sales",City="Surat" },
                new Employee { ID = 104 ,Name="Umesh",Salary=10000,Department="Marketing",City="Bhavanagar" },
                new Employee { ID = 105 ,Name="Pankaj",Salary=15000,Department="IT",City="Ahmedabad" },
                new Employee { ID = 106 ,Name="Krunal",Salary=20000,Department="HR",City="Surat" },
                new Employee { ID = 107 ,Name="Raj",Salary=15000,Department="HR",City="Rajkot" },
                new Employee { ID = 108 ,Name="Dhyey",Salary=22000,Department="IT",City="Ahmedabad" },
                new Employee { ID = 109 ,Name="Rudren",Salary=18500,Department="Sales",City="Surat" },
                new Employee { ID = 110 ,Name="Mahesh",Salary=15000,Department="Marketing",City="Ahmedabad" },

            };
        }

    }
}
