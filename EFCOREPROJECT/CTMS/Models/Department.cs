using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMS.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;

        public List<Employee> Employees { get; set; }=new List<Employee>();

    }
}
