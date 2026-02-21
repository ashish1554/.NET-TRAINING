using CTMS.Data;
using CTMS.Services;

public class EFCOREPROJECTAPP
{

   
    public static void Main(string[] args)
    {


        //services
        TrainingProgramService tservice = new TrainingProgramService();
        EmployeeServices eservice = new EmployeeServices();
        EnrollmentService enrservice = new EnrollmentService(); 
        DepartmentServices dservice=new DepartmentServices();



        using AppDbContext context = new AppDbContext();
        
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n===== Corporate Training Management System =====");
            Console.WriteLine("1. Create Training Program");
            Console.WriteLine("2. Register Employee");
            Console.WriteLine("3. Enroll Employee in Training");
            Console.WriteLine("4. Show Training Details (With Employees)");
            Console.WriteLine("5. Show Department Report");
            Console.WriteLine("6. Update Employee Performance");
            Console.WriteLine("7. Delete Training Program");
            Console.WriteLine("8. Exit");


            Console.Write("Enter your choice: ");
            int choice=int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    tservice.CreateTrainingProgram(context);
                    break;

                case 2:
                    eservice.RegisterEmployee(context);
                    break;

                case 3:
                    enrservice.EnrollEmployeeInTraining(context);
                    break;

                case 4:
                     tservice.ShowTrainingDetails(context);
                    break;

                case 5:
                    dservice.DepartmentReport(context);
                    break;

                case 6:
                    enrservice.UpdateEmployeePerformanceScore(context);
                    break;

                case 7:
                    // Delete Training Program
                    // trainingProgramService.DeleteTrainingProgram();
                    break;

                case 8:
                    Console.WriteLine("Exiting application...");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select from 1 to 8.");
                    break;
            }
        }
    }
}


