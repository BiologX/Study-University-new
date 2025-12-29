using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.Core.Models;

namespace StoreOnline.Core.Abstractions.Services
{
    public class ProductsService(IProductsRepository productsRepository) : IProductsService
    {
        private readonly IProductsRepository productsRepository = productsRepository;

        public async Task<Guid> CreateProduct(Product product)
        {
            return await productsRepository.Create(product);
        }

        public async Task<Guid> DeleteProduct(Guid id)
        {
            return await productsRepository.Delete(id);
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await productsRepository.Get();
        }

        public async Task<Guid> UpdateProduct(Product product)
        {
            return await productsRepository.Update(product);
        }
    }
}
