namespace StoreOnline.Core.Models
{
    public class Payment
    {
        public Guid Id { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public Guid OrderId { get; set; }

        private Payment(Guid id,  string paymentMethod, DateTime createdDate, Guid orderId)
        {
            Id = id;
            PaymentMethod = paymentMethod;
            CreatedDate = createdDate;
            OrderId = orderId;
        }

        public static Payment Create(Guid id, string paymentMethod, DateTime createdDate, Guid orderId)
        {
            return new Payment(id, paymentMethod, createdDate, orderId);
        }
    }
}
