using StoreOnline.DataAccess.Entities.Base;

namespace StoreOnline.DataAccess.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        public ICollection<OrderEntity> Orders { get; set; } = [];
        public ICollection<BasketEntity> Baskets { get; set; } = [];
    }
}
