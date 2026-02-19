using EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFCORE.Data
{
    public class AppDbContext : DbContext
    {
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EFCoreDemo;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Student> Students { get; set; } 
        public DbSet<Course> Courses { get; set; }

        public DbSet<Batch> Batches { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
     }
}
