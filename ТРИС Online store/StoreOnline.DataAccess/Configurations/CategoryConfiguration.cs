using StoreOnline.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StoreOnline.DataAccess.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(1000);
        }
    }
}
