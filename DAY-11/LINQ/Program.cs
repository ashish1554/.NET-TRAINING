using LINQ;
using System;
using System.Linq;

public class LinqEx
{
    public static void Main(string[] args)
    {
        var employees = Employee.GetData();

        #region TASK-1
        //TASK-1
        //You have a list of employees. Write a LINQ query to fetch all employees whose salary is greater than 25000.

        Console.WriteLine("TASK : 1");

        var result1 = employees.Where(e => e.Salary > 25000).Select((e) => new {e.ID,e.Name,e.Salary});


        //var result1= from e in employees
        //         where e.Salary>25000
        //         select new { e.Name,e.ID,e.Salary};

        foreach (var employee in result1)
        {
            Console.WriteLine(employee);
        }
        Console.WriteLine("----------------------------------------------------------");
       //Theory:
       //I used Where method to filter the employee whose salary is above 25000
       //Where():it is used for filtering and return only those elements that satisfy the condition 
       //we use Where to retrive the data that satisfy the condition without modifying the orignal data
        #endregion


        #region TASK-2
        //TASK-2
        //You have a list of employees. Write a LINQ query to fetch employee name and salary only for employees working in the “IT” department.
        Console.WriteLine("TASK : 2");
        var result2 = employees.Where(e => e.Department == "IT").Select((e) => new {e.Name,e.Salary});
        //var result2 = from e in employees
        //              where e.Department == "IT"
        //              select new { e.Name, e.Salary };
        foreach (var employee in result2)
        {
            Console.WriteLine(employee);
        }
        Console.WriteLine("----------------------------------------------------------");
        //Thoery
        //Where():it filter record based on the condition
        //Select(): it is used to select the required fields only 
        //here Where() method filter the data based on the IT department 
        //here if we dont use Select() method then we got all the fields of employee which is unnecassary for me so Select() gives only  required fields

        #endregion


        #region TASK-3
        Console.WriteLine("TASK : 3");

        var result3 = employees.Where(e=>e.Salary>30000).OrderBy(e => e.Salary).Select(e => new {e.ID,e.Name,e.Salary});

        //var result3 = from e in employees
        //               where e.Salary>30000
        //              orderby e.Salary
        //              select new { e.ID, e.Name, e.Salary };
        foreach (var employee in result3)
        {
            Console.WriteLine(employee);
        }
        Console.WriteLine("----------------------------------------------------------");
        //Thoery
        //OrderBy():it is used to sort the data based on our need by default it is ascending
        // here first i find employee using Where method whose salary is above 30000 then i applies sorting using OrderBy() based on salary
        //then using Select() i select the fields that are required
        
        #endregion


        #region TASK-4

        Console.WriteLine("TASK : 4");

        var result4 = employees.OrderBy(e => e.Department).ThenBy(e => e.Name).Select(e => new { e.ID, e.Name, e.Department });

        //var result4 = from e in employees
        //              orderby e.Department, e.Name
        //              select new { e.ID, e.Name, e.Department };

        foreach (var employee in result4)
        {
            Console.WriteLine(employee);
        }
        Console.WriteLine("----------------------------------------------------------");
        //Theory
        //ThenBy():thenby method is used for applying further sorting  that already been sorted using OrderBy()
        //OrderBy() sort only one item at a time if we want further sorting than we need to use ThenBy()
        #endregion


        var students = Student.GetData();

        #region TASK-5

        Console.WriteLine("TASK : 5");

        var result5 = students.Select(s => new { s.Name, s.Marks ,result=s.Marks>=40 ? "PASS" : "FAIL"});
        //var result5 = from s in students
        //              select new { s.Name, s.Marks, result = s.Marks >= 40 ? "PASS" : "FAIL" };

        foreach (var employee in result5)
        {
            Console.WriteLine(employee);
        }
        Console.WriteLine("----------------------------------------------------------");
        //Theory
        //In this i created new field inside the anonymos object using the turnary operator  
        //first i check the condtion based on that what value i need if condition is true and false i set those
        //using anonymos object i can return the multiple readonly field 
        #endregion

        #region TASK-6

        Console.WriteLine("TASK : 6");

        var result6 = employees.Select(e => new { e.Name, e.Department, e.City });

        //var result6 = from e in employees
        //              select new { e.Name, e.Department, e.City };
        foreach (var item in result6)
        {
            Console.WriteLine(item);
        }
     
        Console.WriteLine("----------------------------------------------------------");
        //Thoery
        // Anonymous type is used to create temporary object 
        //using this we can avoid creating the classes  for temporary and small data
        //it returns the readonly data so it is not possible to change the field of anonymous object

        #endregion

        var order = Order.GetData();


        #region TASK-7
        var result7 = order.SelectMany(o => o.OrderItems).Select(p=>p.ProductName);
       
        Console.WriteLine("TASK : 7");

        foreach (var item in result7)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n----------------------------------------------------------");
        //Thoery 
        //SelectMany():SelectMany() is used to flatten the collection into the single sequence
        //Here SelectMany() converts nested collection into single flat sequence  here each order have multiple orderItems so here one to many relationship is possible
        //if we use only select then we got list of list(means nested collection) 

        #endregion

        #region TASK-8 
        Console.WriteLine("TASK : 8");

        var result8 = order.SelectMany(o => o.OrderItems.Select(p=>new {o.CustomerName,p.ProductName}) );
        //var result8 = from o in order
        //              from p in o.OrderItems
        //              select new { o.CustomerName, p.ProductName };
        //var result8 = order.SelectMany(o => o.OrderItems, (o, item) => new { o.OrderItems, item.ProductName });
        foreach (var item in result8)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("----------------------------------------------------------");
        //Thoery 
        //SelectMany():SelectMany() is used to flatten the collection into the single sequence
        //Here SelectMany() converts nested collection into single flat sequence  here each order have multiple orderItems so here one to many relationship is possible
        //if we use only select then we got list of list(means nested collection) 
        #endregion

        #region TASK-9
        Console.WriteLine("TASK : 9");
        var result9 = employees.Select(e => e.Name ).ToList();
        foreach(var item in result9)
        {
            Console.Write(item+ " ");
        }
        Console.WriteLine("\n----------------------------------------------------------");

        #endregion

        #region TASK-10 
        Console.WriteLine("TASK : 10");

        var result10 = employees.Where(e => e.Salary > 25000).Select(e => new {e.ID,e.Name,e.Salary});
        var result11 = from e in employees
                       where e.Salary > 25000
                       select new { e.ID, e.Name, e.Salary };
        foreach (var item in result10)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");
        foreach (var item in result11)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("----------------------------------------------------------");
        //Theory
        //method syntax uses methods like Where,Select,SelectMany.query syntax is uses SQL like statement
        //method syntax allows use of lambda function. In query syntax there is no lambda function
        //Internally query syntax is converted into the method syntax
        

        #endregion



    }
}