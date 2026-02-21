using CTMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMS.Services
{
    public class DepartmentServices
    {
        public void ShowDepartments(AppDbContext context)
        {
            var departments = context.Departments.ToList();

            Console.WriteLine("----------DEPARTMENTS----------");

            foreach (var item in departments)
            {
                Console.WriteLine($"DeptId:{item.DepartmentId},DepName:{item.DepName}");
            }
            Console.WriteLine("========================================================================");

        }
    }
}
