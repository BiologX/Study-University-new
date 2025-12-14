namespace StoreOnline.Core.Models
{
    public class Payment
    {
        public Guid Id { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }

        private Payment(Guid id,  string paymentMethod, DateTime createdDate)
        {
            Id = id;
            PaymentMethod = paymentMethod;
            CreatedDate = createdDate;
        }

        public static Payment Create(Guid id, string paymentMethod, DateTime createdDate)
        {
            return new Payment(id, paymentMethod, createdDate);
        }
    }
}
