using StoreOnline.Core.DTO;

namespace StoreOnline.Core.Abstractions.Repositories
{
    public interface IProductsRepository
    {
        Task<Guid> Create(Product product);
        Task<Guid> Delete(Guid id);
        Task<List<Product>> Get();
        Task<Guid> Update(Product product);
    }
}
