using CTMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMS.Data.Configuration
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
      

        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.Property(x=>x.PerformanceScore).HasDefaultValue(0);
            builder.ToTable(t =>
            {
                t.HasCheckConstraint(
                    "CK_Enrollment_PerformanceScore",
                    "PerformanceScore >= 0 AND PerformanceScore <= 100"
                );
            });
            builder.HasKey(x => new { x.EmployeeId,x.TrainingProgramId});

            builder.HasData(
                new Enrollment {EmployeeId=2,TrainingProgramId=2,EnrollDate=DateOnly.Parse("2026-02-10"),PerformanceScore=0 }
                );
        }
    }
}
