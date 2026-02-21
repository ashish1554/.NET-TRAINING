using CTMS.Data;
using CTMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMS.Services
{
    public class TrainingProgramService
    {
        EmployeeServices employeeServices = new EmployeeServices();
        public void CreateTrainingProgram(AppDbContext context)
        {
            Console.WriteLine("Enter the title of the training : ");
            string title = Console.ReadLine();
            bool exists = context.TrainingPrograms.Any(t => t.Title == title);
            if (exists)
            {
                Console.WriteLine("Title already exists not allow to enter duplicate title");
                return;
            }
            Console.WriteLine("Enter the duration of the training in days");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the course start date in YYYY-MM-DD format");
            DateOnly startdate = DateOnly.Parse(Console.ReadLine());


            employeeServices.ShowTrainer(context);
            Console.WriteLine("Here are the list of the trainers enter the id you want to make trainer for this training program :");
            int tid = int.Parse(Console.ReadLine());

            var trainer = context.Employees.Find(tid);
            if (trainer == null) 
            {
                Console.WriteLine("Trainer with this id is not exists");
                return;
            }

           
           
                var trainingprogram = new TrainingProgram()
                {
                    Title = title,
                    Duration = duration,
                    StartDate = startdate,
                    TrainerId = tid
                };
                context.TrainingPrograms.Add(trainingprogram);
                context.SaveChanges();
                Console.WriteLine("Training Program Added");
        }

        public void ShowTrainingPrograms(AppDbContext context)
        {
            var trainingprograms = context.TrainingPrograms.ToList();
            Console.WriteLine("----------Employee Registration----------");

            foreach (var item in trainingprograms)
            {
                Console.WriteLine($"TrainingProgramId:{item.TrainingProgramId},Title:{item.Title},Duration:{item.Duration},StartDate:{item.StartDate}");
            }
            Console.WriteLine("========================================================================");

        }
    }
}
