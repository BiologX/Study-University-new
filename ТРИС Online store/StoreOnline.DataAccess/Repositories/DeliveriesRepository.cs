using Microsoft.EntityFrameworkCore;
using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.Core.DTO;
using StoreOnline.DataAccess.Entities;

namespace StoreOnline.DataAccess.Repositories
{
    public class DeliveriesRepository(ApplicationDbContext context) : IDeliveriesRepository
    {
        private readonly ApplicationDbContext context = context;

        public async Task<Guid> Create(Delivery delivery)
        {
            var deliveryEntity = new DeliveryEntity
            {
                Id = delivery.Id,
                Address = delivery.Address,
                Status = delivery.Status,
                CreatedDate = delivery.CreatedDate,
                OrderId = delivery.OrderId
            };

            await context.AddAsync(deliveryEntity);
            await context.SaveChangesAsync();

            return deliveryEntity.Id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await context.Deliveries
                .Where(d => d.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }

        public async Task<List<Delivery>> Get()
        {
            var deliveriesEntities = await context.Deliveries
                .AsNoTracking()
                .Include(d => d.Order)
                .ToListAsync();

            var deliveries = deliveriesEntities.Select(d => Delivery.Create(
                d.Id,
                d.Address,
                d.Status,
                d.CreatedDate,
                d.OrderId))
                .ToList();

            return deliveries;
        }

        public async Task<Guid> Update(Delivery delivery)
        {
            await context.Deliveries
                .Where(d => d.Id == delivery.Id)
                .ExecuteUpdateAsync(x => x
                    .SetProperty(d => d.Address, d => delivery.Address)
                    .SetProperty(d => d.Status, d => delivery.Status)
                    .SetProperty(d => d.CreatedDate, d => delivery.CreatedDate)
                    .SetProperty(d => d.OrderId, d => delivery.OrderId));

            return delivery.Id;
        }
    }
}