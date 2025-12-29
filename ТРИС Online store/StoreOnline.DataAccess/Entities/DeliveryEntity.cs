using StoreOnline.DataAccess.Entities.Base;

namespace StoreOnline.DataAccess.Entities
{
    public class DeliveryEntity : BaseEntity
    {
        public string Address { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }

        public Guid OrderId { get; set; }

        public OrderEntity? Order { get; set; }
    }
}
