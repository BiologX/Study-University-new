using StoreOnline.Core.DTO;

namespace StoreOnline.Core.Abstractions.Services
{
    public interface IProductsService
    {
        Task<Guid> CreateProduct(Product product);
        Task<Guid> DeleteProduct(Guid id);
        Task<List<Product>> GetAllProducts();
        Task<Guid> UpdateProduct(Product product);
    }
}
