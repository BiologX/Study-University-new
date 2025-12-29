using StoreOnline.Core.Models;

namespace StoreOnline.Core.Abstractions.Services
{
    public interface IOrdersService
    {
        Task<Guid> CreateOrder(Order order);
        Task<Guid> DeleteOrder(Guid id);
        Task<List<Order>> GetAllOrders();
        Task<Guid> UpdateOrder(Order order);
    }
}
