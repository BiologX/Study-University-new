namespace StoreOnline.Core.DTO
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        private Category(Guid id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }

        public static Category Create(Guid id, string title, string description)
        {
            return new Category(id, title, description);
        }
    }
}
