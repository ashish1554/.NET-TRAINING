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
    public class EmployeeServices
    {
        DepartmentServices dservices=new DepartmentServices();
        public void ShowEmployee(AppDbContext context)
        {
            var employees = context.Employees.AsNoTracking().Include(d=>d.Department).ToList();
            Console.WriteLine("----------EMPLOYEES----------");
            foreach(var item in employees)
            {
                Console.WriteLine($"Id:{item.EmployeeId},Name:{item.Name} Email:{item.Email} Salary:{item.Salary} Department:{item.Department.DepName}");
            }
            Console.WriteLine("========================================================================");
        }

        public void MakeEmployeeTrainer(AppDbContext context)
        {
            Console.WriteLine("Here is the list of employees");

            ShowEmployee(context);

            Console.WriteLine("Enter Employe Id to make trainer : ");
            int empid = int.Parse(Console.ReadLine());

            var employee = context.Employees.Include(et=>et.EmployeeTrainer).FirstOrDefault(e=>e.EmployeeId==empid);
            if(employee==null)
            {
                Console.WriteLine("Employee not found");
                return;
            }


            if(employee.EmployeeTrainer!=null)
            {
                Console.WriteLine("This employee is already trainer");
                return;
            }

            //this query is unneccasary first i implemented using this but this requires extra DB call
            //bool isTrainer = context.EmployeeTrainers.Any(t=>t.EmployeeId==empid);

            //if(isTrainer)
            //{
            //    Console.WriteLine("This employee is already trainer");
            //    return;
            //}

            Console.WriteLine("Enter the Expertise Level : ");
            string exlevel=Console.ReadLine();

            var trainer = new EmployeeTrainer()
            {
                EmployeeId = empid,
                ExpertiseLevel = exlevel
            };

            context.EmployeeTrainers.Add(trainer);
            context.SaveChanges();
            Console.WriteLine("Employee now become a trainer");
        }

        public void ShowTrainer(AppDbContext context)
        {
            var trainers = context.EmployeeTrainers.AsNoTracking().Include(e => e.Employee).ToList();

            foreach(var item in trainers)
            {
                Console.WriteLine($"Trainer id:{item.EmployeeId},Trainer Name:{item.Employee.Name},Expertise leval:{item.ExpertiseLevel}");
            }
        }


        public void RegisterEmployee(AppDbContext context)
        {
            Console.WriteLine("----------Employee Registration----------");

            //name,email,salary,deptid
            Console.WriteLine("Enter name of employee: ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the email of the employee: ");
            string email=Console.ReadLine();

            bool exists = context.Employees.Any(e=>e.Email==email);
            if(exists)
            {
                Console.WriteLine("This email is already exists not allowed");
                return;
            }

            Console.WriteLine("Enter salary of employee: ");
            double salary = double.Parse(Console.ReadLine());

            dservices.ShowDepartments(context);
            Console.WriteLine("Enter the DepartmentId of the employee from above:");
            int deptid = int.Parse(Console.ReadLine());

            bool depexists = context.Departments.Any(d=>d.DepartmentId==deptid);
            if(!depexists)
            {
                Console.WriteLine("This departmentid is not exists");
                return;
            }

            var employee = new Employee()
            {
                Name=name,
                Salary=salary,
                Email=email,
                DepartmentId=deptid
            };

            context.Employees.Add(employee);
            context.SaveChanges();
            Console.WriteLine("Employee added successfully");
        }


        
    }
}
