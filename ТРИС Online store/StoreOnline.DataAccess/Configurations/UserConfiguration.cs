using StoreOnline.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StoreOnline.DataAccess.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(u => u.Login)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(u => u.PasswordHash)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
