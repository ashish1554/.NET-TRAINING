using CTMS.Data;
using CTMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMS.Services
{
    public class EnrollmentService
    {
        EmployeeServices eservice = new EmployeeServices();
        TrainingProgramService tservice= new TrainingProgramService();
        public void EnrollEmployeeInTraining(AppDbContext context)
        {
            try
            {
                eservice.ShowEmployee(context);
                Console.WriteLine("Enter the ID of the employee you want to enroll:");
                int eid = int.Parse(Console.ReadLine());
                bool empexists = context.Employees.Any(e => e.EmployeeId == eid);
                if (!empexists)
                {
                    Console.WriteLine("Employee with this id is not exists");
                    return;
                }

                tservice.ShowTrainingPrograms(context);
                Console.WriteLine("Enter the TrainingProgramID in which you want to enroll the employee:");
                int tid = int.Parse(Console.ReadLine());
                bool traexists = context.TrainingPrograms.Any(t => t.TrainingProgramId == tid);
                if (!traexists)
                {
                    Console.WriteLine("There is no trainingprogram exists with this ID");
                    return;
                }


                //even though if we dont check manually we are not able to insert duplicate enrollment
                //because we make PK(TrainingProgramId,EmployeeId) as composite key sql server through the exception and prvents the duplicate enrollment
                var enroll = context.Enrollments.Any(e => e.EmployeeId == eid && e.TrainingProgramId == tid);
                if (enroll)
                {
                    Console.WriteLine("Employee is already enroll in this training");
                    return;
                }

                var alreadyTrainer = context.TrainingPrograms.Any(x=>x.TrainingProgramId==tid && x.TrainerId==eid);
                
                if(alreadyTrainer)
                {
                    Console.WriteLine("Employee you try to enroll in the trainingProgram is already trainer of that program");
                    return;
                }


                Console.WriteLine("Enter the enrollment date from which you want to join employee in YYYY-MM-DD format:");
                DateOnly enrolldate = DateOnly.Parse(Console.ReadLine());

                var enrollment = new Enrollment()
                {
                    EmployeeId = eid,
                    TrainingProgramId = tid,
                    EnrollDate = enrolldate
                };

                context.Enrollments.Add(enrollment);
                context.SaveChanges();

                Console.WriteLine("Enroll employee successfully");
            }
            catch (DbUpdateException ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void UpdateEmployeePerformanceScore(AppDbContext context)
        {
            tservice.ShowTrainingDetails(context);

            Console.WriteLine("Enter the employeeId you want to update the performance score");
            int empid = int.Parse(Console.ReadLine());
            bool exists = context.Enrollments.Any(x=>x.EmployeeId==empid);

            if (!exists)
            {
                Console.WriteLine("Employee with this Id is not found");
                return;
            }

            //Console.WriteLine("Enter the Id of TrainingProgram in which you want to update the employee score ");
            //int tid = int.Parse(Console.ReadLine());

            //bool texists = context.Enrollments.Any(x => x.TrainingProgramId == tid);

            //if (!texists)
            //{
            //    Console.WriteLine("Trainingprogram with this Id is not found");
            //    return;
            //}

            Console.WriteLine("Enter the performance score for employee:");
            int performaceScore=int.Parse(Console.ReadLine());

            var enroll = context.Enrollments.FirstOrDefault(x=>x.EmployeeId==empid && x.TrainingProgramId==tid);
            enroll.PerformanceScore = performaceScore;

            context.SaveChanges();
           
            


        }
    }
}
