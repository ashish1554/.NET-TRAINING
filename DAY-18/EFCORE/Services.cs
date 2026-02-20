using EFCORE.Data;
using EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE
{
    public class Services
    {
         
        public  void AddStudents(AppDbContext context)
        {
            Console.WriteLine("Enter Name:");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter Email");
            string? email = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            int marks = int.Parse(Console.ReadLine());
            DateTime created = DateTime.Now;
            var student = new Student()
            {
                Name = name,
                Email = email,
                Marks = marks,
                CreatedAt = created

            };
            context.Students.Add(student);
            var entry = context.Entry(student);
            Console.WriteLine("State :" + entry.State);
            context.SaveChanges();
            Console.WriteLine("State :" + entry.State);


        }

        public  void AddCourses(AppDbContext context)
        {
            Console.WriteLine("Enter Title of course:");
            string? title = Console.ReadLine();
            Console.WriteLine("Enter Fees");
            double fees = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter total months");
            int months = int.Parse(Console.ReadLine());
            var course = new Course()
            {
                TItle = title,
                Fees = fees,
                DurationInMonths = months
            };

            context.Courses.Add(course);
            var entry = context.Entry(course);
            Console.WriteLine("State :" + entry.State);
            context.SaveChanges();
            Console.WriteLine("State :" + entry.State);

        }
        public  void ShowStudents(AppDbContext context)
        {

            var result = context.Students.ToList();
            Console.WriteLine("----------Student----------");
            foreach (var item in result)
            {
                Console.WriteLine($"Name:{item.Name} , Email:{item.Email} , Marks:{item.Marks} , Created:{item.CreatedAt}");
            }

        }
        public  void ShowCourses(AppDbContext context)
        {
            Console.WriteLine("----------Courses----------");

            var result = context.Courses.ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"Title:{item.TItle} Fees:{item.Fees} Duration:{item.DurationInMonths}months");
            }

        }
        public  void AddTrainer(AppDbContext context)
        {
            Console.WriteLine("Enter name of the trainer: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter the experience");
            int exp = int.Parse(Console.ReadLine());


            var trainer = new Trainer()
            {
                Name = name,
                Experience = exp
            };

            context.Trainers.Add(trainer);
            var entry = context.Entry(trainer);
            Console.WriteLine("State :" + entry.State);
            context.SaveChanges();
            Console.WriteLine("State :" + entry.State);

        }
        public  void AddBatch(AppDbContext context)
        {
            Console.WriteLine("Enter Course start date : ");
            DateOnly date = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name of the course");
            string cname= Console.ReadLine();
            var course = context.Courses.FirstOrDefault(x=>x.TItle==cname);

            Console.WriteLine("Enter the name of the trainer");
            string tname=Console.ReadLine();
            var trainer = context.Trainers.FirstOrDefault(x=>x.Name==tname);


            var batch = new Batch();
            batch.StartDate= date;
            batch.CourseId = course.Id;
            batch.TrainerId = trainer.TrainerId;

            context.Batches.Add(batch);
            var entry = context.Entry(batch);
            Console.WriteLine("State :" + entry.State);
            context.SaveChanges();
            Console.WriteLine("State :" + entry.State);
        }
        public  void EnrollStudents(AppDbContext context)
        {
            
            ShowStudents(context);
            ShowCourses(context);
            Console.WriteLine("Enter the name of the student");
            string sname = Console.ReadLine();
            Console.WriteLine("Enter the title of the course");
            string cname= Console.ReadLine();


            var student = context.Students.FirstOrDefault(x=>x.Name==sname);

            var course = context.Courses.FirstOrDefault(x=>x.TItle==cname);

            student.Courses.Add(course);

            context.SaveChanges();

        }
        public  void ShowCoursesWithStudent(AppDbContext context)
        {
            ShowCourses(context);
            Console.WriteLine("Enter the name of the course");
            string cname=Console.ReadLine();

            var course = context.Courses.Include(s => s.Students).FirstOrDefault(x=>x.TItle==cname);
            int count=course.Students.Count();

            if(count==0) Console.WriteLine("There is no student in this course"); 
            if (course == null) Console.WriteLine("Course not found with this courseId");
            else
            {
                Console.WriteLine($"Name of the course is : {course.TItle}");

                foreach (var item in course.Students)
                {
                    Console.WriteLine($"Name : {item.Name}");
                }
            }
        }


        public void UpdateStudentEmail(AppDbContext context)
        {
            Console.WriteLine("Enter the name of the student you want to update : ");
            string sname= Console.ReadLine();

            var student=context.Students.FirstOrDefault(s => s.Name==sname);

       
            Console.WriteLine("Enter the new email of the student: ");
            string email=Console.ReadLine();

            student.Email = email;
            var entry = context.Entry(student);
            Console.WriteLine("State :" +entry.State);
            context.SaveChanges();
            Console.WriteLine("State :" +entry.State);

        }
        public void UpdateStudentName(AppDbContext context)
        {
            Console.WriteLine("Enter the name of the student you want to update : ");
            string sname = Console.ReadLine();

            var student = context.Students.FirstOrDefault(s => s.Name == sname);

            Console.WriteLine("Enter the new name of the student: ");
            string name = Console.ReadLine();
            student.Name= name;
            var entry = context.Entry(student);
            Console.WriteLine("State :" + entry.State);
            context.SaveChanges();
            Console.WriteLine("State :" + entry.State);
        }

        public void DeleteStudent(AppDbContext context)
        {
            ShowStudents(context);
            Console.WriteLine("Enter the name of the student to delete : ");
            string name=Console.ReadLine();

            var student = context.Students.FirstOrDefault(s=>s.Name==name);

            context.Students.Remove(student);
            var entry = context.Entry(student);
            Console.WriteLine("State :" + entry.State);
            context.SaveChanges();
            Console.WriteLine("State :" + entry.State);


        }

        public void UpdateTrainerName(AppDbContext context)
        {
            Console.WriteLine("Enter the name of the trainer you want to  update");
            string tname=Console.ReadLine();
            var trainer=context.Trainers.FirstOrDefault(s=>s.Name==tname);

            Console.WriteLine("Enter the new name of the trainer : ");
            string name= Console.ReadLine();
            

            trainer.Name = name;
            var entry = context.Entry(trainer);
            Console.WriteLine("State :" + entry.State);
            context.SaveChanges();
            Console.WriteLine("State :" + entry.State);
        }
        public void UpdateTrainerExperience(AppDbContext context)
        {
            Console.WriteLine("Enter the name of the trainer you want to  update");
            string tname = Console.ReadLine();
            var trainer = context.Trainers.FirstOrDefault(s => s.Name == tname);

            Console.WriteLine("Enter the new experience of the trainer : ");
            int exp = int.Parse(Console.ReadLine());

            trainer.Experience = exp;
            var entry = context.Entry(trainer);
            Console.WriteLine("State :" + entry.State);
            context.SaveChanges();
            Console.WriteLine("State :" + entry.State);
        }

        public void DeleteTrainer(AppDbContext context)
        {
            showTrainer(context);
            Console.WriteLine("Enter the name of the trainer to delete");
            string tname= Console.ReadLine();

            var trainer=context.Trainers.FirstOrDefault(t=>t.Name==tname);

            context.Trainers.Remove(trainer);
            var entry = context.Entry(trainer);
            Console.WriteLine("State :" + entry.State);
            context.SaveChanges();
            Console.WriteLine("State :" + entry.State);

        }


        public void UpdateCourseName(AppDbContext context)
        {
            Console.WriteLine("Enter the name of the course to update : ");
            string cname=Console.ReadLine();

            var course = context.Courses.FirstOrDefault(c=>c.TItle==cname);
            Console.WriteLine("Enter the new name of the course");
            string name=Console.ReadLine();
            course.TItle = name;
            var entry = context.Entry(course);
            Console.WriteLine("State :" + entry.State);
            context.SaveChanges();
            Console.WriteLine("State :" + entry.State);

        }

        public void UpdateCourseFees(AppDbContext context)
        {
            Console.WriteLine("Enter the name of the course to update : ");
            string cname = Console.ReadLine();

            var course = context.Courses.FirstOrDefault(c => c.TItle == cname);
            Console.WriteLine("Enter the new fees");
            double fees = double.Parse(Console.ReadLine());
            course.Fees = fees;
            var entry = context.Entry(course);
            Console.WriteLine("State :" + entry.State);
            context.SaveChanges();
            Console.WriteLine("State :" + entry.State);

        }
        public void UpdateCourseDuration(AppDbContext context)
        {
            Console.WriteLine("Enter the name of the course to update : ");
            string cname = Console.ReadLine();

            var course = context.Courses.FirstOrDefault(c => c.TItle == cname);
            Console.WriteLine("Enter the new  duration in month");
            int duration = int.Parse(Console.ReadLine());
            course.DurationInMonths = duration;
            var entry = context.Entry(course);
            Console.WriteLine("State :" + entry.State);
            context.SaveChanges();
            Console.WriteLine("State :" + entry.State);

        }

        public void DeleteCourse(AppDbContext context)
        {
            ShowCourses(context);
            Console.WriteLine("Enter the name of the course to update : ");
            string cname = Console.ReadLine();

            var course = context.Courses.FirstOrDefault(c => c.TItle == cname);

            context.Courses.Remove(course);
            var entry = context.Entry(course);
            Console.WriteLine("State :" + entry.State);
            context.SaveChanges();
            Console.WriteLine("State :" + entry.State);

        }


        public void UpdateStudentDetails(AppDbContext context)
        {
            ShowStudents(context);
            Console.WriteLine("Enter 1 to update student name");
            Console.WriteLine("Enter 2 to update student email");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:UpdateStudentName(context);
                    break;
                case 2:UpdateStudentEmail(context);
                    break;
            }
        }
        public void UpdateTrainerDetails(AppDbContext context)
        {
            showTrainer(context);
            
            Console.WriteLine("Enter 1 to update trainer name");
            Console.WriteLine("Enter 2 to update trainer experience");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    UpdateTrainerName(context);
                    break;
                case 2:
                    UpdateTrainerExperience(context);
                    break;
            }
        }

        public void UpdateCourseDetails(AppDbContext context)
        {
            ShowCourses(context);
            Console.WriteLine("Enter 1 to update course name");
            Console.WriteLine("Enter 2 to update course duration");
            Console.WriteLine("Enter 3 to update course fees");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    UpdateCourseName(context);
                    break;
                case 2:
                    UpdateCourseDuration(context);
                    break;
                case 3:
                    UpdateCourseFees(context);
                    break;
            }
        }

        public void showTrainer(AppDbContext context)
        {
            Console.WriteLine("-----------Trainers----------");
            var trainer=context.Trainers.ToList();
            foreach (var item in trainer)
            {
                Console.WriteLine("Name: "+item.Name+","+"Experience : "+item.Experience);
            }
        }

        public void DetachedDemo(AppDbContext context)
        {

            var student = context.Students.Find(2);
            var before = context.Entry(student).State;
            Console.WriteLine(before);
            context.Entry(student).State = EntityState.Detached;
            student.Name = "rajesh sigh";
            Console.WriteLine("After modification state : ");
            Console.WriteLine(context.Entry(student).State);
            context.SaveChanges();
            Console.WriteLine(context.Entry(student).State);
            var afterstudent = context.Students.Find(2);
            Console.WriteLine(afterstudent.Name);
        }
   

        //public void ShowTrainerwithCourses(AppDbContext context)
        //{
        //    Console.WriteLine("Enter the name of the trainer");
        //    string tname = Console.ReadLine();

        //    var trainer = context.Trainers.Include(b => b.Batches).ThenInclude(x => x.Course).FirstOrDefault(t => t.Name == tname);
        //    foreach (var item in trainer.Batches)
        //    {
        //        Console.WriteLine($"{item?.Course?.TItle}");
        //    }
        //}
    }
}
