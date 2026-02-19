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
            context.SaveChanges();

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
            context.SaveChanges();

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
            context.SaveChanges();

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
            context.SaveChanges();
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
