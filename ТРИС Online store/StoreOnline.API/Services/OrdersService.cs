using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.Core.DTO;

namespace StoreOnline.API.Services
{
    public class OrdersService(IOrdersRepository ordersRepository) : IOrdersService
    {
        private readonly IOrdersRepository ordersRepository = ordersRepository;

        public async Task<Guid> CreateOrder(Order order)
        {
            return await ordersRepository.Create(order);
        }

        public async Task<Guid> DeleteOrder(Guid id)
        {
            return await ordersRepository.Delete(id);
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await ordersRepository.Get();
        }

        public async Task<Guid> UpdateOrder(Order order)
        {
            return await ordersRepository.Update(order);
        }
    }
}