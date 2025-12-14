namespace StoreOnline.Core.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }

        private Order(Guid id, int quantity, decimal totalPrice, string status, DateTime createdDate)
        {
            Id = id;
            Quantity = quantity;
            TotalPrice = totalPrice;
            Status = status;
            CreatedDate = createdDate;
        }

        public static Order Create(Guid id, int quantity, decimal totalPrice, string status, DateTime createdDate)
        {
            return new Order(id, quantity, totalPrice, status, createdDate);
        }
    }
}
