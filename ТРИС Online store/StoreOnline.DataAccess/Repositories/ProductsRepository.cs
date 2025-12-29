using Microsoft.EntityFrameworkCore;
using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.Core.Models;
using StoreOnline.DataAccess.Entities;

namespace StoreOnline.DataAccess.Repositories
{
    public class ProductsRepository(ApplicationDbContext context) : IProductsRepository
    {
        private readonly ApplicationDbContext context = context;

        public async Task<Guid> Create(Product product)
        {
            var productEntity = new ProductEntity
            {
                Id = product.Id,
                Title = product.Title,
                Description = product.Description,
                Price = product.Price
            };

            await context.AddAsync(productEntity);
            await context.SaveChangesAsync();

            return productEntity.Id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await context.Products
                .Where(p => p.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }

        public async Task<List<Product>> Get()
        {
            var productsEntities = await context.Products
                .AsNoTracking()
                .ToListAsync();

            var products = productsEntities.Select(p => Product.Create(p.Id, p.Title, p.Description, p.Price))
                .ToList();

            return products;
        }

        public async Task<Guid> Update(Product product)
        {
            await context.Products
                .Where(p => p.Id == product.Id)
                .ExecuteUpdateAsync(x => x
                .SetProperty(p => p.Title, p => product.Title)
                .SetProperty(p => p.Description, p => product.Description)
                .SetProperty(p => p.Price, p => product.Price));

            return product.Id;
        }
    }
}
