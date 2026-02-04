using LINQ3;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

public class LinqEx
{
    public static void Main(string[] args)
    {
        var employees = Employee.GetData();
        var departments = Department.GetData();
        var order = Order.GetData();
        var students=Student.GetData();


        #region TASK-1
        Console.WriteLine("TASK-1");
        var result1 = employees.Where(e => e.Salary > 30000).Select(x=> new {EmpId=x.ID,Ename=x.Name,Salary=x.Salary,DeptId=x.DepartmentId});
        employees.Add(new Employee { ID = 504, Name = "amiraj", Salary = 50000, DepartmentId = 3 });

        foreach(var item in result1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------------------------");
        //Theory
        //Here i observed that the execution type is deferred means query is executed only when it is iterated not at the time of defination
        //Here i add one employee into the list after linq query 
        //but as it is defered execution query is executed at foreach loop iteration so my modified list comes into picture means it is also now added into query consideration
        //so in defered execution any updation before the iteratio can affect the output
        #endregion

        #region TASK-2
        Console.WriteLine("TASK-2");
        var result2 = students.Where(s => s.Marks > 40).Select(x => new { RollNo = x.RollNo, Name = x.Name, Marks = x.Marks }).ToList();
        
        Student obj = students[2];
        obj.Marks = 80;

        foreach (var item in result2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("========================");
        var result3 = students.Where(s => s.Marks > 40).Select(x => new { RollNo = x.RollNo, Name = x.Name, Marks = x.Marks }).ToList();

        foreach (var item in result3)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------------------------");
        //Theory
        //Deferred Execution
        //deferred execution executes the query at the time of iteration not at the time of defination
        //in deferred execution it returns IEnumerable<> type of object
        //in deferred execution change in the query is possible before it runs 
        //Immediate Execution
        //Immediate execution executes the linq query immediately and returns the actual data at the point it call
        //Immediate execution returns data in forms like arrays and list
        //in immediate execution change in the query is not possible

        #endregion

        #region TASK-3
        Console.WriteLine("TASK-3");
        var result4 = order.SelectMany(x => x.OrderItems).Select(o => new { o.ProductName });
        int totalOrder = result4.Count();
        foreach(var item in result4)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Total number of order : "+totalOrder);
        Console.WriteLine("------------------------------------------------");
        //SelectMany is used to flatten the collection 
        //for ex when i do selectmany on orderitems then i got [product1,product2] [product3,product4] when apply selectMany it flatten it into single sequnce like 
        //product1
        //product2 .. like that
        #endregion

        #region TASK-4
        Console.WriteLine("TASK-4");

        var result5=departments.Join(
            employees,
            d=>d.DepartmentId,
            e=>e.DepartmentId,
            (d,e) =>new
            {
                d.Dname,
                e.Name
            }
            ).GroupBy(p => p.Dname).Select(x => new {Dname=x.Key,EmpCount=x.Count()});
        foreach(var item in result5)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------------------------");
        //Theory
        //Here deferred execution type is used because here methods like GroupBy and Select are not executed immediately
        //query runs at foreach loop so that it reduced unnecassary work and runs query only if needed
        //of any modification made then it affect at the iteration in the case of deferred execution
        #endregion

        #region TASK-5
        Console.WriteLine("TASK-5");

        Console.WriteLine("----------Using IEnumerable------------");
        IEnumerable<Employee> ienumerableQuery = employees.Where(e => e.Salary > 30000);
        foreach (var item in ienumerableQuery)
        {
            Console.WriteLine($"Name : {item.Name} , Salary: {item.Salary}");
        }

        Console.WriteLine("----------Using IQueryable------------");
        IQueryable<Employee> iqueryableQuery=employees.AsQueryable().Where(e => e.Salary > 30000);
        foreach (var item in iqueryableQuery)
        {
            Console.WriteLine($"Name : {item.Name} , Salary: {item.Salary}");

        }
        Console.WriteLine("------------------------------------------------");

        //Theory

        //IEnumerable
        //IEnumerable query runs in the memory
        //in this there is no generation of expression tree
        //query is executed without translating it into SQl

        //IQueryable
        //IQueryable query runs on the database
        //in this expression tree is generated
        //query is first translated it into SQl
        #endregion

        #region TASK-6
        Console.WriteLine("TASK-6");

        Console.WriteLine("----------Using N+1 Query------------");
        foreach (var employee in employees)
        {
            var department = departments.FirstOrDefault(d => d.DepartmentId == employee.DepartmentId);
            Console.WriteLine($"{employee.Name} - {department?.Dname}");
        }

        Console.WriteLine("----------Using 1 Query------------");
        var correct = employees.Join(
            departments,
            e => e.DepartmentId,
            d => d.DepartmentId,
            (e, d) => new {Ename=e.Name,Dname=d.Dname}
            );
        foreach(var item in correct)
        {
            Console.WriteLine(item);
        }    
        Console.WriteLine("------------------------------------------------");
        //Thoery
        //N+1 problem is the problem in which when application takes 1 query to fetch parents data and n query to fetch the related data
        //why it is bad?
        //lets take our example i have 10 employees then if we use n+1 query approach then it takes 1 query to fetch parent data and then again it takes 10 query to find related data so tatal 11 query requires
        //it costs us when we work with the DB it causes multiple unnecassary DB calls
        //it is time consuming
        //makes the debuging hard and increase the cost of DB CPU

        #endregion

        #region TASK-7
        Console.WriteLine("TASK-7");
        Console.WriteLine("Total Products : "+totalOrder);
        var result6 = order.SelectMany(x => x.OrderItems).Select(o => new { o.ProductName }).Distinct().Count();
        Console.WriteLine("Unique Products : "+result6);
        Console.WriteLine("------------------------------------------------");
        //Here first i used the selectMany method to flatten the collection and then select the product name from it
        //Distinct():this method give me the unique value from the flatten collectino
        //Count():used to count number of items
        //once i got the product collection into single sequence than i apply Distinct to find the unique product and then count that unique product

        #endregion

        #region TASK-8
        Console.WriteLine("TASK-8");
        var result7 = employees.ToDictionary(x => x.ID, y => y.Name);
        foreach (var item in result7)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------------------------");
        //dictionary first of all store the unique keys
        //ToDictionary() is an immediate execution method because it requires to traverse the entire sequnce to check that every key must be unique
        //deferred execution run only on iteration but for dictionary it is not possible to iterate later because duplicate keys must be found immediately
        #endregion

        #region TASK-9
        Console.WriteLine("TASK-9");
        var result8 = employees.Where(e => e.DepartmentId == 1).Select(x => new { Ename=x.Name,DeptId=x.DepartmentId});
        foreach(var item in result8)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("----------After updating one employee from it to hr------------");
        Employee obj2 = employees[1];
        obj2.DepartmentId = 2;

        var result9 = employees.Where(e => e.DepartmentId == 1).Select(x => new { Ename = x.Name, DeptId = x.DepartmentId });
        foreach(var item in result9)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------------------------");

        //here we first fetch all the employees from it department using Where method which is deferred execution method
        //in first query only query result is stored due to deferred exectuion and executed during foreach iteration
        //after that i modified the one employee into hr department and again print the result that will give me updated once
        #endregion

        #region TASK-10
       // Console.WriteLine("TASK-10");
       // 1)Use Any() instead of Count() > 0:
       //     when we use Count()>0 then it go through the entire collection but Any() stops as soon asit finds the first match
       // 2)N+1 query problem:
       //     It is  required to avoid this N+1 problem because it requires 1 query from parent and n  query from child.
       //     which causes the many DB calls and very time consuming
       // 3)When to use ToList():
       //     ToList() force the immediate execution of query if we use ToList() then query is executed at the time of declaration of query
       //     after execution any data modification wont affect the query result so used when we require data souce not change later
       //     it is also used when we need the result multiple times
       //     it is avoided to use ToList() if we just need the count because it loads the entire collection unnecassary
       //4)Avoid multiple enumeration:
       //     multiple enumeration means same query runs multiple time 
       //     it is bad practice because it causes multiple DB calls unintentinally which slow down the system causes performance issue
       //5)Avoid loops if LINQ is possible
       //     without linq if we use loops then it cause  repeated search and n+1 problems
       //     it is best to use linq query which cause only single execution 
       // Console.WriteLine("------------------------------------------------");
        #endregion


    }
}