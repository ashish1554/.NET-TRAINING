using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMS.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Email { get; set; } = string.Empty;
        public double Salary { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public EmployeeTrainer? EmployeeTrainer { get; set; }

        public List<Enrollment> Enrollments { get; set; }=new List<Enrollment>();

    }
}
