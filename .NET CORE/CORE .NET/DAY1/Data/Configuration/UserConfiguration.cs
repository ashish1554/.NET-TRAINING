using DAY1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAY1.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Email).IsRequired();
            builder.Property(e => e.Name).IsRequired();
            builder.HasIndex(e => e.Email).IsUnique();
            builder.Property(p => p.HashedPassword).IsRequired();
            builder.Property(r => r.Role).IsRequired();


        }
    }
}
