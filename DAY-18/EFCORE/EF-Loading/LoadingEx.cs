using EFCORE.Data;
using EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE.EF_Loading
{
    public class LoadingEx
    {
      
         public void LoadingDemo(AppDbContext context)
        {
            Console.WriteLine("=======================");
            Console.WriteLine("First much check the lazy loading to visualize how it call multiple time.\n if you first enter 1 Eager loading then you can not visualize because EF core keep the change tracker.\n if first i use the Eager loading then EF will reuse the track entities");
            Console.WriteLine("=======================");
            Console.WriteLine("Enter 1 for Eager loading...");
            Console.WriteLine("Enter 2 for lazy loading and  how include overcome n+1");
            int no=int.Parse(Console.ReadLine());
            switch (no)
            {
                case 1:EagerLoading(context);
                      break;
                case 2:
                    NplusOne(context);
                    break;
                case 3:
                    Explicit(context);
                    break;
            }
        }

        public void NplusOne(AppDbContext context)
        {
            context.EnableSqlLogging = true;

            //this is n+1 problem
            //here what happens like we first fetch the student data--->one query
            //as we dont include courses the courses data is not included
            Console.WriteLine("-----N+1 Problem-----");

            var result = context.Students.ToList();
            
            foreach (var item in result) 
            {
                
                Console.WriteLine(item.Name);
                //here lazy loading is happens means each time it hits the database 
                //means in lazy loading data is loaded each time we iterate means it goes to the database
                foreach (var item2 in item.Courses)
                {
                    Console.WriteLine(item2.TItle);
                }
            }


            //when we use include then it performs the eager loading means data of dependent entity is loaded at a time when we load the parent entity data
            //means using only single query course data is also included with student data
            Console.WriteLine("=====================================================================");
            Console.WriteLine("-----Using Include-----");
            var ans = context.Students.Include(x=>x.Courses);
            foreach (var item in ans) 
            { 
                Console.WriteLine(item.Name);
                foreach (var item2 in item.Courses)
                {
                    Console.WriteLine(item2.TItle);
                }
            }
            context.EnableSqlLogging = false;


        }

        public void EagerLoading(AppDbContext context)
        {
            //in this in one query all three tableis fetched from the database
            var result = context.Students.Include(x => x.Courses).ThenInclude(s => s.Batches);

            foreach (var item in result)
            {
                Console.WriteLine("\nName of the student : " + item.Name);
                foreach (var item2 in item.Courses)
                {
                    Console.WriteLine("\nName of the course : " + item2.TItle);
                    foreach (var item3 in item2.Batches)
                    {
                        Console.Write("\tBatch: " + item3.BatchId);
                    }
                }
            }
        }

        public void Explicit(AppDbContext context)
        {
            var ans = context.Students.FirstOrDefault(x=>x.Id==2);
            context.Entry(ans).Collection(x => x.Courses).Load();

        }
    }
}
