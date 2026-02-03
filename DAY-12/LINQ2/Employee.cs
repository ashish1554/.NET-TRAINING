using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ2
{
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }
            public int DepartmentId { get; set; } 
            public string City { get; set; } = string.Empty;


            public static List<Employee> GetData()
            {
                return new List<Employee>
            {
                new Employee { ID = 101 ,Name="Ashish",Salary=25600,DepartmentId=1 },
                new Employee { ID = 102 ,Name="Ankit",Salary=75000,DepartmentId=1},
                new Employee { ID = 103 ,Name="Rahul",Salary=45000,DepartmentId=2},
                new Employee { ID = 104 ,Name="Umesh",Salary=10000,DepartmentId=3},
                new Employee { ID = 105 ,Name="Pankaj",Salary=15000,DepartmentId=1},
                new Employee { ID = 106 ,Name="Krunal",Salary=20000,DepartmentId=4},
                new Employee { ID = 107 ,Name="Raj",Salary=15000,DepartmentId=4},
                new Employee { ID = 108 ,Name="Dhyey",Salary=26000,DepartmentId=1},
                new Employee { ID = 109 ,Name="Rudren",Salary=18500,DepartmentId=2},
                new Employee { ID = 110 ,Name="Mahesh",Salary=15000,DepartmentId=3},
                new Employee { ID = 110 ,Name="Maheshssss",Salary=15000,DepartmentId=5},


            };
            }

        }
}


