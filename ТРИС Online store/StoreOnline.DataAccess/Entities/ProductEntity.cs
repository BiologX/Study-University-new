using StoreOnline.DataAccess.Entities.Base;

namespace StoreOnline.DataAccess.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public decimal Price { get; set; }

        
        public ICollection<CategoryEntity> Categories { get; set; } = new List<CategoryEntity>();
        public ICollection<OrderEntity> Orders { get; set; } = new List<OrderEntity>();
        public ICollection<BasketEntity> Baskets { get; set; } = new List<BasketEntity>();
    }
}
