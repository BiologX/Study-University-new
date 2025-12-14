using StoreOnline.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace StoreOnline.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Защищенный конструктор для миграций
        protected ApplicationDbContext() : base()
        {
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<BasketEntity> Baskets { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<PaymentEntity> Payments { get; set; }
        public DbSet<DeliveryEntity> Deliveries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Автоматически применить ВСЕ конфигурации из сборки
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
