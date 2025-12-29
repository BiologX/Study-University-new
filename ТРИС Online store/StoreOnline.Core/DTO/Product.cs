namespace StoreOnline.Core.DTO
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

        private Product(Guid id, string title, string description, decimal price)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
        }

        public static Product Create(Guid id, string title, string description, decimal price)
        {
            return new Product(id, title, description, price);
        }
    }
}
