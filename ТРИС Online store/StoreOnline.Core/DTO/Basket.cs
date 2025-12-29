namespace StoreOnline.Core.Models
{
    public class Basket
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }

        private Basket(Guid id, int quantity)
        {
            Id = id;
            Quantity = quantity;
        }

        public static Basket Create(Guid id, int quantity)
        {
            return new Basket(id, quantity);
        }
    }
}
