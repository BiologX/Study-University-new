using StoreOnline.DataAccess.Entities.Base;

namespace StoreOnline.DataAccess.Entities
{
    public class CategoryEntity : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public ICollection<ProductEntity> Products { get; set; } = new List<ProductEntity>();
    }
}
