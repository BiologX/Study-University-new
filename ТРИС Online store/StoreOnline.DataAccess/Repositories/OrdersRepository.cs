using Microsoft.EntityFrameworkCore;
using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.Core.Models;
using StoreOnline.DataAccess.Entities;

namespace StoreOnline.DataAccess.Repositories
{
    public class OrdersRepository(ApplicationDbContext context) : IOrdersRepository
    {
        private readonly ApplicationDbContext context = context;

        public async Task<Guid> Create(Order order)
        {
            var orderEntity = new OrderEntity
            {
                Id = order.Id,
                Quantity = order.Quantity,
                TotalPrice = order.TotalPrice,
                Status = order.Status,
                CreatedDate = order.CreatedDate
            };

            await context.AddAsync(orderEntity);
            await context.SaveChangesAsync();

            return orderEntity.Id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await context.Orders
                .Where(o => o.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }

        public async Task<List<Order>> Get()
        {
            var ordersEntities = await context.Orders
                .AsNoTracking()
                .Include(o => o.Product)
                .Include(o => o.User)
                .ToListAsync();

            var orders = ordersEntities.Select(o => Order.Create(
                o.Id,
                o.Quantity,
                o.TotalPrice,
                o.Status,
                o.CreatedDate,
                o.ProductId,
                o.UserId))
                .ToList();

            return orders;
        }

        public async Task<Guid> Update(Order order)
        {
            await context.Orders
                .Where(o => o.Id == order.Id)
                .ExecuteUpdateAsync(x => x
                    .SetProperty(o => o.Quantity, o => order.Quantity)
                    .SetProperty(o => o.TotalPrice, o => order.TotalPrice)
                    .SetProperty(o => o.Status, o => order.Status)
                    .SetProperty(o => o.ProductId, o => order.ProductId)
                    .SetProperty(o => o.UserId, o => order.UserId));

            return order.Id;
        }
    }
}