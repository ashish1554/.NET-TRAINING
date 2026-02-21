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
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d=>d.DepartmentId);

            builder.Property(d => d.DepName)
                    .IsRequired()
                    .HasMaxLength(50);


            builder.HasMany(d=>d.Employees)
                    .WithOne(e=>e.Department)
                    .HasForeignKey(e=>e.DepartmentId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Department { DepartmentId = 1, DepName = "IT", Location = "Ahmedabad" },
                new Department { DepartmentId = 2, DepName = "HR", Location = "Gandhinagar" }
                );
        }

      

      
    }
}
