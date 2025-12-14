using StoreOnline.DataAccess.Entities.Base;

namespace StoreOnline.DataAccess.Entities
{
    public class PaymentEntity : BaseEntity
    {
        public string PaymentMethod { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }

        public Guid OrderId { get; set; }

        public OrderEntity? Order { get; set; }
    }
}
