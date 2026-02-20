// See https://aka.ms/new-console-template for more information
using EFCORE;
using EFCORE.Data;
using EFCORE.EF_Loading;
using EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Transactions;


public class EFex
{


    public static void Main(string[] args)
    {
        Services service=new Services();
        using AppDbContext context = new AppDbContext();

        LoadingEx ex=new LoadingEx();


        int no;
        do
        {
            Console.WriteLine("----------SELECT MENU----------");
            Console.WriteLine("Enter 1 for add students");
            Console.WriteLine("Enter 2 for add courses");
            Console.WriteLine("Enter 3 for show students");
            Console.WriteLine("Enter 4 for show courses");
            Console.WriteLine("Enter 5 for add trainer");
            Console.WriteLine("Enter 6 for add batch");
            Console.WriteLine("Enter 7 for enroll student");
            Console.WriteLine("Enter 8 for show course with student");
            Console.WriteLine("Enter 9 to update student detail");
            Console.WriteLine("Enter 10 to delete student");
            Console.WriteLine("Enter 11 to update trainer details");
            Console.WriteLine("Enter 12 to delete trainer");
            Console.WriteLine("Enter 13 to show trainer");
            Console.WriteLine("Enter 14 to update course details");
            Console.WriteLine("================================================");
            Console.WriteLine("Enter 15  for demontrasition of detached state");
            Console.WriteLine("Enter 16  for demo of lazy,eager,explicit loading");
         



            Console.WriteLine("----------------------------------------");

            no = int.Parse(Console.ReadLine());

            switch(no)
            {
                case 1:service.AddStudents(context);
                       break;
                case 2:
                    service.AddCourses(context);
                    break;
                case 3:
                    service.ShowStudents(context);
                    break;
                case 4:
                    service.ShowCourses(context);
                    break;
                case 5:
                    service.AddTrainer(context);
                    break;
                case 6:
                    service.AddBatch(context);
                    break;
                case 7:service.EnrollStudents(context);
                    break;
                case 8:service.ShowCoursesWithStudent(context);
                    break;
                case 9:service.UpdateStudentDetails(context);
                    break;
                case 10:service.DeleteStudent(context);
                    break;
                case 11:service.UpdateTrainerDetails(context);
                    break;
                case 12:
                    service.DeleteTrainer(context);
                    break;
                case 13:service.showTrainer(context);
                    break;
                case 14:
                    service.UpdateCourseDetails(context);
                    break;
                case 15:
                    service.DetachedDemo(context);
                    break;
                case 16:
                    ex.LoadingDemo(context);
                    break;

            }
            Console.WriteLine("Enter  1 to continue and 0 to exit..");
            no = int.Parse(Console.ReadLine());
        } while (no != 0);

    }
}

