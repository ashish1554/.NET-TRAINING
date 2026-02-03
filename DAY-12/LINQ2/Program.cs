using LINQ2;
using System;

public class LinqEX
{
    public static void Main()
    {
        var employees = Employee.GetData();
        var departments = Department.GetData();


        #region TASK-1
        Console.WriteLine("TASK-1");
        double highSalary = employees.Max(e => e.Salary);
        double lowSalary = employees.Min(e => e.Salary);
        double totalSalary = employees.Sum(e => e.Salary);
        double avgSalary = employees.Average(e => e.Salary);
        //double avg = employees.Sum(e => e.Salary) / employees.Count();

        //Theory
        //Here i used Aggregate functions like Max(),Min(),Sum(),Average()
        //Aggregate functions are basically used to reduced the collections into single result
        //Max()-find maximum value from collection
        //Min()-find minimum value from collection
        //Sum()-find total of numerical values
        //Average()-find the average

        //var result = from e in employees
        //              join d in departments
        //              on e.DepartmentId equals d.DepartmentId
        //              group d by d.Dname into x
        //              select new { Depar = x.Key, count=x.Count()};

        var result = employees.Join(
            departments,
            e => e.DepartmentId,
            d => d.DepartmentId,
            (e, d) => new
            {
                e.Name,
                d.Dname
            }
            ).GroupBy(p => p.Dname).Select(x => new { Department =x.Key,TotalEmployees=x.Count()});


        Console.WriteLine($"Highest Salary : {highSalary}");
        Console.WriteLine($"Lowest Salary : {lowSalary}");
        Console.WriteLine($"Total Salary : {totalSalary}");
        Console.WriteLine($"Average Salary : {avgSalary}");
        //Console.WriteLine($"Highest Salary : {avg}");
        foreach (var d in result)
        {
            Console.WriteLine(d);
        }
        Console.WriteLine("--------------------------------------------------------------");
        //Theory
        //Here i use Join() and GroupBy() methods
        //Join():it is used to group the both employees and departments tabel based on the common key
        //GroupBy():it stores the data into the group based on the key and returns grouped collections
        //here first i joined employees and department based on the common key departmentId 
        //after join i applied groupby based on the Dname 
        #endregion


        #region TASK-2
        Console.WriteLine("TASK-2");

        var result2 = employees.GroupJoin(
            departments,
            e => e.DepartmentId,
            d => d.DepartmentId,
            (e, DepartmentGrp) => new { e, DepartmentGrp }
            ).SelectMany(
             p => p.DepartmentGrp.DefaultIfEmpty(),
             (p, grp) => new
             {
                 EmployeeName = p.e.Name,
                 Department=grp?.Dname !=null ? grp.Dname :"Employee has no department"
             });

        //var result2 = from e in employees
        //              join d in departments
        //              on e.DepartmentId equals d.DepartmentId into grp
        //              from dept in grp.DefaultIfEmpty()
        //              select new { EmployeeName = e.Name, Department = dept?.Dname!=null ? dept.Dname : "Employee has no department" };

        foreach(var item in result2)
        {
            Console.WriteLine(item);
        }

        var result3 = departments.GroupJoin(
    employees,
    d => d.DepartmentId,
    e => e.DepartmentId,
    (d, EmployeeGrp) => new { d, EmployeeGrp }
    ).SelectMany(
     p => p.EmployeeGrp.DefaultIfEmpty(),  
     (p, grp) => new
     {
         DepartmentName = p.d.Dname,
         EmployeeName =grp?.Name != null ? grp.Name :"No employee found"
     });
        Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");


        foreach (var item in result3)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--------------------------------------------------------------");

        //Theory
        //In Query1 i used GroupJoin group join basically act like the left join that return the data from left side and matched one from the left side
        //the result of the GroupJoin is one item from the left side and the collection of all item matching in right side
        //after group by we have p={ e, DepartmentGrp } here e=employees and DepartmentGrp=Ienumerable<Department> 
        //this Ienumerable<Department> has [it],[hr]..[] 
        //then i use SelectMany to flatten the result means employee+department
        //if we dont use SelectMany then linq treate it like the collection and so we dont got the flatten items

        //In query2 same logic is applied 
        #endregion


        #region TASK-3

        Console.WriteLine("TASK-3");

        var result4 = employees.Join(
           departments,
           e => e.DepartmentId,
           d => d.DepartmentId,
           (e, d) => new
           {
               e.Salary,
               d.Dname
           }
           ).GroupBy(p => p.Dname).Select(x => new { Department = x.Key, TotalEmployees = x.Count() ,AverageSalary=x.Average(s=>s.Salary)});
        foreach (var item in result4)
        {
            Console.WriteLine(item); 
        }
        Console.WriteLine("--------------------------------------------------------------");
        //Theory
        //Here i use Join based on the common key departmentId so i got the  Ienumerable object that has Dname and Salary
        //which i passed to groupby and i groupby record based on the Dname
        //so i have group based on the departmentname like Ex."IT" in this group i have salary,Dname group under the "IT" which is the key for groupby
        //using this key i found total rows in that group using count and using x.Average i found average salary 
        #endregion


        #region TASK-4

        Console.WriteLine("TASK-4");
        Console.WriteLine("employees whose salary is greater than the average salary of all employees");
        Console.WriteLine($"Average Salary : {avgSalary}");
        var result5 = employees.Where(
            e => e.Salary > avgSalary)
            .Select(x => new { EmployeeName = x.Name, Salary = x.Salary  });
        foreach (var item in result5)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");
        Console.WriteLine("employee whose salary more than the highest salary in the HR department.");
        double maxSalary = employees.Where(e => e.DepartmentId == 2).Max(s => s.Salary);
        Console.WriteLine($"Highest salary in HR : {maxSalary} ");
        var result6 = employees.Where(e => e.Salary > maxSalary).Select(x => new { EmployeeName = x.Name, Salary = x.Salary });
        foreach (var item in result6)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--------------------------------------------------------------");
        //Thoery
        //QUERY-1
        //in query one i used the avgsalary that i already calculated in the task1 
        //after that i use where to filter out employee whose salary is greater than avgsalary
        //and then select the specific field that i want using select method

        //QUERY-2
        //in query-2 first i find the maxSalary in the HR department
        //using this max salary and where method i find the employee whose salary is greater then this maxSalary 
        //and then using select method i select the fields that i want

        #endregion


        #region TASK-5

        List<int> ll1 = new List<int> {1,2,3,4,5,6,7,8,9 };
        List<int> ll2 = new List<int> { 1, 2, 4, 5, 8, 9,12,23 };

        Console.WriteLine("TASK-5");

        Console.WriteLine("elements that are common in both lists.");
        var intersection = ll1.Intersect(ll2);
        foreach (var item in intersection)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n----------------------");

        Console.WriteLine("elements that are in the first list but not in the second.");
        var except = ll1.Except(ll2);
        foreach (var item in except)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine("\n----------------------");


        Console.WriteLine("Combine both lists and remove duplicates.");
        var union = ll1.Union(ll2);
        foreach (var item in union)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine("\n----------------------");
        //Theory
        //Intersect() is used to find the common elements between two list
        //Except()  is used to find elements that are present in first list but not in the second list
        //Union()  is used to combine both the list and automatically removes the dublicate elements
        #endregion

    }
}