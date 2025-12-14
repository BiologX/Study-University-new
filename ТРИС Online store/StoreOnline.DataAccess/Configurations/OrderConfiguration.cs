using StoreOnline.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StoreOnline.DataAccess.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Quantity)
                .IsRequired();
            builder.Property(o => o.TotalPrice)
                .IsRequired()
                .HasPrecision(18, 2);
            builder.Property(o => o.CreatedDate)
                .IsRequired();
            builder.Property(o => o.Status)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}