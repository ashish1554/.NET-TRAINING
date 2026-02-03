using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ2
{
    public class Department
    {
        public string Dname {  get; set; }
        public int DepartmentId {  get; set; }

        public static List<Department> GetData()
        {
            return new List<Department>()
            {
                new Department{Dname="IT",DepartmentId=1},
                new Department{Dname="HR",DepartmentId=2},
                new Department{Dname="Sales",DepartmentId=3},
                new Department{Dname="Marketing",DepartmentId=4},
                new Department{Dname="Content",DepartmentId=8}

            };
        }
    }
}
