using StoreOnline.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StoreOnline.DataAccess.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(1000);
            builder.Property(p => p.Price)
                .IsRequired()
                .HasPrecision(18, 2);
        }
    }
}
