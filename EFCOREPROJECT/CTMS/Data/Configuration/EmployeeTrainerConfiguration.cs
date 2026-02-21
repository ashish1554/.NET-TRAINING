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
    public class EmployeeTrainerConfiguration : IEntityTypeConfiguration<EmployeeTrainer>
    {
        public void Configure(EntityTypeBuilder<EmployeeTrainer> builder)
        {
            //here one to one relationship so we need to tell at which side i want foreign key
            //otherwise if there is one to many or many to many then EF core automatically decide which side has foreign key

            builder.HasKey(e => e.EmployeeId);

            builder.HasOne(e => e.Employee)
                    .WithOne(et => et.EmployeeTrainer)
                    .HasForeignKey<EmployeeTrainer>(et=>et.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new EmployeeTrainer { EmployeeId=1,ExpertiseLevel="Expert"},
                new EmployeeTrainer { EmployeeId = 4, ExpertiseLevel = "Beginner" }
                );
        }
    }
}
