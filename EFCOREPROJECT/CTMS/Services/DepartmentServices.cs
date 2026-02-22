using CTMS.Data;
using CTMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMS.Services
{
    public class DepartmentServices
    {

        public void MakeDepartment(AppDbContext context)
        {
            Console.WriteLine("Enter the name of the department");
            string name=Console.ReadLine();

            Console.WriteLine("Enter the location of department");
            string location=Console.ReadLine();

            var department = new Department();
            department.DepName = name;
            department.Location = location;
            

            context.Departments.Add(department);
            context.SaveChanges();
            Console.WriteLine("Department added succesfully");
        }
        public void ShowDepartments(AppDbContext context)
        {
            var departments = context.Departments.AsNoTracking().ToList();

            Console.WriteLine("----------DEPARTMENTS----------");

            foreach (var item in departments)
            {
                Console.WriteLine($"DeptId:{item.DepartmentId},DepName:{item.DepName}");
            }
            Console.WriteLine("========================================================================");

        }

        public void DepartmentReport(AppDbContext context)
        {
            ShowDepartments(context);

            Console.WriteLine("Enter the departmentId for which you want the report:");
            int id = int.Parse(Console.ReadLine());

            bool exists = context.Departments.AsNoTracking().Any(did=>did.DepartmentId==id);

            if (!exists)
            {
                Console.WriteLine("Department with this ID is not exists");
                return;
            }


            //here first i try to find the employee count without using the include
            //then i analyze by putting the breakpoint and i observe that i got count=0 means employees and enrollments are not loaded
            //this can be solved by using two ways:1.If i enable lazy loading then i got related entities at the time query executed on that
            //2.using Eager loading that includes then necassary entity in one query so now i got employee count instead of 0
            //var name = context.Departments.Where(d=>d.DepartmentId==id).Select(d=>d.DepName).FirstOrDefault();
            var dept = context.Departments.AsNoTracking().Include(e=>e.Employees).ThenInclude(en=>en.Enrollments).FirstOrDefault(d=>d.DepartmentId==id);
            int deptCount = dept.Employees.Count();

            var enrollCount = dept.Employees.Count(e => e.Enrollments.Any());


            Console.WriteLine("Department : "+dept.DepName);
            Console.WriteLine("Total Employees : "+deptCount);
            Console.WriteLine("Employee Enrolled in Training : "+enrollCount);




        }
    }
}
