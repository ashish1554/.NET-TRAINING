using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public class Student
    {
        public string Name {  get; set; }
        public double RollNo {  get; set; }

        public double Marks {  get; set; }
       
        public static List<Student> GetData()
        {
            return new List<Student>
            {
                new Student { Name = "Amit", RollNo = 220280107109, Marks = 54 },
                new Student { Name = "Ajay", RollNo = 220280107110, Marks = 94 },
                new Student { Name = "Rahul", RollNo = 220280107111, Marks = 35 },
                new Student { Name = "Ashish", RollNo = 220280107112, Marks = 35 },
                new Student { Name = "Rahul", RollNo = 220280107113, Marks = 32 },
                new Student { Name = "Akash", RollNo = 220280107114, Marks = 40 },
                new Student { Name = "Mahendra", RollNo = 220280107115, Marks = 75 },


            };
        }
    }


}
