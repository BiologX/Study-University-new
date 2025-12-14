using StoreOnline.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StoreOnline.DataAccess.Configurations
{
    public class BasketConfiguration : IEntityTypeConfiguration<BasketEntity>
    {
        public void Configure(EntityTypeBuilder<BasketEntity> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Quantity)
                .IsRequired();
        }
    }
}