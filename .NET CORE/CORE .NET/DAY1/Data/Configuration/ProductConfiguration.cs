using DAY1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

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
        new Product { Id = 1, Name = "Laptop", Category = "Electronics", SellPrice = 60000m, CostPrice = 50000m, Stock = 10 },
        new Product { Id = 2, Name = "Mobile", Category = "Electronics", SellPrice = 20000m, CostPrice = 15000m, Stock = 25 },
        new Product { Id = 3, Name = "Headphones", Category = "Electronics", SellPrice = 3000m, CostPrice = 2000m, Stock = 50 },

        new Product { Id = 4, Name = "Chair", Category = "Furniture", SellPrice = 2500m, CostPrice = 1800m, Stock = 40 },
        new Product { Id = 5, Name = "Table", Category = "Furniture", SellPrice = 7000m, CostPrice = 5000m, Stock = 15 },
        new Product { Id = 6, Name = "Sofa", Category = "Furniture", SellPrice = 25000m, CostPrice = 20000m, Stock = 5 },

        new Product { Id = 7, Name = "Notebook", Category = "Stationery", SellPrice = 100m, CostPrice = 60m, Stock = 200 },
        new Product { Id = 8, Name = "Pen", Category = "Stationery", SellPrice = 20m, CostPrice = 10m, Stock = 500 },
        new Product { Id = 9, Name = "Marker", Category = "Stationery", SellPrice = 40m, CostPrice = 20m, Stock = 150 },

        new Product { Id = 10, Name = "T-Shirt", Category = "Clothing", SellPrice = 800m, CostPrice = 500m, Stock = 60 },
        new Product { Id = 11, Name = "Jeans", Category = "Clothing", SellPrice = 2000m, CostPrice = 1400m, Stock = 30 },
        new Product { Id = 12, Name = "Jacket", Category = "Clothing", SellPrice = 3500m, CostPrice = 2500m, Stock = 20 },

        new Product { Id = 13, Name = "Water Bottle", Category = "Accessories", SellPrice = 400m, CostPrice = 250m, Stock = 80 },
        new Product { Id = 14, Name = "Backpack", Category = "Accessories", SellPrice = 1200m, CostPrice = 800m, Stock = 35 },
        new Product { Id = 15, Name = "Watch", Category = "Accessories", SellPrice = 5000m, CostPrice = 3500m, Stock = 18 }
    );
        }
    }
}
