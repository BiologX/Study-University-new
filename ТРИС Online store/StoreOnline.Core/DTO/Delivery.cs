namespace StoreOnline.Core.Models
{
    public class Delivery
    {
        public Guid Id { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public Guid OrderId { get; set; }

        private Delivery(Guid id, string adress, string status, DateTime createdDate, Guid orderId)
        {
            Id = id;
            Address = adress;
            Status = status;
            CreatedDate = createdDate;
            OrderId = orderId;
        }

        public static Delivery Create(Guid id, string adress, string status, DateTime createdDate, Guid orderId)
        {
            return new Delivery(id, adress, status, createdDate, orderId);
        }
    }
}
