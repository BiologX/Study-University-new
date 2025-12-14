using StoreOnline.DataAccess.Entities.Base;

namespace StoreOnline.DataAccess.Entities
{
    public class BasketEntity : BaseEntity
    {
        public int Quantity { get; set; }

        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }

        public UserEntity? User { get; set; }
        public ProductEntity? Product { get; set; }
    }
}
