using Microsoft.EntityFrameworkCore;
using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.Core.DTO;
using StoreOnline.DataAccess.Entities;

namespace StoreOnline.DataAccess.Repositories
{
    public class BasketsRepository(ApplicationDbContext context) : IBasketsRepository
    {
        private readonly ApplicationDbContext context = context;

        public async Task<Guid> Create(Basket basket)
        {
            var basketEntity = new BasketEntity
            {
                Id = basket.Id,
                Quantity = basket.Quantity,
                UserId = basket.UserId,
                ProductId = basket.ProductId
            };

            await context.AddAsync(basketEntity);
            await context.SaveChangesAsync();

            return basketEntity.Id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await context.Baskets
                .Where(b => b.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }

        public async Task<List<Basket>> Get()
        {
            var basketsEntities = await context.Baskets
                .AsNoTracking()
                .Include(b => b.User)
                .Include(b => b.Product)
                .ToListAsync();

            var baskets = basketsEntities.Select(b => Basket.Create(
                b.Id,
                b.Quantity,
                b.UserId,
                b.ProductId))
                .ToList();

            return baskets;
        }

        public async Task<Guid> Update(Basket basket)
        {
            await context.Baskets
                .Where(b => b.Id == basket.Id)
                .ExecuteUpdateAsync(x => x
                    .SetProperty(b => b.Quantity, b => basket.Quantity)
                    .SetProperty(b => b.UserId, b => basket.UserId)
                    .SetProperty(b => b.ProductId, b => basket.ProductId));

            return basket.Id;
        }
    }
}