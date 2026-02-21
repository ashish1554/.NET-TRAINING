    using CTMS.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //()
    namespace CTMS.Data.Configuration
    {
        public class TrainingProgramConfiguration:IEntityTypeConfiguration<TrainingProgram>
        {
            public void Configure(EntityTypeBuilder<TrainingProgram> builder)
            {


                builder.HasKey(x=>x.TrainingProgramId);

                builder.Property(t=>t.Title).HasMaxLength(50).IsRequired();
                builder.HasIndex(t => t.Title).IsUnique();

                builder.HasMany(e => e.Enrollments)
                       .WithOne(t => t.TrainingProgram)
                       .HasForeignKey(f=>f.TrainingProgramId)
                       .OnDelete(DeleteBehavior.Cascade);

                builder.HasOne(x => x.Trainer)
                       .WithMany(p => p.TrainingPrograms)
                       .HasForeignKey(e=>e.TrainerId)
                       .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new TrainingProgram { TrainingProgramId = 1, Title = "Data Science", Duration = 50, StartDate = DateOnly.Parse("2026-01-05") ,TrainerId=4 },
                new TrainingProgram { TrainingProgramId = 2, Title = "Java", Duration = 30, StartDate = DateOnly.Parse("2026-02-05"), TrainerId = 1 }

                );


            }
        
        }
    }
