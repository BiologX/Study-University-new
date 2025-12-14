using StoreOnline.DataAccess.Entities.Base;

namespace StoreOnline.DataAccess.Entities
{
    public class OrderEntity : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }

        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }

        public ProductEntity? Product { get; set; }
        public UserEntity? User { get; set; }
        public PaymentEntity? Payment { get; set; }
        public DeliveryEntity? Delivery { get; set; }
    }
}
