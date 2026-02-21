using CTMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMS.Data.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e=>e.EmployeeId);

            builder.Property(e=>e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

            builder.Property(e => e.Email)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasIndex(e => e.Email)
                    .IsUnique();

            builder.HasMany(e => e.Enrollments)
                    .WithOne(e=>e.Employee)
                    .HasForeignKey(e=>e.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict);


            builder.HasData(
                new Employee { EmployeeId=1,Name="Ashish Pateliya",Email="ashish123@gmail.com",DepartmentId=1,Salary=120000},
                new Employee { EmployeeId=2,Name="Raj Rana",Email="raju123@gmail.com",DepartmentId=2,Salary=50000},
                new Employee { EmployeeId = 3, Name = "Nitya Shah", Email = "nitya123@gmail.com", DepartmentId = 2, Salary = 40000 },
                new Employee { EmployeeId = 4, Name = "Mihir Prajapati", Email = "mihir123@gmail.com", DepartmentId = 1, Salary = 30000 }
                );

        }
    }
}
