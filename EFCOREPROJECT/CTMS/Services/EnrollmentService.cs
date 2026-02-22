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
                var employee = context.Employees.Find(eid);
                if (employee == null)
                {
                    Console.WriteLine("Employee not found.");
                    return;
                }

                tservice.ShowTrainingPrograms(context);

                Console.WriteLine("Enter the TrainingProgramID in which you want to enroll the employee:");
                int tid = int.Parse(Console.ReadLine());
                var training = context.TrainingPrograms.Find(tid);
                if (training == null)
                {
                    Console.WriteLine("Training Program not found.");
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


                if(training.TrainerId==eid)
                {
                    Console.WriteLine("Employee you try to enroll in the trainingProgram is already trainer of that program");
                   return;
                }

                //first i used to many Any in my code that causes multiple DB call so i modified like this is not necassry
                //var alreadyTrainer = context.TrainingPrograms.Any(x=>x.TrainingProgramId==tid && x.TrainerId==eid);

                //if(alreadyTrainer)
                //{
                //    Console.WriteLine("Employee you try to enroll in the trainingProgram is already trainer of that program");
                //    return;
                //}


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
            tservice.ShowTrainingPrograms(context);
            Console.WriteLine("Enter the ID of the specific TrainingProgram in which you want to update Employee Performance score of employee :");
            int id = int.Parse(Console.ReadLine());

            //first i implement using this but then i do some search and find that this cause one more extra db call this work also done with below query also
            //bool texists = context.TrainingPrograms.Any(x => x.TrainingProgramId == id);
            //if (!texists)
            //{
            //    Console.WriteLine("Trainingprogram with this Id is not found");
            //    return;
            //}

            var training = context.TrainingPrograms.Include(enr => enr.Enrollments).ThenInclude(emp => emp.Employee).ThenInclude(dep => dep.Department).FirstOrDefault(tra => tra.TrainingProgramId == id);

            if(training==null)
            {
                Console.WriteLine("Trainingprogram with this Id is not found");
                    return;
            }
            if (training.Enrollments.Count() == 0)
            {
                Console.WriteLine("No employees enrolled yet.");
                return;
            }

            tservice.ShowTrainingDetails(context, id);

            Console.WriteLine("Enter the employeeId you want to update the performance score");
            int empid = int.Parse(Console.ReadLine());


            //this is also redundant db call
            //bool exists = context.Enrollments.Any(x=>x.EmployeeId==empid && x.TrainingProgramId==id);
            //if (!exists)
            //{
            //    Console.WriteLine("Employee with this Id is not found in this specific trainingprogram");
            //    return;
            //}

            var enroll = context.Enrollments.FirstOrDefault(x=>x.EmployeeId==empid && x.TrainingProgramId==id);
            if (enroll==null)
            {
                Console.WriteLine("Employee with this Id is not found in this specific trainingprogram");
                return;
            }

            Console.WriteLine("Enter the performance score for employee:");
            int performanceScore=int.Parse(Console.ReadLine());

            if (performanceScore<0 || performanceScore>100)
            {
                Console.WriteLine("Performance score >100 or <0 is not allowed");
                return;
            }

                enroll.PerformanceScore = performanceScore;

            context.SaveChanges();
            Console.WriteLine("Performance Score Updated Successfully");
           
            


        }
    }
}
