namespace StoreOnline.Core.DTO
{
    public class Basket
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }

        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }

        private Basket(Guid id, int quantity, Guid userId, Guid productId)
        {
            Id = id;
            Quantity = quantity;
            UserId = userId;
            ProductId = productId;
        }

        public static Basket Create(Guid id, int quantity, Guid userId, Guid productId)
        {
            return new Basket(id, quantity, userId, productId);
        }
    }
}
