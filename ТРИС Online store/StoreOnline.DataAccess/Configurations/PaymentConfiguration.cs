using StoreOnline.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StoreOnline.DataAccess.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<PaymentEntity>
    {
        public void Configure(EntityTypeBuilder<PaymentEntity> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.PaymentMethod)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.CreatedDate)
                .IsRequired();
        }
    }
}