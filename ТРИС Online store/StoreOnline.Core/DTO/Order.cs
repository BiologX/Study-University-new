namespace StoreOnline.Core.DTO
{
    public class Order
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }

        private Order(Guid id, int quantity, decimal totalPrice, string status, DateTime createdDate, Guid productId, Guid userId)
        {
            Id = id;
            Quantity = quantity;
            TotalPrice = totalPrice;
            Status = status;
            CreatedDate = createdDate;
            ProductId = productId;
            UserId = userId;
        }

        public static Order Create(Guid id,int quantity, decimal totalPrice, string status, DateTime createdDate, Guid productId, Guid userId)
        {
            return new Order(id, quantity, totalPrice, status, createdDate, productId, userId);
        }
    }
}
