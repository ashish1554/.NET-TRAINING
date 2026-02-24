using DAY1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAY1.Data.Configuration
{
    public class ProductConfiguration:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p=>p.Id);
            builder.Property(p=>p.Name)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.Property(p=>p.Category)
                   .HasMaxLength(100)
                   .IsRequired(true);

            builder.HasData(
                new Product() { Id=1,Name="Mobile",Category="Electronics"},
                new Product() { Id = 2, Name = "WashingMachine", Category = "Electronics" },
                new Product() { Id = 3, Name = "TV", Category = "Electronics" },
                new Product() { Id = 4, Name = "Tshirt", Category = "Clothing" },
                new Product() { Id = 5, Name = "Jeans", Category = "Clothing" },
                new Product() { Id = 6, Name = "Jacket", Category = "Clothing" },
                new Product() { Id = 7, Name = "Pizza", Category = "Food" },
                new Product() { Id = 8, Name = "Burger", Category = "Food" },
                new Product() { Id = 9, Name = "Sandwich", Category = "Food" },
                new Product() { Id = 10, Name = "Bat", Category = "Sports" },
                new Product() { Id = 11, Name = "Ball", Category = "Sports" },
                new Product() { Id = 12, Name = "Racket", Category = "Sports" }

                );
        }
    }
}
