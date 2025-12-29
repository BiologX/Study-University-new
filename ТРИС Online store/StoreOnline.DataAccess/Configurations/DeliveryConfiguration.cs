using StoreOnline.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StoreOnline.DataAccess.Configurations
{
    public class DeliveryConfiguration : IEntityTypeConfiguration<DeliveryEntity>
    {
        public void Configure(EntityTypeBuilder<DeliveryEntity> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Address)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(d => d.Status)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(d => d.CreatedDate)
                .IsRequired();
        }
    }
}